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
    public partial class frmPregledPrimki : Form
    {
        public frmPregledPrimki()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void PregledPrimki_Load(object sender, EventArgs e)
        {
            
            foreach (var red in baza.primka)
            {
                DataGridViewRow noviRed = (DataGridViewRow)dgvPrimke.Rows[0].Clone();
                noviRed.Cells[0].Value = red.id_primka;
                noviRed.Cells[1].Value = red.datum;
                noviRed.Cells[2].Value = red.izdaje;
                dgvPrimke.Rows.Add(noviRed);
            }
        }

        private void dgvPrimke_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrimke.SelectedCells.Count > 0 && dgvPrimke.SelectedCells[0].Value != null)
            {
                dgvStavkePrimke.Rows.Clear();
                string odabir = dgvPrimke.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);

                foreach (var red in baza.stavke_primke)
                {
                    if (id == red.id_primka)
                    {
                        DataGridViewRow noviRed = (DataGridViewRow)dgvStavkePrimke.Rows[0].Clone();
                        noviRed.Cells[0].Value = red.id_artikli;
                        foreach (var artikl in baza.artikli)
                        {
                            if (artikl.id_artikli == red.id_artikli)
                            {
                                noviRed.Cells[1].Value = artikl.naziv;
                            }

                        }
                        noviRed.Cells[2].Value = red.kolicina;
                        dgvStavkePrimke.Rows.Add(noviRed);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Primka-broj-" + dgvPrimke.SelectedCells[0].Value.ToString() + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("Primka broj: " + dgvPrimke.SelectedCells[0].Value.ToString() + "\n");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("Datum izdavanja: " + dgvPrimke.SelectedCells[1].Value.ToString() + "\n");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("Izdao: " + dgvPrimke.SelectedCells[2].Value.ToString() + "\n\n");
            doc.Add(paragraph2);
            

            PdfPTable table = new PdfPTable(dgvStavkePrimke.Columns.Count);

            for (int j = 0; j < dgvStavkePrimke.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvStavkePrimke.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;



            for (int i = 0; i < dgvStavkePrimke.Rows.Count; i++)
            {
                for (int k = 0; k < dgvStavkePrimke.Columns.Count; k++)
                {
                    if (dgvStavkePrimke[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvStavkePrimke[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            doc.Close();

            System.Diagnostics.Process.Start("Primka-broj-" + dgvPrimke.SelectedCells[0].Value.ToString() + ".pdf");

        }
    }
}
