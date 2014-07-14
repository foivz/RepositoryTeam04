using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_PROJEKT.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PI_PROJEKT
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }

        private tiskaraNETEntities baza = new tiskaraNETEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                Dodatak.Text = picPath;
            }
        }

        private void Posalji_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(Frombox.Text, Tobox.Text, Subbox.Text, Messagebox.Text);

            mail.Attachments.Add(new Attachment(Dodatak.Text));

            SmtpClient client = new SmtpClient(Smtpbox.Text);

            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(Userbox.Text, Passbox.Text);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Poruka poslana!", "Message", MessageBoxButtons.OK);
        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            Tobox.Text = Podatci.Partner_email;

            txtIDnaru.Text = Podatci.ID_narudzbenica.ToString();
            txtIzdao.Text = Podatci.Ime.ToString() +" "+ Podatci.Prezime.ToString();
            txtDatum.Text = Podatci.DtmMail.ToString();
            txtIdZap.Text = Podatci.ID_korisnik.ToString();

            foreach (var red in baza.stavke_narudzbenice)
            {
                if (Podatci.ID_narudzbenica == red.id_narudzbenica)
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

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Narudzbenica-slanje-broj-" + txtIDnaru.Text + ".pdf", FileMode.Create));
            doc.Open();

            Paragraph paragraph = new Paragraph("Narudzbenica broj: " +txtIDnaru.Text + "\n");
            doc.Add(paragraph);
            Paragraph paragraph1 = new Paragraph("Datum izdavanja: " + txtDatum.Text + "\n");
            doc.Add(paragraph1);
            Paragraph paragraph2 = new Paragraph("Izdao: " + txtIzdao.Text+ "\n");
            doc.Add(paragraph2);
            Paragraph paragraph3 = new Paragraph("Sifra poslovnog partnera: " + Podatci.IdPartnerMail.ToString() + "\n");
            doc.Add(paragraph3);
            Paragraph paragraph4 = new Paragraph("Naziv poslovnog partnera: " + Podatci.NazivPartnerMail  + "\n\n");
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

            Dodatak.Text = "Narudzbenica-slanje-broj-" + txtIDnaru.Text + ".pdf";

        }
    }
}
