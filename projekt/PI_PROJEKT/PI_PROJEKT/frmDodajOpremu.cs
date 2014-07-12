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
    public partial class frmDodajOpremu : Form
    {
        public frmDodajOpremu()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            oprema novaOprema = new oprema();
            novaOprema.naziv = txtNazivOpreme.Text;
            novaOprema.opis = txtOpisOpreme.Text;

            baza.oprema.Add(novaOprema);
            baza.SaveChanges();
            MessageBox.Show("Nova oprema dodana!");

            this.Close();
        }

        private void frmDodajOpremu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOprema forma = new frmOprema();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }


    }
}
