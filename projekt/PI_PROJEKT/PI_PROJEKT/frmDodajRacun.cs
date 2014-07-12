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
    public partial class frmDodajRacun : Form
    {
        public frmDodajRacun()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void frmDodajRacun_Load(object sender, EventArgs e)
        {
            txtIDkorisnik.Text = Podatci.ID_korisnik.ToString();
            txtImeKorisnik.Text = Podatci.Ime.ToString();
            txtPrezimeKorisnik.Text = Podatci.Prezime.ToString();
        }

        private void zbrojStavki() {
            decimal ukupno = 0;
            foreach (DataGridViewRow red in dgvNoveStavke.Rows)
            {
                if (red.Cells[0] != null)
                {
                    decimal cijena = Convert.ToDecimal(red.Cells[2].Value);
                    decimal kolicina = Convert.ToDecimal(red.Cells[3].Value);
                    decimal popust = 1 - (Convert.ToDecimal(red.Cells[4].Value) / 100);
                    ukupno += cijena * kolicina * popust;
                }
            }
            txtUkupno.Text = ukupno.ToString();
        }

        private void btnDodajRačun_Click(object sender, EventArgs e)
        {          
            racun noviRacun = new racun();
            DateTime datum = new DateTime();
            datum = dtpDatum.Value;
            noviRacun.datum = datum;
            noviRacun.id_korisnik = Convert.ToInt32(txtIDkorisnik.Text);
            string imePrezkorisnika = txtImeKorisnik.Text + " " + txtPrezimeKorisnik.Text;
            noviRacun.izdaje = imePrezkorisnika;
            noviRacun.imePrezimeKupca = txtImePrezKupac.Text;
            noviRacun.adresaKupca = txtAdresaKupac.Text;
            noviRacun.oibKupca = txtOIBKupac.Text;
            noviRacun.iznos = Convert.ToDecimal(txtUkupno.Text);
            baza.racun.Add(noviRacun);
            baza.SaveChanges();
            int id_racuna = 0;

            foreach (var red in baza.racun) {               
                    id_racuna = red.id_racun;       
            }

            foreach (DataGridViewRow red in dgvNoveStavke.Rows)
            {
                stavke_racuna noveStavke = new stavke_racuna();
                noveStavke.id_artikli = Convert.ToInt32(red.Cells[0].Value);
                noveStavke.id_racun = id_racuna;
                noveStavke.kolicina = Convert.ToInt32(red.Cells[3].Value);
                noveStavke.popust = Convert.ToInt32(red.Cells[4].Value);

                baza.stavke_racuna.Add(noveStavke);
                if (red.Cells[0].Value != null)
                {
                    baza.SaveChanges();
                }
            }

            this.Close();
            MessageBox.Show("Dodan račun!");
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {           
            DataGridViewRow red = (DataGridViewRow)dgvNoveStavke.Rows[0].Clone();
            red.Cells[0].Value = txtIdStavke.Text;
            red.Cells[1].Value = txtIzabranaStavka.Text;
            red.Cells[2].Value = txtCijena.Text;
            red.Cells[3].Value = txtKolicina.Text;
            red.Cells[4].Value = txtPopust.Text;
            
            dgvNoveStavke.Rows.Add(red);
            zbrojStavki();

            txtIdStavke.Clear();
            txtKolicina.Clear();
            txtPopust.Clear();
            txtIzabranaStavka.Clear();

        }

        private void btnOdabirStavke_Click(object sender, EventArgs e)
        {
            frmOdabirArtikla forma = new frmOdabirArtikla();
            forma.ShowDialog();
            txtIdStavke.Text = Podatci.ID_artikla.ToString();
            txtIzabranaStavka.Text = Podatci.Naziv_artikla;
            txtCijena.Text = Podatci.Cijena.ToString();
        }

        private void btnUrediStavku_Click(object sender, EventArgs e)
        {        
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                if (dgvNoveStavke.SelectedCells[0].Value != null)
                {
                    dgvNoveStavke.SelectedCells[0].Value = txtIdStavke.Text;
                    dgvNoveStavke.SelectedCells[1].Value = txtIzabranaStavka.Text;
                    dgvNoveStavke.SelectedCells[2].Value = txtCijena.Text;
                    dgvNoveStavke.SelectedCells[3].Value = txtKolicina.Text;
                    dgvNoveStavke.SelectedCells[4].Value = txtPopust.Text;
                }
            }
            zbrojStavki();
        }

        private void dgvNoveStavke_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                if (dgvNoveStavke.SelectedCells[0].Value != null)
                {
                    txtIdStavke.Text = dgvNoveStavke.SelectedCells[0].Value.ToString();
                    txtIzabranaStavka.Text = dgvNoveStavke.SelectedCells[1].Value.ToString();
                    txtKolicina.Text = dgvNoveStavke.SelectedCells[3].Value.ToString();
                    txtPopust.Text = dgvNoveStavke.SelectedCells[4].Value.ToString();
                    btnObrisiStavku.Enabled = true;
                    btnUrediStavku.Enabled = true;
                }
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0) 
            {
                dgvNoveStavke.Rows.RemoveAt(dgvNoveStavke.SelectedRows[0].Index);
            }
            zbrojStavki();
        }

        private void txtOIBKupac_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }

        private void txtPopust_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPopust_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

    }
}
