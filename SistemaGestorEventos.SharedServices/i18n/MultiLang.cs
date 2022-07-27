
using System;
using System.Collections.Generic;

namespace SistemaGestorEventos.SharedServices.i18n
{
    public class MultiLang
    {
        private Dictionary<string, Dictionary<string, string>> langCache;
        private IMultiLangDataSource datasource;
        private string defaultLang;
        private string currentLang;

        private List<Action> subscribers = new List<Action>();

        private static readonly MultiLang instance = new MultiLang();

        private MultiLang()
        {
            langCache = new Dictionary<string, Dictionary<string, string>>();
        }

        public static void Initialize(IMultiLangDataSource datasource, string defaultLang)
        {
            instance.datasource = datasource;
            instance.defaultLang = defaultLang;
            instance.currentLang = defaultLang;

            instance.LoadLang(defaultLang);
            instance.FireOnLanguageChangeEvent();

        }

        public static void ChangeLang(string lang)
        {
            instance.LoadLang(lang);
            instance.currentLang = lang;
            instance.FireOnLanguageChangeEvent();
        }
        private void LoadLang(string lang)
        {
            Dictionary<string, string> idiomaDictionary = this.datasource.LoadLang(lang);

            this.langCache[lang] = idiomaDictionary;
        }

        public static string TranslateOrDefault(string key, string value)
        {
            var traduccion = Translate(key);

            if (traduccion == null && !string.IsNullOrEmpty(value))
            { 
                MultiLang.AddTranslate(key, value);
                return value;
            } else
            {
                return traduccion;
            }


        }

        public static string Translate(string key)
        {
            return Translate(key, instance.currentLang);
        }

        public static string Translate(string key, string lang)
        {
            if (string.IsNullOrWhiteSpace(lang))
            {
                return null;
            }

            if (!string.IsNullOrWhiteSpace(lang) && instance.langCache[lang] == null)
            {
                instance.LoadLang(lang);
            }

            if (instance.langCache.ContainsKey(lang) && instance.langCache[lang].ContainsKey(key) && !string.IsNullOrWhiteSpace(instance.langCache[lang][key]))
            {
                return instance.langCache[lang][key];
            } 
            else if(instance.langCache[instance.defaultLang].ContainsKey(key))
            {
                return instance.langCache[instance.defaultLang][key];
            } 
            else
            {
                return null;
            }

        }

        public static void SubscribeChangeLangEvent(Action action)
        {
            instance.subscribers.Add(action);
        }
        public static void UnscribeChangeLangEvent(Action action)
        {
            instance.subscribers.Remove(action);
        }


        private void FireOnLanguageChangeEvent()
        {
            subscribers.ForEach(s => s());
        }

        public static void AddTranslate(string key, string value)
        {
            if (instance.defaultLang != null)
            AddTranslate(instance.defaultLang,key, value);
        }

        public static void AddTranslate(string idioma, string key, string value)
        {
            instance.datasource.UpsertTranslate(idioma, key, value);
            instance.LoadLang(idioma);
            instance.FireOnLanguageChangeEvent();
        }
    }
}
