using SistemaGestorEventos.BE;
using SistemaGestorEventos.DAL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.BLL
{
    public class MultiLangBLL : AbstractBLL,IMultiLangDataSource
    {
        private static readonly MultiLangBLL multiLangBll = new MultiLangBLL();

        private readonly MultiLangDAL multiIdiomaDAL = MultiLangDAL.Instance;
        public static MultiLangBLL Instance => multiLangBll;

        private MultiLangBLL() { }

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

        /// <summary>
        /// Carga el idioma seleccionado, haciendo un join con el idioma default para completar las keys faltantes.
        /// </summary>
        /// <param name="idioma">Idioma a cargar</param>
        /// <returns>Listado completo de keyvalues traducidos.</returns>
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

        public Idioma CrearIdioma(string id, string description)
        {
            var lang = new Idioma() { Id = id, Descripcion = description };

            multiIdiomaDAL.UpsertIdioma(lang);

            return lang;
        }

        public void GuardarIdioma(Idioma idioma, Dictionary<string, string> traducciones)
        {
            CrearIdioma(idioma.Id,idioma.Descripcion);
            foreach (var key in traducciones.Keys)
            {
                UpsertTranslate(idioma.Id, key, traducciones[key]);
            }
        }
    }
}
