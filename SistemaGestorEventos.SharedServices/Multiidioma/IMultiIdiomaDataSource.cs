using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.Multiidioma
{
    public interface IMultiIdiomaDataSource
    {
        Dictionary<string,string> CargarIdioma(string idioma);
        void UpsertTraduccion(string idioma, string key, string value);
    }
}
