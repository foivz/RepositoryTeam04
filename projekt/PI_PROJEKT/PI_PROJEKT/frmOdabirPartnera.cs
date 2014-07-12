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
    public partial class frmOdabirPartnera : Form
    {
        public frmOdabirPartnera()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void frmOdabirPartnera_Load(object sender, EventArgs e)
        {
            List<poslovni_partner> lista = new List<poslovni_partner>();
            foreach (var red in baza.poslovni_partner)
            {
                lista.Add(red);
            }

            dgvPart.DataSource = lista;
            dgvPart.Columns[5].Visible = false;
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (dgvPart.SelectedCells.Count > 0)
            {
                string odabir = dgvPart.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);
                Podatci.ID_partner_dodavanje = id;

                string odabir1 = dgvPart.SelectedCells[1].Value.ToString();
                Podatci.Partner_naziv = odabir1;

                string odabir2 = dgvPart.SelectedCells[2].Value.ToString();
                Podatci.Partner_ziro_racun = odabir2;

                string odabir3 = dgvPart.SelectedCells[3].Value.ToString();
                Podatci.Partner_telefonski_broj = odabir3;

                string odabir4 = dgvPart.SelectedCells[4].Value.ToString();
                Podatci.Partner_email = odabir4;

                this.Close();

            }
        }
    }
}
