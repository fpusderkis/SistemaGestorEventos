﻿using SistemaGestorEventos.BE;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.DAL
{
    public class LugarDAL : AbstractDAL
    {
        public List<EventRoom> BuscarLugares(String nombre, Guid idLocalidad, Guid idCategoria)
        {
            return new List<EventRoom>();
        }
    }
}
