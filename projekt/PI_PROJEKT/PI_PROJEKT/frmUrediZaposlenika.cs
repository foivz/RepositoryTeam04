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
    public partial class frmUrediZaposlenika : Form
    {
        public frmUrediZaposlenika()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();
        int id = Podatci.ID_zaposlenika;

        private void frmUrediZaposlenika_Load(object sender, EventArgs e)
        {
            foreach (var red in baza.korisnici)
            {
                if (red.id_korisnik == id)
                {
                    txtIme.Text = red.ime;
                    txtPrezime.Text = red.prezime;
                    txtKorisnickoIme.Text = red.korisnicko_ime;
                    txtLozinka.Text = red.lozinka;
                    txtZiroRacun.Text = red.ziro_racun;
                    txtTelefonskiBroj.Text = red.tel_broj;

                    if (red.status == 1)
                    {
                        cbAdmin.Checked = true;
                    }
                    else 
                    {
                        cbAdmin.Checked = false;
                    }
                }
            }
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            var zaposlenik = baza.korisnici.First(o => o.id_korisnik == id);
            zaposlenik.ime = txtIme.Text;
            zaposlenik.prezime = txtPrezime.Text;
            zaposlenik.korisnicko_ime = txtKorisnickoIme.Text;
            zaposlenik.lozinka = txtLozinka.Text;
            zaposlenik.ziro_racun = txtZiroRacun.Text;
            zaposlenik.tel_broj = txtTelefonskiBroj.Text;

            if (cbAdmin.Checked)
            {
                zaposlenik.status = 1;
            }
            else
            {
                zaposlenik.status = 2;
            }

            baza.SaveChanges();
            this.Close();
        }

        private void frmUrediZaposlenika_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmZaposlenici forma = new frmZaposlenici();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void txtZiroRacun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 )
            {
                e.Handled = true;
            }
        }

        private void txtTelefonskiBroj_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 47)
            {
                e.Handled = true;
            }
        }
    }
}
