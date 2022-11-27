using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.bitacora;
using SistemaGestorEventos.SharedServices.hash;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class EventRoomBLL : AbstractBLL
    {

        private static readonly EventRoomBLL instance = new EventRoomBLL();

        private EventRoomDAL eventRoomDAL = EventRoomDAL.Instance;

        private EventRoomBLL()
        {

        }

        public static EventRoomBLL Instance => instance;

        public IList<EventRoom> FindAvailiableEventrooms(Int32? id, string name, DateTime from, DateTime to)
        {
            return this.eventRoomDAL.FindAvailable(id, name, from, to) ;
        }


        public IList<EventRoom> Find(Int32? id, string name)
        {
            return this.eventRoomDAL.Find(id, name);
        }


        public List<string> Save(EventRoom eventRoom, Guid userId)
        {
            var errors = Validate(eventRoom);

            if (errors.Count > 0)
            {
                BitacoraSingleton.Log("Se intento guardar un lugar, pero fallo por errores de validación.");
            }
            else
            {
                bool validateDVV = ValidateDVV();
                
                eventRoom.Id = this.eventRoomDAL.Save(eventRoom, userId);
                
                if (validateDVV)
                {
                    this.eventRoomDAL.RegenerateDVV();
                }
                
                BitacoraSingleton.Log("Se guardo el lugar id: " + eventRoom.Id);
            }

            return errors;
        }

        public bool ValidateDVV()
        {
            if (eventRoomDAL.ValidateDVV())
            {
                BitacoraSingleton.Log("Se valido el DVV de la entidad EventRoom");
                return true;
            } 
            else
            {
                BitacoraSingleton.Log("Error al DVV de la entidad EventRoom");
                return false;
            }
        }

        public List<string> Validate(EventRoom eventRoom)
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(eventRoom.Address))
            {
                errors.Add(MultiLang.TranslateOrDefault("error.eventroom.address.required", "La dirección es requerida"));
            }

            if (string.IsNullOrWhiteSpace(eventRoom.Name))
            {
                errors.Add(MultiLang.TranslateOrDefault("error.eventroom.name.required", "El nombre es requerido"));
            }

            if (eventRoom.Price <= 0)
            {
                errors.Add(MultiLang.TranslateOrDefault("error.eventroom.price.required", "El precio es requerido y debe ser mayor a 0."));
            }

            if (eventRoom.Capacity <= 0)
            {
                errors.Add(MultiLang.TranslateOrDefault("error.eventroom.capacity.required", "Debe ingresar una capacidad de invitados mayor que 0."));
            }

            if (eventRoom.BucketSize <= 0)
            {
                errors.Add(MultiLang.TranslateOrDefault("error.eventroom.bucketsize.required", "Debe ingresar un intervalo de tiempo mayor que 0."));
            }

            return errors;

        }

        public bool CheckIntegrity(EventRoom eventRoom)
        {
            var dvh = GenerateDVH(eventRoom);

            return dvh == eventRoom.DVH;
            
        }

        public int GenerateDVH(EventRoom eventRoom)
        {
            int dvh = CheckerDigit.Generate(eventRoom.Price, eventRoom.Name, eventRoom.BucketSize, eventRoom.Address, eventRoom.Name);

            return dvh;
        }

        public IList<EventRoom> FindHistory(int id)
        {
            BitacoraSingleton.Log("Se consulto el historial del lugar " + id);
            return EventRoomDAL.Instance.FindHistory(id);
        }

        public List<string> RegenerateDVV()
        {
            var eventRooms = eventRoomDAL.FindAll();
            var errors = new List<string>();

            foreach(var room in eventRooms)
            {
                if (!CheckIntegrity(room))
                {
                    errors.Add(MultiLang.TranslateOrDefault("eventroom.errors.dvv.dvhfails", "Integridad fallida para el lugar: ") + room.Id);
                }
            }

            if (errors.Count == 0)
            {
                eventRoomDAL.RegenerateDVV();
                BitacoraSingleton.Log("Se regenero el DVV de la tabla EventRoom");
            }

            return errors;
        }
    }
}
