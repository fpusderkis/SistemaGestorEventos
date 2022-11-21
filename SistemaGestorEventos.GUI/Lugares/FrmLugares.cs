using SistemaGestorEventos.BE;
using SistemaGestorEventos.BLL;
using SistemaGestorEventos.SharedServices.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestorEventos.GUI.Lugares
{
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
            this.dgvPlaces.AutoGenerateColumns = false;
            

        }

        private void btnPlaceSearch_Click(object sender, EventArgs e)
        {
            var list = EventRoomBLL.Instance.Find(GetRoomId(), txtPlaceName.Text);

            dgvPlaces.DataSource = list;
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            MultiLang.SubscribeChangeLangEvent(Translate);
            dgvPlaces_SelectionChanged(null, null);
        }



        private void Translate()
        {

            this.SuspendLayout();

            WinformUtils.TraducirControl(this);
            this.dgvcBucket.HeaderText = MultiLang.TranslateOrDefault("places.tables.bucketSieze", "Tiempo");
            this.dgvcCapacity.HeaderText = MultiLang.TranslateOrDefault("places.tables.capacity", "Cant.");
            this.dgvcId.HeaderText = MultiLang.TranslateOrDefault("places.tables.id", "Id");
            this.dgvcName.HeaderText = MultiLang.TranslateOrDefault("places.tables.name", "Nombre") ;
            this.ResumeLayout();
            
        }

        private void FrmLugares_FormClosed(object sender, FormClosedEventArgs e)
        {
            MultiLang.UnscribeChangeLangEvent(Translate);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPlaceId.Text = null; ;
            txtPlaceName.Text = null;
        }

        private Int32? GetRoomId()
        {
            if (!string.IsNullOrEmpty(txtPlaceId.Text))
            {
                Int32 roomId;
                if (Int32.TryParse(txtPlaceId.Text,out roomId))
                {
                    return roomId;
                }
            }

            return null;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var room = FrmPlace.CreateNew();
            room.ShowDialog();
            
        }

        private void gbxFilter_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPlaces_SelectionChanged(object sender, EventArgs e)
        {
            this.btnEditPlace.Enabled = this.dgvPlaces.CurrentRow != null;
            this.btnHistory.Enabled = this.dgvPlaces.CurrentRow != null;

        }

        private void btnEditPlace_Click(object sender, EventArgs e)
        {
            EventRoom room = (EventRoom) this.dgvPlaces.CurrentRow.DataBoundItem;

            var editForm = FrmPlace.CreateEdit(room);
            editForm.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            EventRoom room = (EventRoom)this.dgvPlaces.CurrentRow.DataBoundItem;
            IList<EventRoom> history = EventRoomBLL.Instance.FindHistory((int)room.Id);

            var historyForm = FrmPlaceHistory.CreateForm(history);

            historyForm.ShowDialog();
        }

        private void btnDvv_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Regenerar DVV?", "DVV", MessageBoxButtons.YesNo);

            if (DialogResult.Yes.Equals(result))
            {
                List<string> errors = EventRoomBLL.Instance.RegenerateDVV();

                if (errors.Count > 0)
                {
                    WinformUtils.ShowErrorList(MultiLang.TranslateOrDefault("eventrooms.error.generatedvv.title", "No se pudo regenerar el DVV"), errors);
                } else
                {
                    MessageBox.Show(MultiLang.TranslateOrDefault("eventrooms.dvv.generatedok", "DVV generado con éxito"));
                }
            }
        }
    }
}
