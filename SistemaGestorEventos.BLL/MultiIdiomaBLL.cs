using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class MultiIdiomaBLL : IMultiIdiomaDataSource
    {
        private static readonly MultiIdiomaBLL multiIdiomaBLL = new MultiIdiomaBLL();

        private readonly MultiIdiomaDAL multiIdiomaDAL = MultiIdiomaDAL.Instance;
        public static MultiIdiomaBLL Instance => multiIdiomaBLL;

        private MultiIdiomaBLL() { }

        public Dictionary<string, string> CargarIdioma(string idioma)
        {
            return multiIdiomaDAL.CargarIdioma(idioma);
        }

        public void AgregarTraduccion(string idioma, string key, string value)
        {
            multiIdiomaDAL.AgregarTraduccion(idioma, key, value);
        }
    }
}
