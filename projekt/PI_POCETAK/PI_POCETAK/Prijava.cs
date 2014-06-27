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
    public partial class Prijava : Form
    {
        public Prijava()
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
                        TiskaraNET forma = new TiskaraNET();
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
    }
}
