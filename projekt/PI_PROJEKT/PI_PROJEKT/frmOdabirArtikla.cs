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
    public partial class frmOdabirArtikla : Form
    {
        public frmOdabirArtikla()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void frmOdabirArtikla_Load(object sender, EventArgs e)
        {
            List<artikli> listaArtikala = new List<artikli>();
            foreach (var red in baza.artikli)
            {
                listaArtikala.Add(red);
            }

            dgvArtikli.DataSource = listaArtikala;
            
            dgvArtikli.Columns[3].Visible = false;
            dgvArtikli.Columns[5].Visible = false;
            dgvArtikli.Columns[6].Visible = false;
            dgvArtikli.Columns[7].Visible = false;
            dgvArtikli.Columns[8].Visible = false;
            dgvArtikli.Columns[9].Visible = false;
        }

        private void btnUbaciStavku_Click(object sender, EventArgs e)
        {
            if (dgvArtikli.SelectedCells.Count > 0)
            {
                string odabir = dgvArtikli.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_artikla = id;

                string odabirNaziv = dgvArtikli.SelectedCells[1].Value.ToString();
                Podatci.Naziv_artikla = odabirNaziv;

                decimal odabirCijena = Convert.ToDecimal(dgvArtikli.SelectedCells[4].Value.ToString());
                Podatci.Cijena = odabirCijena;

                this.Close();

            }
        }
    }
}
