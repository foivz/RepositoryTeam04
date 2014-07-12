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
    public partial class frmDodajPartnera : Form
    {
        public frmDodajPartnera()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            poslovni_partner partner = new poslovni_partner();
            partner.naziv = txtNaziv.Text;
            partner.ziro_racun = txtZiroRacun.Text;
            partner.tel_broj = txtTelefonskiBroj.Text;
            partner.email = txtEmail.Text;

            baza.poslovni_partner.Add(partner);
            baza.SaveChanges();

            MessageBox.Show("Novi poslovni partner dodan!");
            this.Close();           
        }

        private void frmDodajPartnera_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPPartneri forma = new frmPPartneri();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void txtZiroRacun_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
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
