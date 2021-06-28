using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class MultiIdiomaBLL : AbstractBLL,IMultiIdiomaDataSource
    {
        private static readonly MultiIdiomaBLL multiIdiomaBLL = new MultiIdiomaBLL();

        private readonly MultiIdiomaDAL multiIdiomaDAL = MultiIdiomaDAL.Instance;
        public static MultiIdiomaBLL Instance => multiIdiomaBLL;

        private MultiIdiomaBLL() { }

        public Dictionary<string, string> CargarIdioma(string idioma)
        {
            return multiIdiomaDAL.CargarIdioma(idioma);
        }

        public void UpsertTraduccion(string idioma, string key, string value)
        {
            multiIdiomaDAL.UpsertTraduccion(idioma, key, value);
        }

        public List<Idioma> GetAllIdiomas()
        {
            return multiIdiomaDAL.GetAllIdiomas();
        }

        public Dictionary<string, string> GetTraduccionesDefault()
        {
            return multiIdiomaDAL.CargarIdioma("es-AR");
        }

        public Dictionary<string,string> CargarIdiomaFull(string idioma)
        {
            var traduccionesDefault = this.GetTraduccionesDefault();
            var traducciones = this.CargarIdioma(idioma);

            foreach (string key in traduccionesDefault.Keys)
            {
                if (!traducciones.ContainsKey(key))
                {
                    traducciones.Add(key, null);
                }
            }

            return traducciones;
        }

        public void GuardarIdioma(Idioma idioma, Dictionary<string, string> traducciones)
        {
            foreach(var key in traducciones.Keys)
            {
                UpsertTraduccion(idioma.Id, key, traducciones[key]);
            }
        }
    }
}
