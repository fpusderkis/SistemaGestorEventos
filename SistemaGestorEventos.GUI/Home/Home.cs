using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Home
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnNewEvent_Click(object sender, EventArgs e)
        {
            var form = new Events.EventForm();
            form.ShowDialog();
        }
    }
}
