using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_POCETAK.Model;

namespace PI_POCETAK
{
    public partial class DodajZaposlenika : Form
    {
        public DodajZaposlenika()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            korisnici noviKorisnik = new korisnici();
            noviKorisnik.ime = txtIme.Text;
            noviKorisnik.prezime = txtPrezime.Text;
            noviKorisnik.korisnicko_ime = txtKorisnickoIme.Text;
            noviKorisnik.lozinka = txtLozinka.Text;
            noviKorisnik.ziro_racun = txtZiroRacun.Text;
            noviKorisnik.tel_broj = txtTelefonskiBroj.Text;

            if (cbAdmin.Checked)
            {
                noviKorisnik.status = 1;
            }
            else 
            {
                noviKorisnik.status = 2;
            }

            baza.korisnici.Add(noviKorisnik);
            baza.SaveChanges();
            MessageBox.Show("Novi zaposlenik dodan!");
            this.Close();
            
        }
    }
}
