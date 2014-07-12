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
    public partial class frmPPartneri : Form
    {
        public frmPPartneri()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void PPartneri_Load(object sender, EventArgs e)
        {
            if (Podatci.Status == 2) 
            {
                btnDodajPartnera.Enabled = false;
                btnUrediPPartnera.Enabled = false;
            }

            List<poslovni_partner> listaPartnera = new List<poslovni_partner>();
            foreach (var red in baza.poslovni_partner)
            {
                listaPartnera.Add(red);
            }

            dgvPartneri.DataSource = listaPartnera;
            dgvPartneri.Columns[5].Visible = false;
            dgvPartneri.ReadOnly = true;
            
        }

        private void btnDodajPartnera_Click(object sender, EventArgs e)
        {
            frmDodajPartnera dodaj = new frmDodajPartnera();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }

        private void btnUrediPPartnera_Click(object sender, EventArgs e)
        {


            if (dgvPartneri.SelectedCells.Count > 0)
            {
                string odabir = dgvPartneri.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_partner = id;
            }

            frmUrediPartnera dodaj = new frmUrediPartnera();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }
    }
}
