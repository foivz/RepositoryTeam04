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
    public partial class frmUrediArtikl : Form
    {
        public frmUrediArtikl()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        int id = Podatci.ID_promjena_artikla;

        private void frmUrediArtikl_Load(object sender, EventArgs e)
        {
            foreach (var red in baza.vrsta_artikla)
            {
                cbVrstaArtikla.Items.Add(red.naziv);
            }

            string naziv_vrste_artikla = "";
            foreach (var red in baza.artikli) 
            {
                if (id == red.id_artikli) 
                {
                    foreach (var red2 in baza.vrsta_artikla) 
                    {
                        if (red.id_vrsta_artikla == red2.id_vrsta_artikla) 
                        {
                            naziv_vrste_artikla = red2.naziv;
                        }
                    }
                }
            }

            foreach (var red in baza.artikli) 
            {
                if (red.id_artikli == id) 
                {
                    txtNaziv.Text = red.naziv;
                    txtKolicina.Text = red.kolicina.ToString();
                    txtCijena.Text = red.cijena.ToString();
                    cbVrstaArtikla.SelectedItem = naziv_vrste_artikla;
                }

            }
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            /*
             var oprema = baza.oprema.First(o => o.id_oprema == id);
            oprema.naziv = txtNazivOpreme.Text;
            oprema.opis = txtOpisOpreme.Text;
            baza.SaveChanges();                  
            this.Close();
             */
            var artikl = baza.artikli.First(o => o.id_artikli == id);
            artikl.naziv = txtNaziv.Text.ToString();
            artikl.kolicina=Convert.ToInt32(txtKolicina.Text);
            artikl.cijena=Convert.ToDecimal(txtCijena.Text);
            artikl.optimalna = Convert.ToInt32(txtOptimalna.Text);

            int id_vrste = 0;

            foreach(var vrsta in baza.vrsta_artikla)
            {
                if(vrsta.naziv == cbVrstaArtikla.SelectedItem)
                {
                    id_vrste = vrsta.id_vrsta_artikla;
                }
            }
            artikl.id_vrsta_artikla = id_vrste;
            baza.SaveChanges();
            this.Close();
        }

        private void frmUrediArtikl_FormClosed(object sender, FormClosedEventArgs e)
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
