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
    public partial class FrmPlaceHistory : Form
    {

        private IList<EventRoom> versions;
        private int currentIndex = 0;

        private EventRoom current;

        private FrmPlaceHistory()
        {
            InitializeComponent();
        }

        public static FrmPlaceHistory CreateForm(IList<EventRoom> versions)
        {
            if (versions == null || versions.Count == 0)
            {    
                MessageBox.Show(MultiLang.TranslateOrDefault("placehistory.nohistory.error", "No hay registros anteriores"), MultiLang.TranslateOrDefault("placehistory.nohistory.error", "No hay registros anteriores"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            FrmPlaceHistory frm = new FrmPlaceHistory();

            frm.versions = versions;
            frm.btnNext.Enabled = false;
            frm.Change(versions[0]);
            
            return frm;

        }

        private void Change(EventRoom eventRoom)
        {
            this.current = eventRoom;

            txtId.Text = this.current.Id.ToString();
            txtAddress.Text = this.current.Address;
            txtCapacity.Text = this.current.Capacity.ToString();
            txtPrice.Text = this.current.Price.ToString();
            txtName.Text = this.current.Name;
            cbxActive.Checked = this.current.Active;
            txtBucketSize.Text = this.current.BucketSize.ToString();
            if (this.current.UpdatedBy != null)
            {
                txtUsername.Text = this.current.UpdatedBy.ToString();
                txtDate.Text = this.current.UpdatedAt.ToString("dd/MM/yyyy HH:mm:ss");
            } 
            else
            {
                txtUsername.Text = this.current.CreatedBy.ToString();
                txtDate.Text = this.current.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss");
            }

            cbxIntegrity.Checked = EventRoomBLL.Instance.CheckIntegrity(eventRoom);

        }

        private void FrmPlaceHistory_Load(object sender, EventArgs e)
        {
            MultiLang.SubscribeChangeLangEvent(Translate);
        }


        private void Translate()
        {
            WinformUtils.TraducirControl(this);
        }

        private void FrmPlaceHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            MultiLang.UnscribeChangeLangEvent(Translate);
        }

        private void cbxIntegrity_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = cbxIntegrity.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EventRoomBLL.Instance.Save(this.current, SessionHandler.GetInstance.User.Id);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentIndex++;
            this.btnBack.Enabled = this.versions.Count -1 > currentIndex;
            this.btnNext.Enabled = currentIndex > 0;
            Change(this.versions[currentIndex]);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex--;
            this.btnBack.Enabled = this.versions.Count - 1 > currentIndex;
            this.btnNext.Enabled = currentIndex > 0;
            Change(this.versions[currentIndex]);
        }
    }
}
