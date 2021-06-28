using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Utils
{
    public static class WinformUtils
    {
        public static void TraducirControl(Control control)
        {
            TraducirControl(control, "");
        }

        public static void TraducirControl(Control control, string rootkey)
        {
            var key = rootkey + control.Name;
            
            var traduccion = MultiIdioma.Traduccion(key);

            string text;
            if (control is TextBox)
            {
                text = ((TextBox)control).PlaceholderText;
            } else
            {
                text = control.Text;
            }
            if (control is ListBox)
            {
                return;
            }

            if (traduccion == null && !string.IsNullOrEmpty(text))
            {
                MultiIdioma.AgregarTraduccion(key, text);
                traduccion = MultiIdioma.Traduccion(control.Name);
            }

            if (control is TextBox)
            {
                ((TextBox)control).PlaceholderText = traduccion;
            }
            else
            {
                control.Text = traduccion;
            }

            foreach (Control c in control.Controls)
            {
                TraducirControl(c, key + ".");
            }
        }
    }
}
