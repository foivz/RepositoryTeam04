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
    public partial class frmDodajArtikl : Form
    {
        public frmDodajArtikl()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void DodajArtikl_Load(object sender, EventArgs e)
        {
            

            foreach (var red in baza.vrsta_artikla) 
            {
                cbVrstaArtikla.Items.Add(red.naziv);
            }
            
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            artikli artikl = new artikli();
            artikl.naziv = txtNaziv.Text;
            artikl.kolicina = Convert.ToInt32(txtKolicina.Text);
            artikl.cijena = Convert.ToDecimal(txtCijena.Text);
            artikl.optimalna = Convert.ToInt32(txtOptimalna.Text);

            string izbor = cbVrstaArtikla.SelectedItem.ToString();

            foreach (var red in baza.vrsta_artikla) 
            {
                if (red.naziv == izbor) 
                {
                    artikl.id_vrsta_artikla = red.id_vrsta_artikla;
                }
            }

           

            baza.artikli.Add(artikl);
            baza.SaveChanges();

            MessageBox.Show("Novi artikl dodan!");
            this.Close();
        }

        private void frmDodajArtikl_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmArtikli forma = new frmArtikli();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void txtKolicina_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 )
            {
                e.Handled = true;
            }
        }

        private void txtCijena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && txtCijena.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void txtOptimalna_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }
    }
}
