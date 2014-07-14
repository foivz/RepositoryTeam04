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
    public partial class frmPrijava : Form
    {        
        public frmPrijava()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "")
            {
                MessageBox.Show("Niste unjeli korisničko ime!");
                txtKorisnickoIme.Focus();
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Niste unjeli lozinku!");
                txtLozinka.Focus();
            }

            string korisnisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            foreach (var item in baza.korisnici)
            {
                if (item.korisnicko_ime.Equals(korisnisnickoIme))
                {
                    if (item.lozinka.Equals(lozinka))
                    {
                        Podatci.ID_korisnik = item.id_korisnik;
                        Podatci.Status = Convert.ToInt32(item.status);
                        Podatci.Ime = item.ime;
                        Podatci.Prezime = item.prezime;
                       
                        frmTiskaraNET forma = new frmTiskaraNET();
                        forma.Show();
                        this.Hide();
                        break;

                    }
                    else
                    {
                        MessageBox.Show("Unesli ste krivi mail ili krivu lozinku!");
                    }
                }

            }
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {
        }
    }
}
