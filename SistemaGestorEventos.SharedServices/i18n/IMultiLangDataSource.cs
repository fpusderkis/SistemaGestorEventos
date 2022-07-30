using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestorEventos.SharedServices.i18n
{
    public interface IMultiLangDataSource
    {
        Dictionary<string,string> LoadLang(string idioma);
        void UpsertTranslate(string idioma, string key, string value);
    }
}
