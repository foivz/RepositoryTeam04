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
    public partial class frmDodajIzdatnicu : Form
    {
        public frmDodajIzdatnicu()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void frmDodajIzdatnicu_Load(object sender, EventArgs e)
        {
            txtIDkorisnik.Text = Podatci.ID_korisnik.ToString();
            txtImeKorisnik.Text = Podatci.Ime.ToString();
            txtPrezimeKorisnik.Text = Podatci.Prezime.ToString();
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = (DataGridViewRow)dgvNoveStavke.Rows[0].Clone();
            red.Cells[0].Value = txtIdStavke.Text;
            red.Cells[1].Value = txtIzabranaStavka.Text;
            red.Cells[2].Value = txtKolicina.Text;
            dgvNoveStavke.Rows.Add(red);

            txtIdStavke.Clear();
            txtIzabranaStavka.Clear();
            txtKolicina.Clear();
        }

        private void btnOdabirStavke_Click(object sender, EventArgs e)
        {
            frmOdabirArtikla forma = new frmOdabirArtikla();
            forma.ShowDialog();
            txtIdStavke.Text = Podatci.ID_artikla.ToString();
            txtIzabranaStavka.Text = Podatci.Naziv_artikla;
        }

        private void btnUrediStavku_Click(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                dgvNoveStavke.SelectedCells[0].Value = txtIdStavke.Text;
                dgvNoveStavke.SelectedCells[1].Value = txtIzabranaStavka.Text;
                dgvNoveStavke.SelectedCells[2].Value = txtKolicina.Text;
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                dgvNoveStavke.Rows.RemoveAt(dgvNoveStavke.SelectedRows[0].Index);
            }
        }

        private void dgvNoveStavke_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
                if (dgvNoveStavke.SelectedCells[0].Value != null)
                {
                    {
                        txtIdStavke.Text = dgvNoveStavke.SelectedCells[0].Value.ToString();
                        txtIzabranaStavka.Text = dgvNoveStavke.SelectedCells[1].Value.ToString();
                        txtKolicina.Text = dgvNoveStavke.SelectedCells[2].Value.ToString();
                        btnObrisiStavku.Enabled = true;
                        btnUrediStavku.Enabled = true;
                    }
                }
        }

        private void btnDodajRačun_Click(object sender, EventArgs e)
        {
            izdatnica novaIzdatnica = new izdatnica();
            DateTime datum = new DateTime();
            datum = dtpDatum.Value;
            novaIzdatnica.datum = datum;
            novaIzdatnica.id_korisnik = Convert.ToInt32(txtIDkorisnik.Text);
            string imePrezkorisnika = txtImeKorisnik.Text + " " + txtPrezimeKorisnik.Text;
            novaIzdatnica.izdaje = imePrezkorisnika;
            baza.izdatnica.Add(novaIzdatnica);
            baza.SaveChanges();

            int id_izdatnice = 0;
            foreach (var red in baza.izdatnica)
            {
                id_izdatnice = red.id_izdatnica;
            }

            foreach (DataGridViewRow red in dgvNoveStavke.Rows)
            {
                stavke_izdatnice noveStavke = new stavke_izdatnice();
                noveStavke.id_artikli = Convert.ToInt32(red.Cells[0].Value);
                noveStavke.id_izdatnica = id_izdatnice;
                noveStavke.kolicina = Convert.ToInt32(red.Cells[2].Value);
                baza.stavke_izdatnice.Add(noveStavke);

                int id = Convert.ToInt32(red.Cells[0].Value);
                int kol = Convert.ToInt32(red.Cells[2].Value);

                if (red.Cells[0].Value != null)
                {
                    var artikl = baza.artikli.First(o => o.id_artikli == id);
                    artikl.kolicina = artikl.kolicina - kol;
                    baza.SaveChanges();
                }              
            }

           

            this.Close();
            MessageBox.Show("Dodana izdatnica!");

        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8  )
            {
                e.Handled = true;
            }
        }
    }
}
