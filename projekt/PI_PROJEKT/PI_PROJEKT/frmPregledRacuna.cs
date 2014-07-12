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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PI_PROJEKT
{
    public partial class frmPregledRacuna : Form
    {
        public frmPregledRacuna()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void PregledRacuna_Load(object sender, EventArgs e)
        {
            
            foreach (var red in baza.racun)
            {
                DataGridViewRow noviRed = (DataGridViewRow)dgvRacuni.Rows[0].Clone();
                noviRed.Cells[0].Value = red.id_racun;
                noviRed.Cells[1].Value = red.datum;
                noviRed.Cells[2].Value = red.izdaje;
                noviRed.Cells[3].Value = red.imePrezimeKupca;
                noviRed.Cells[4].Value = red.adresaKupca;
                noviRed.Cells[5].Value = red.oibKupca;
                dgvRacuni.Rows.Add(noviRed);
            }

            



        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRacuni.SelectedCells.Count > 0 && dgvRacuni.SelectedCells[0].Value != null)
            {
                dgvPopisStavki.Rows.Clear();

                string odabir = dgvRacuni.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);

                foreach (var red in baza.stavke_racuna)
                {
                    if (id == red.id_racun)
                    {
                        DataGridViewRow noviRed = (DataGridViewRow)dgvPopisStavki.Rows[0].Clone();
                        noviRed.Cells[0].Value = red.id_artikli;
                        foreach (var artikl in baza.artikli)
                        {
                            if (artikl.id_artikli == red.id_artikli)
                            {
                                noviRed.Cells[1].Value = artikl.naziv;
                            }

                        }
                        noviRed.Cells[2].Value = red.kolicina;
                        noviRed.Cells[3].Value = red.popust;
                        noviRed.Cells[4].Value = red.id_racun;
                        dgvPopisStavki.Rows.Add(noviRed);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Račun-broj-" + dgvRacuni.SelectedCells[0].Value.ToString() + ".pdf", FileMode.Create));
            doc.Open();

            PdfPTable table = new PdfPTable(dgvPopisStavki.Columns.Count);

            for (int j = 0; j < dgvPopisStavki.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvPopisStavki.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;



            for (int i = 0; i < dgvPopisStavki.Rows.Count; i++)
            {
                for (int k = 0; k < dgvPopisStavki.Columns.Count; k++)
                {
                    if (dgvPopisStavki[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvPopisStavki[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            doc.Close(); 
        }
    }
}
