
using System;
using System.Collections.Generic;

namespace SistemaGestorEventos.SharedServices.Multiidioma
{
    public class MultiIdioma
    {
        private Dictionary<string, Dictionary<string, string>> idiomasCache;
        private IMultiIdiomaDataSource datasource;
        private string idiomaDefecto;
        private string idiomaActual;

        private List<Action> subscribers = new List<Action>();

        private static readonly MultiIdioma instance = new MultiIdioma();

        private MultiIdioma()
        {
            idiomasCache = new Dictionary<string, Dictionary<string, string>>();
        }

        public static void Initialize(IMultiIdiomaDataSource datasource, string idiomaDefecto)
        {
            instance.datasource = datasource;
            instance.idiomaDefecto = idiomaDefecto;
            instance.idiomaActual = idiomaDefecto;

            instance.LoadIdioma(idiomaDefecto);
            instance.FireOnLanguageChangeEvent();

        }

        public static void CambiarIdioma(string idioma)
        {
            instance.LoadIdioma(idioma);
            instance.idiomaActual = idioma;
            instance.FireOnLanguageChangeEvent();
        }
        private void LoadIdioma(string idioma)
        {
            Dictionary<string, string> idiomaDictionary = this.datasource.CargarIdioma(idioma);

            this.idiomasCache[idioma] = idiomaDictionary;
        }

        public static string TraduccionODefault(string key, string value)
        {
            var traduccion = Traduccion(key);

            if (traduccion == null && !string.IsNullOrEmpty(value))
            { 
                MultiIdioma.AgregarTraduccion(key, value);
                return value;
            } else
            {
                return traduccion;
            }


        }

        public static string Traduccion(string key)
        {
            return Traduccion(key, instance.idiomaActual);
        }

        public static string Traduccion(string key, string idioma)
        {
            if (instance.idiomasCache[idioma] == null)
            {
                instance.LoadIdioma(idioma);
            }

            if (instance.idiomasCache.ContainsKey(idioma) && instance.idiomasCache[idioma].ContainsKey(key) && !string.IsNullOrWhiteSpace(instance.idiomasCache[idioma][key]))
            {
                return instance.idiomasCache[idioma][key];
            } 
            else if(instance.idiomasCache[instance.idiomaDefecto].ContainsKey(key))
            {
                return instance.idiomasCache[instance.idiomaDefecto][key];
            } 
            else
            {
                return null;
            }

        }

        public static void SuscribeCambioDeIdiomaEvent(Action action)
        {
            instance.subscribers.Add(action);
        }
        public static void UnsuscribeCambioDeIdiomaEvent(Action action)
        {
            instance.subscribers.Remove(action);
        }


        private void FireOnLanguageChangeEvent()
        {
            subscribers.ForEach(s => s());
        }

        public static void AgregarTraduccion(string key, string value)
        {
            AgregarTraduccion(instance.idiomaDefecto,key, value);
        }

        public static void AgregarTraduccion(string idioma, string key, string value)
        {
            instance.datasource.UpsertTraduccion(idioma, key, value);
            instance.LoadIdioma(idioma);
            instance.FireOnLanguageChangeEvent();
        }
    }
}
