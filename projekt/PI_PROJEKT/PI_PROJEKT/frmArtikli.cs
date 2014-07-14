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
    public partial class frmArtikli : Form
    {
        public frmArtikli()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void Artikli_Load(object sender, EventArgs e)
        {
            if (Podatci.Status == 2) 
            {
                btnDodaj.Enabled = false;
                btnUrediArtikl.Enabled = false;
            }

            foreach (var red in baza.artikli)
            {
                DataGridViewRow redtest = (DataGridViewRow)dgvTest.Rows[0].Clone();
                redtest.Cells[0].Value = red.id_artikli;
                redtest.Cells[1].Value = red.naziv;
                redtest.Cells[2].Value = red.kolicina;

                foreach (var vrsta in baza.vrsta_artikla) 
                {
                    if (vrsta.id_vrsta_artikla == red.id_vrsta_artikla)
                    {
                        redtest.Cells[3].Value = vrsta.naziv;
                    }
                }
                
                redtest.Cells[4].Value = red.cijena;
                redtest.Cells[5].Value = red.optimalna;
                dgvTest.Rows.Add(redtest);
            }           
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajArtikl dodaj = new frmDodajArtikl();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }

        private void btnUrediArtikl_Click(object sender, EventArgs e)
        {
            if (dgvTest.SelectedCells.Count > 0 &&  dgvTest.SelectedCells[0].Value != null)
            {
                string odabir = dgvTest.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_promjena_artikla = id;
            }

            frmUrediArtikl dodaj = new frmUrediArtikl();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }
    }
}
