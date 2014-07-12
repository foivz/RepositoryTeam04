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
    public partial class frmZaposlenici : Form
    {
        public frmZaposlenici()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            if (Podatci.Status == 2) 
            {
                btnDodaj.Enabled = false;
                btnUrediZaposlenika.Enabled = false;
            }


            foreach (var red in baza.korisnici)
            {
                DataGridViewRow redTablice = (DataGridViewRow)dgvZaposleniciPopis.Rows[0].Clone();
                redTablice.Cells[0].Value = red.id_korisnik;
                redTablice.Cells[1].Value = red.ime;
                redTablice.Cells[2].Value = red.prezime;
                redTablice.Cells[3].Value = red.lozinka;
                redTablice.Cells[4].Value = red.ziro_racun;
                redTablice.Cells[5].Value = red.tel_broj;

                if (red.status == 1)
                {
                    redTablice.Cells[6].Value = "Admin";
                }
                else 
                {
                    redTablice.Cells[6].Value = "Zaposlenik";
                }
                dgvZaposleniciPopis.Rows.Add(redTablice);
                
            }          
            
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajZaposlenika dodaj = new frmDodajZaposlenika();
            dodaj.MdiParent = this.MdiParent;
            dodaj.Show();
            this.Close();
        }

        private void btnUrediZaposlenika_Click(object sender, EventArgs e)
        {
            if (dgvZaposleniciPopis.SelectedCells.Count > 0 && dgvZaposleniciPopis.SelectedCells[0].Value != null)
            {
                string odabir = dgvZaposleniciPopis.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_zaposlenika = id;
            }

            frmUrediZaposlenika uredi = new frmUrediZaposlenika();
            uredi.MdiParent = this.MdiParent;
            uredi.Show();
            this.Close();
        }
    }
}
