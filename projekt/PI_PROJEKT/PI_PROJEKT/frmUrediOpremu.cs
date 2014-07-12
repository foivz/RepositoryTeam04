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
    public partial class frmUrediOpremu : Form
    {
        public frmUrediOpremu()
        {
            InitializeComponent();
        }

        int id = Podatci.ID_oprema;

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void btnUrediOpremu_Click(object sender, EventArgs e)
        {
            var oprema = baza.oprema.First(o => o.id_oprema == id);
            oprema.naziv = txtNazivOpreme.Text;
            oprema.opis = txtOpisOpreme.Text;
            baza.SaveChanges();                  
            this.Close();
        }

        private void frmUrediOpremu_Load(object sender, EventArgs e)
        {
            foreach (var red in baza.oprema)
            {
                if (red.id_oprema == id)
                {
                    txtNazivOpreme.Text = red.naziv.ToString();
                    txtOpisOpreme.Text = red.opis.ToString();
                }
            }
        }

        private void frmUrediOpremu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmOprema forma = new frmOprema();
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }
    }
}
