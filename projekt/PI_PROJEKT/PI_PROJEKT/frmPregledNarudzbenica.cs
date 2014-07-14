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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PI_PROJEKT
{
    public partial class frmPregledNarudzbenica : Form
    {
        public frmPregledNarudzbenica()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void PregledNarudzbenica_Load(object sender, EventArgs e)
        {
            foreach (var red in baza.narudzbenica)
            {
                DataGridViewRow noviRed = (DataGridViewRow)dgvNarudzbenice.Rows[0].Clone();
                noviRed.Cells[0].Value = red.id_narudzbenica;
                noviRed.Cells[1].Value = red.datum;
                noviRed.Cells[2].Value = red.izdaje;
                noviRed.Cells[3].Value = red.id_poslovni_partner;

                foreach (var poslovniP in baza.poslovni_partner) 
                {
                    if (red.id_poslovni_partner == poslovniP.id_poslovni_partner) 
                    {
                        noviRed.Cells[4].Value = poslovniP.naziv;
                    }
                }

                dgvNarudzbenice.Rows.Add(noviRed);
            }

        }

        private void dgvNarudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNarudzbenice.SelectedCells.Count > 0 && dgvNarudzbenice.SelectedCells[0].Value != null)
            {
                dgvStavkeNarudzbenice.Rows.Clear();
                string odabir = dgvNarudzbenice.SelectedCells[0].Value.ToString();
                int id = Convert.ToInt32(odabir);

                foreach (var red in baza.stavke_narudzbenice)
                {
                    if (id == red.id_narudzbenica)
                    {
                        DataGridViewRow noviRed = (DataGridViewRow)dgvStavkeNarudzbenice.Rows[0].Clone();
                        noviRed.Cells[0].Value = red.id_artikli;
                        foreach (var artikl in baza.artikli)
                        {
                            if (artikl.id_artikli == red.id_artikli)
                            {
                                noviRed.Cells[1].Value = artikl.naziv;
                            }

                        }
                        noviRed.Cells[2].Value = red.kolicina;
                        dgvStavkeNarudzbenice.Rows.Add(noviRed);

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Narudzbenica-broj-"+dgvNarudzbenice.SelectedCells[0].Value.ToString()+".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("Narudzbenica broj: " + dgvNarudzbenice.SelectedCells[0].Value.ToString() + "\n");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("Datum izdavanja: " + dgvNarudzbenice.SelectedCells[1].Value.ToString() + "\n");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("Izdao: " + dgvNarudzbenice.SelectedCells[2].Value.ToString() + "\n");
            doc.Add(paragraph2);
            Paragraph paragraph3 = new Paragraph("Sifra poslovnog partnera: " + dgvNarudzbenice.SelectedCells[3].Value.ToString() + "\n");
            doc.Add(paragraph3);
            Paragraph paragraph4 = new Paragraph("Naziv poslovnog partnera: " + dgvNarudzbenice.SelectedCells[4].Value.ToString() + "\n\n");
            doc.Add(paragraph4);


            PdfPTable table = new PdfPTable(dgvStavkeNarudzbenice.Columns.Count);

            for (int j = 0; j < dgvStavkeNarudzbenice.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgvStavkeNarudzbenice.Columns[j].HeaderText));
            }

            table.HeaderRows = 1;



            for (int i = 0; i < dgvStavkeNarudzbenice.Rows.Count; i++)
            {
                for (int k = 0; k < dgvStavkeNarudzbenice.Columns.Count; k++)
                {
                    if (dgvStavkeNarudzbenice[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dgvStavkeNarudzbenice[k, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);

            doc.Close();

            System.Diagnostics.Process.Start("Narudzbenica-broj-"+dgvNarudzbenice.SelectedCells[0].Value.ToString()+".pdf");
        }
    }
}
