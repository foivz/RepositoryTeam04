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
    public partial class frmUrediPartnera : Form
    {
        public frmUrediPartnera()
        {
            InitializeComponent();
        }

        int id = Podatci.ID_partner;

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void frmUrediPartnera_Load(object sender, EventArgs e)
        {
            

            foreach (var red in baza.poslovni_partner)
            {
                if(red.id_poslovni_partner == id)
                {
                    txtNaziv.Text = red.naziv.ToString();
                    txtEmail.Text = red.email.ToString();
                    txtTelefonskiBroj.Text = red.tel_broj.ToString();
                    txtZiroRacun.Text = red.ziro_racun.ToString();
                }
            }
        }

        private void btnPromijeniPartnera_Click(object sender, EventArgs e)
        {
            var partner = baza.poslovni_partner.First(o => o.id_poslovni_partner == id);
            partner.naziv = txtNaziv.Text;
            partner.tel_broj = txtTelefonskiBroj.Text;
            partner.ziro_racun = txtZiroRacun.Text;
            partner.email = txtEmail.Text;
            baza.SaveChanges();
            this.Close();
        }

        private void frmUrediPartnera_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPPartneri forma = new frmPPartneri();
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
