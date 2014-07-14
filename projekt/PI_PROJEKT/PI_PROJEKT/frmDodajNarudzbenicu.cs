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
    public partial class frmDodajNarudzbenicu : Form
    {
        public frmDodajNarudzbenicu()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void bntOdaberiPartnera_Click(object sender, EventArgs e)
        {
            frmOdabirPartnera partner = new frmOdabirPartnera();
            partner.ShowDialog();
            txtIDPP.Text = Podatci.ID_partner_dodavanje.ToString();
            txtNaziv.Text = Podatci.Partner_naziv;
            txtZiroRacun.Text = Podatci.Partner_ziro_racun;
            txtEmail.Text = Podatci.Partner_email;
            txtTel.Text = Podatci.Partner_telefonski_broj;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOdabirArtikla forma = new frmOdabirArtikla();
            forma.ShowDialog();
            txtIdStavke.Text = Podatci.ID_artikla.ToString();
            txtNazivStavke.Text = Podatci.Naziv_artikla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow red = (DataGridViewRow)dgvNoveStavke.Rows[0].Clone();
            red.Cells[0].Value = txtIdStavke.Text;
            red.Cells[1].Value = txtNazivStavke.Text;
            red.Cells[2].Value = txtKolicina.Text;

            dgvNoveStavke.Rows.Add(red);

            txtIdStavke.Clear();
            txtNazivStavke.Clear();
            txtKolicina.Clear();
        }

        private void dgvNoveStavke_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                if (dgvNoveStavke.SelectedCells[0].Value != null)
                {
                    txtIdStavke.Text = dgvNoveStavke.SelectedCells[0].Value.ToString();
                    txtNazivStavke.Text = dgvNoveStavke.SelectedCells[1].Value.ToString();
                    txtKolicina.Text = dgvNoveStavke.SelectedCells[2].Value.ToString();                  
                    btnObrisiStavku.Enabled = true;
                    btnUrediStavku.Enabled = true;
                }
            }
        }

        private void btnUrediStavku_Click(object sender, EventArgs e)
        {
            if (dgvNoveStavke.SelectedRows.Count > 0)
            {
                dgvNoveStavke.SelectedCells[0].Value = txtIdStavke.Text;
                dgvNoveStavke.SelectedCells[1].Value = txtNazivStavke.Text;
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

        private void frmDodajNarudzbenicu_Load(object sender, EventArgs e)
        {
            txtIDkorisnik.Text = Podatci.ID_korisnik.ToString();
            txtImeKorisnik.Text = Podatci.Ime.ToString();
            txtPrezimeKorisnik.Text = Podatci.Prezime.ToString();

            string sve = Podatci.Nedostaje;

            if (sve != "" && Podatci.Klik == 1) 
            {
                Podatci.Klik = 0;
                string[] id_evi = sve.Split('|');
                foreach (string id in id_evi) 
                {
                    foreach (var artikl in baza.artikli) 
                    {
                        if (Convert.ToInt32(id) == Convert.ToInt32(artikl.id_artikli))
                        {
                            DataGridViewRow red = (DataGridViewRow)dgvNoveStavke.Rows[0].Clone();
                            red.Cells[0].Value = artikl.id_artikli;
                            red.Cells[1].Value = artikl.naziv;
                            red.Cells[2].Value = artikl.optimalna - artikl.kolicina + 1;

                            dgvNoveStavke.Rows.Add(red);
                        }
                    }                  
                }
             
            }
        }

        private void btnDodajNarudžbenicu_Click(object sender, EventArgs e)
        {
            narudzbenica dokument = new narudzbenica();
            DateTime datum = new DateTime();
            datum = dtpDatum.Value;
            dokument.datum = datum;
            dokument.id_korisnik = Convert.ToInt32(txtIDkorisnik.Text);
            dokument.id_poslovni_partner = Convert.ToInt32(txtIDPP.Text);
            string imePrezkorisnika = txtImeKorisnik.Text + " " + txtPrezimeKorisnik.Text;
            dokument.izdaje = imePrezkorisnika;
            baza.narudzbenica.Add(dokument);
            baza.SaveChanges();

            int id_narudzbenice = 0;
            foreach (var red in baza.narudzbenica) 
            {
                id_narudzbenice = red.id_narudzbenica;
            }

            foreach (DataGridViewRow red in dgvNoveStavke.Rows)
            {
                stavke_narudzbenice noveStavke = new stavke_narudzbenice();
                noveStavke.id_artikli = Convert.ToInt32(red.Cells[0].Value);
                noveStavke.id_narudzbenica = id_narudzbenice;
                noveStavke.kolicina = Convert.ToInt32(red.Cells[2].Value);
                baza.stavke_narudzbenice.Add(noveStavke);
                if (red.Cells[0].Value != null)
                {
                    baza.SaveChanges();
                }
            }

            if (cbSalji.Checked) 
            {
                Podatci.ID_narudzbenica = id_narudzbenice;
                frmMail forma = new frmMail();
                Podatci.IdPartnerMail = Convert.ToInt32(txtIDPP.Text);
                Podatci.DtmMail = dtpDatum.Value;
                Podatci.NazivPartnerMail = txtNaziv.Text;
                forma.MdiParent = this.MdiParent;
                forma.Show();  
            }

            this.Close();
            MessageBox.Show("Dodana narudžbenica!");
        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 )
            {
                e.Handled = true;
            }
        }
    }
}
