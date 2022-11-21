using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using SistemaGestorEventos.SharedServices.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Lugares
{
    public partial class FrmPlace : Form
    {

        private EventRoom eventRoom;

        private FrmPlace()
        {
            InitializeComponent();
            

        }

        public static FrmPlace CreateNew()
        {
            var eventRoom = new EventRoom();
            eventRoom.Active = true;

            return CreateEdit(eventRoom);
        }

        public static FrmPlace CreateEdit(EventRoom eventRoom)
        {
            var frm = new FrmPlace();
            frm.eventRoom = eventRoom; 

            return frm;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            var errors = EventRoomBLL.Instance.Save(this.eventRoom, SessionHandler.GetInstance.User.Id);

            if (errors.Count > 0)
            {
                WinformUtils.ShowErrorList(MultiLang.TranslateOrDefault("eventroom.abmc.errortitle", "Deberá corregir los siguientes puntos"), errors);
            } else
            {
                MessageBox.Show(MultiLang.TranslateOrDefault("eventoroom.abmc.saved", "Se guardó el lugar #") + eventRoom.Id);
                this.Close();
            }
        }

        private void FrmPlace_Load(object sender, EventArgs e)
        {
            txtId.DataBindings.Add("Text", this.eventRoom, "Id");
            txtAddress.DataBindings.Add("Text", this.eventRoom, "Address");
            txtCapacity.DataBindings.Add("Text", this.eventRoom, "Capacity");
            txtPrice.DataBindings.Add("Text", this.eventRoom, "Price");
            txtName.DataBindings.Add("Text", this.eventRoom, "Name");
            cbxActive.DataBindings.Add("Checked", this.eventRoom, "Active");
            txtBucketSize.DataBindings.Add("Text", this.eventRoom, "BucketSize");

            MultiLang.SubscribeChangeLangEvent(Translate);

            
        }



        private void Translate()
        {
            WinformUtils.TraducirControl(this);
        }

        private void FrmPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
            MultiLang.UnscribeChangeLangEvent(Translate);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
