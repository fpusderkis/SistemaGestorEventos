using SistemaGestorEventos.SharedServices.Multiidioma;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.SharedServices.Multiidioma
{
    public static class WinformUtils
    {
        public static void TraducirControl(Control control)
        {
            var key = string.Empty;
            var traduccion = string.Empty;
            string text;
            if (control.Tag != null && !string.IsNullOrWhiteSpace(control.Tag.ToString()))
            {
                key = control.Tag.ToString();
                traduccion = MultiIdioma.Translate(key);
                if (control is TextBox)
                {
                    text = ((TextBox)control).PlaceholderText;
                }
                else
                {
                    text = control.Text;
                }
                if (control is ListBox)
                {
                    return;
                }

                if (traduccion == null && !string.IsNullOrEmpty(text))
                {
                    MultiIdioma.AddTranslate(key, text);
                    traduccion = MultiIdioma.Translate(key);
                }

                if (control is TextBox)
                {
                    ((TextBox)control).PlaceholderText = traduccion;
                }
                else
                {
                    control.Text = traduccion;
                }
            } 
            if (control is MenuStrip menu)
            {
                foreach (ToolStripMenuItem toolStrip in menu.Items)
                {
                    TraducirMenuStrip(toolStrip);
                }
            } else
            {
                foreach (Control c in control.Controls)
                {
                    TraducirControl(c);
                }
            }

            
        }

        public static void TraducirMenuStrip(ToolStripItem menu)
        {
            if (menu.Tag != null && !string.IsNullOrWhiteSpace(menu.Tag.ToString())) {
                var key = menu.Tag.ToString();
                var traduccion = MultiIdioma.Translate(key);
                var text = menu.Text;

                if (traduccion == null && !string.IsNullOrEmpty(text))
                {
                    MultiIdioma.AddTranslate(key, text);
                    traduccion = MultiIdioma.Translate(key);
                }
                

                menu.Text = traduccion;
            }

            if (menu is ToolStripDropDownItem drop)
            foreach (ToolStripMenuItem submenu in drop.DropDownItems)
            {
                TraducirMenuStrip(submenu);
            }


        }



        public static void HacerVisibles(Control control)
        {
            control.Visible = true;
            foreach (Control c in control.Controls)
            {
                HacerVisibles(c);
            }
        }
    }
}
