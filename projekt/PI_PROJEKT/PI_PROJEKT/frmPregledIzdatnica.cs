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
using System.IO;
using iTextSharp.text.pdf;

namespace PI_PROJEKT
{
    public partial class frmPregledIzdatnica : Form
    {
        public frmPregledIzdatnica()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void PregledIzdatnica_Load(object sender, EventArgs e)
        {
            foreach (var red in baza.izdatnica)
            {
                DataGridViewRow noviRed = (DataGridViewRow)dgvIzdatnice.Rows[0].Clone();
                noviRed.Cells[0].Value = red.id_izdatnica;
                noviRed.Cells[1].Value = red.datum;
                noviRed.Cells[2].Value = red.izdaje;
                dgvIzdatnice.Rows.Add(noviRed);
            }
        }

        private void dgvIzdatnice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvIzdatnice.SelectedCells.Count > 0 && dgvIzdatnice.SelectedCells[0].Value != null)
            {
                dgvStavkeIzdatnice.Rows.Clear();
                string odabir = dgvIzdatnice.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);

                foreach (var red in baza.stavke_izdatnice)
                {
                    if (id == red.id_izdatnica)
                    {
                        DataGridViewRow noviRed = (DataGridViewRow)dgvStavkeIzdatnice.Rows[0].Clone();
                        noviRed.Cells[0].Value = red.id_artikli;
                        foreach (var artikl in baza.artikli)
                        {
                            if (artikl.id_artikli == red.id_artikli)
                            {
                                noviRed.Cells[1].Value = artikl.naziv;
                            }

                        }
                        noviRed.Cells[2].Value = red.kolicina;
                        dgvStavkeIzdatnice.Rows.Add(noviRed);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Izdatnica-broj-" + dgvIzdatnice.SelectedCells[0].Value.ToString() + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("Izdatnica broj: " + dgvIzdatnice.SelectedCells[0].Value.ToString() + "\n");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("Datum izdavanja: " + dgvIzdatnice.SelectedCells[1].Value.ToString() + "\n");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("Izdao: " + dgvIzdatnice.SelectedCells[2].Value.ToString()+ "\n\n" );
            doc.Add(paragraph2);

            PdfPTable table = new PdfPTable(dgvStavkeIzdatnice.Columns.Count);

            for (int j = 0; j < dgvStavkeIzdatnice.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvStavkeIzdatnice.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;



            for (int i = 0; i < dgvStavkeIzdatnice.Rows.Count; i++)
            {
                for (int k = 0; k < dgvStavkeIzdatnice.Columns.Count; k++)
                {
                    if (dgvStavkeIzdatnice[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvStavkeIzdatnice[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            doc.Close();
            System.Diagnostics.Process.Start("Izdatnica-broj-" + dgvIzdatnice.SelectedCells[0].Value.ToString() + ".pdf");
        }
    }
}
