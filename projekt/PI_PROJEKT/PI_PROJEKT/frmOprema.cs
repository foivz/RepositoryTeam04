using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_PROJEKT.Model;

namespace PI_PROJEKT
{
    public partial class frmOprema : Form
    {
        public frmOprema()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void Oprema_Load(object sender, EventArgs e)
        {
            List<oprema> listaOpreme = new List<oprema>();
            foreach (var red in baza.oprema)
            {
                listaOpreme.Add(red);
            }

            dgvOprema.DataSource = listaOpreme;

            if (Podatci.Status == 1)
            {
                btnDodajOpremu.Enabled = true;
                btnUrediOpremu.Enabled = true;
            }
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            frmDodajOpremu dodaj = new frmDodajOpremu();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }

        private void btnUrediOpremu_Click(object sender, EventArgs e)
        {
            if (dgvOprema.SelectedCells.Count > 0)
            {
                string odabir = dgvOprema.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_oprema = id;
            }

            frmUrediOpremu uredi = new frmUrediOpremu();
            uredi.MdiParent = this.MdiParent;
            uredi.Show();
            this.Close();
        }
    }
}
