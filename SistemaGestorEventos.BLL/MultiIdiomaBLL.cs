using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class MultiIdiomaBLL : AbstractBLL,IMultiLangDataSource
    {
        private static readonly MultiIdiomaBLL multiIdiomaBLL = new MultiIdiomaBLL();

        private readonly MultiIdiomaDAL multiIdiomaDAL = MultiIdiomaDAL.Instance;
        public static MultiIdiomaBLL Instance => multiIdiomaBLL;

        private MultiIdiomaBLL() { }

        public Dictionary<string, string> LoadLang(string idioma)
        {
            return multiIdiomaDAL.LoadLang(idioma);
        }

        public void UpsertTranslate(string idioma, string key, string value)
        {
            multiIdiomaDAL.UpsertTranslate(idioma, key, value);
        }

        public List<Idioma> GetAllIdiomas()
        {
            return multiIdiomaDAL.GetAllIdiomas();
        }

        public Dictionary<string, string> GetTraduccionesDefault()
        {
            return multiIdiomaDAL.LoadLang("es-AR");
        }

        public Dictionary<string,string> CargarIdiomaFull(string idioma)
        {
            var traduccionesDefault = this.GetTraduccionesDefault();
            var traducciones = this.LoadLang(idioma);

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
                UpsertTranslate(idioma.Id, key, traducciones[key]);
            }
        }
    }
}
