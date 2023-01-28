using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Drawing;
using Font = System.Drawing.Font;

namespace Ewidencja_Czasu_Pracy
{
    public partial class Wnioski : Form
    {
        public Wnioski()
        {
            InitializeComponent();
            // Checkboxy z typem wyjsc
            checkBox_P.Enabled = true;
            checkBox_WS.Enabled = true;
            checkBox_PZ.Enabled = true;
           
        }
        // Przyciski -------------------------------------------------------
        private void Wnioski_Load(object sender, EventArgs e)
        {
            // Godzina Start - -----------------------------------------------------
            comboBox_GS_G.Items.Add("Wybierz godzinę");
            comboBox_GS_G.Items.Add(0);
            comboBox_GS_G.Items.Add(1);
            comboBox_GS_G.Items.Add(2);
            comboBox_GS_G.Items.Add(3);
            comboBox_GS_G.Items.Add(4);
            comboBox_GS_G.Items.Add(5);
            comboBox_GS_G.Items.Add(6);
            comboBox_GS_G.Items.Add(7);
            comboBox_GS_G.Items.Add(8);
            comboBox_GS_G.Items.Add(9);
            comboBox_GS_G.Items.Add(10);
            comboBox_GS_G.Items.Add(11);
            comboBox_GS_G.Items.Add(12);
            comboBox_GS_G.Items.Add(13);
            comboBox_GS_G.Items.Add(14);
            comboBox_GS_G.Items.Add(15);
            comboBox_GS_G.Items.Add(16);
            comboBox_GS_G.Items.Add(17);
            comboBox_GS_G.Items.Add(18);
            comboBox_GS_G.Items.Add(19);
            comboBox_GS_G.Items.Add(20);
            comboBox_GS_G.Items.Add(21);
            comboBox_GS_G.Items.Add(22);
            comboBox_GS_G.Items.Add(23);
            comboBox_GS_G.Items.Add(24);
            // Godzina Start - Minuty ----------------------------------------------
            comboBox_GS_M.Items.Add("Wybierz minutę");
            comboBox_GS_M.Items.Add(00);
            comboBox_GS_M.Items.Add(01);
            comboBox_GS_M.Items.Add(02);
            comboBox_GS_M.Items.Add(03);
            comboBox_GS_M.Items.Add(04);
            comboBox_GS_M.Items.Add(05);
            comboBox_GS_M.Items.Add(06);
            comboBox_GS_M.Items.Add(07);
            comboBox_GS_M.Items.Add(08);
            comboBox_GS_M.Items.Add(09);
            comboBox_GS_M.Items.Add(10);
            comboBox_GS_M.Items.Add(11);
            comboBox_GS_M.Items.Add(12);
            comboBox_GS_M.Items.Add(13);
            comboBox_GS_M.Items.Add(14);
            comboBox_GS_M.Items.Add(15);
            comboBox_GS_M.Items.Add(16);
            comboBox_GS_M.Items.Add(17);
            comboBox_GS_M.Items.Add(18);
            comboBox_GS_M.Items.Add(19);
            comboBox_GS_M.Items.Add(20);
            comboBox_GS_M.Items.Add(21);
            comboBox_GS_M.Items.Add(22);
            comboBox_GS_M.Items.Add(23);
            comboBox_GS_M.Items.Add(24);
            comboBox_GS_M.Items.Add(25);
            comboBox_GS_M.Items.Add(26);
            comboBox_GS_M.Items.Add(27);
            comboBox_GS_M.Items.Add(28);
            comboBox_GS_M.Items.Add(29);
            comboBox_GS_M.Items.Add(30);
            comboBox_GS_M.Items.Add(31);
            comboBox_GS_M.Items.Add(32);
            comboBox_GS_M.Items.Add(33);
            comboBox_GS_M.Items.Add(34);
            comboBox_GS_M.Items.Add(35);
            comboBox_GS_M.Items.Add(36);
            comboBox_GS_M.Items.Add(37);
            comboBox_GS_M.Items.Add(38);
            comboBox_GS_M.Items.Add(39);
            comboBox_GS_M.Items.Add(40);
            comboBox_GS_M.Items.Add(41);
            comboBox_GS_M.Items.Add(42);
            comboBox_GS_M.Items.Add(43);
            comboBox_GS_M.Items.Add(44);
            comboBox_GS_M.Items.Add(45);
            comboBox_GS_M.Items.Add(46);
            comboBox_GS_M.Items.Add(47);
            comboBox_GS_M.Items.Add(48);
            comboBox_GS_M.Items.Add(49);
            comboBox_GS_M.Items.Add(50);
            comboBox_GS_M.Items.Add(51);
            comboBox_GS_M.Items.Add(52);
            comboBox_GS_M.Items.Add(53);
            comboBox_GS_M.Items.Add(54);
            comboBox_GS_M.Items.Add(55);
            comboBox_GS_M.Items.Add(56);
            comboBox_GS_M.Items.Add(57);
            comboBox_GS_M.Items.Add(58);
            comboBox_GS_M.Items.Add(59);
            // Godzina Stop --------------------------------------------------------
            comboBox_GSTOP_G.Items.Add(0);
            comboBox_GSTOP_G.Items.Add(1);
            comboBox_GSTOP_G.Items.Add(2);
            comboBox_GSTOP_G.Items.Add(3);
            comboBox_GSTOP_G.Items.Add(4);
            comboBox_GSTOP_G.Items.Add(5);
            comboBox_GSTOP_G.Items.Add(6);
            comboBox_GSTOP_G.Items.Add(7);
            comboBox_GSTOP_G.Items.Add(8);
            comboBox_GSTOP_G.Items.Add(9);
            comboBox_GSTOP_G.Items.Add(10);
            comboBox_GSTOP_G.Items.Add(11);
            comboBox_GSTOP_G.Items.Add(12);
            comboBox_GSTOP_G.Items.Add(13);
            comboBox_GSTOP_G.Items.Add(14);
            comboBox_GSTOP_G.Items.Add(15);
            comboBox_GSTOP_G.Items.Add(16);
            comboBox_GSTOP_G.Items.Add(17);
            comboBox_GSTOP_G.Items.Add(18);
            comboBox_GSTOP_G.Items.Add(19);
            comboBox_GSTOP_G.Items.Add(20);
            comboBox_GSTOP_G.Items.Add(21);
            comboBox_GSTOP_G.Items.Add(22);
            comboBox_GSTOP_G.Items.Add(23);
            comboBox_GSTOP_G.Items.Add(24);
            // Godzina Stop - Minuty -----------------------------------------------
            comboBox_GSTOP_M.Items.Add(00);
            comboBox_GSTOP_M.Items.Add(01);
            comboBox_GSTOP_M.Items.Add(02);
            comboBox_GSTOP_M.Items.Add(03);
            comboBox_GSTOP_M.Items.Add(04);
            comboBox_GSTOP_M.Items.Add(05);
            comboBox_GSTOP_M.Items.Add(06);
            comboBox_GSTOP_M.Items.Add(07);
            comboBox_GSTOP_M.Items.Add(08);
            comboBox_GSTOP_M.Items.Add(09);
            comboBox_GSTOP_M.Items.Add(10);
            comboBox_GSTOP_M.Items.Add(11);
            comboBox_GSTOP_M.Items.Add(12);
            comboBox_GSTOP_M.Items.Add(13);
            comboBox_GSTOP_M.Items.Add(14);
            comboBox_GSTOP_M.Items.Add(15);
            comboBox_GSTOP_M.Items.Add(16);
            comboBox_GSTOP_M.Items.Add(17);
            comboBox_GSTOP_M.Items.Add(18);
            comboBox_GSTOP_M.Items.Add(19);
            comboBox_GSTOP_M.Items.Add(20);
            comboBox_GSTOP_M.Items.Add(21);
            comboBox_GSTOP_M.Items.Add(22);
            comboBox_GSTOP_M.Items.Add(23);
            comboBox_GSTOP_M.Items.Add(24);
            comboBox_GSTOP_M.Items.Add(25);
            comboBox_GSTOP_M.Items.Add(26);
            comboBox_GSTOP_M.Items.Add(27);
            comboBox_GSTOP_M.Items.Add(28);
            comboBox_GSTOP_M.Items.Add(29);
            comboBox_GSTOP_M.Items.Add(30);
            comboBox_GSTOP_M.Items.Add(31);
            comboBox_GSTOP_M.Items.Add(32);
            comboBox_GSTOP_M.Items.Add(33);
            comboBox_GSTOP_M.Items.Add(34);
            comboBox_GSTOP_M.Items.Add(35);
            comboBox_GSTOP_M.Items.Add(36);
            comboBox_GSTOP_M.Items.Add(37);
            comboBox_GSTOP_M.Items.Add(38);
            comboBox_GSTOP_M.Items.Add(39);
            comboBox_GSTOP_M.Items.Add(40);
            comboBox_GSTOP_M.Items.Add(41);
            comboBox_GSTOP_M.Items.Add(42);
            comboBox_GSTOP_M.Items.Add(43);
            comboBox_GSTOP_M.Items.Add(44);
            comboBox_GSTOP_M.Items.Add(45);
            comboBox_GSTOP_M.Items.Add(46);
            comboBox_GSTOP_M.Items.Add(47);
            comboBox_GSTOP_M.Items.Add(48);
            comboBox_GSTOP_M.Items.Add(49);
            comboBox_GSTOP_M.Items.Add(50);
            comboBox_GSTOP_M.Items.Add(51);
            comboBox_GSTOP_M.Items.Add(52);
            comboBox_GSTOP_M.Items.Add(53);
            comboBox_GSTOP_M.Items.Add(54);
            comboBox_GSTOP_M.Items.Add(55);
            comboBox_GSTOP_M.Items.Add(56);
            comboBox_GSTOP_M.Items.Add(57);
            comboBox_GSTOP_M.Items.Add(58);
            comboBox_GSTOP_M.Items.Add(59);
        }
        // Przycisk minimalziacji apliakcji
        private void btn_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btn_X.Visible = true;
        }
        // Przycisk wyjscie z modulu
        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        // Przycisk PDF
        private void btn_PDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf",ValidateNames = true})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.AddAuthor("Wniosek");
                        // Data i czas utworzenia pdfu - wniosku
                        doc.Add(new iTextSharp.text.Paragraph(DateTime.Now.ToString("F")));
                        // Godzina wyjścia -----------------------------------------------------------------
                        doc.Add(new iTextSharp.text.Paragraph(label4.Text));
                        doc.Add(new iTextSharp.text.Paragraph(comboBox_GS_G.SelectedValue.ToString()));
                        doc.Add(new iTextSharp.text.Paragraph(comboBox_GS_M.SelectedValue.ToString()));
                        // Godzina powrotu -----------------------------------------------------------------
                        doc.Add(new iTextSharp.text.Paragraph(label3.Text));
                        doc.Add(new iTextSharp.text.Paragraph(comboBox_GSTOP_G.SelectedValue.ToString()));
                        doc.Add(new iTextSharp.text.Paragraph(comboBox_GSTOP_M.SelectedValue.ToString()));
                        // Opis wyjscia --------------------------------------------------------------------
                        doc.Add(new iTextSharp.text.Paragraph(richTextBox1.Text));
                        // Rodzaj wniosku
                        if(checkBox_P.Checked)
                        {
                            doc.Add(new iTextSharp.text.Paragraph(checkBox_P.Text));
                        }
                        if(checkBox_PZ.Checked)
                        {
                            doc.Add(new iTextSharp.text.Paragraph(checkBox_PZ.Text));
                        }
                        if(checkBox_WS.Checked)
                        {
                            doc.Add(new iTextSharp.text.Paragraph(checkBox_WS.Text));
                        }
                        else
                        {
                            MessageBox.Show("Błąd", "DS_REH_MED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            doc.AddAuthor("Student: Damian Skuras");
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Błąd", "DS_REH_MED", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
        // wysyłanie wniosku
        private void btn_SEND_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Wniosek został wysłany !", "DS_REH_MED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //------------------------------------------------------------------
        // Przycisk drukuj
        private void btn_drukuj_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        // Gdy Wybierzemy date
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkBox_P.Enabled = false;
            checkBox_WS.Enabled = false;
            checkBox_PZ.Enabled = false;
        }
        // Drukowanie
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Wniosek",new Font("Arial",12,FontStyle.Regular),Brushes.Black, new Point(10,10));
            e.Graphics.DrawString("Modul w trakcie tworzenia :)", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
            //e.Graphics.DrawString("Wniosek", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10),dateTimePicker1.Checked());
        }
        // Jeżeli wybieramy godzine i minuty zakonczenia czasu wniosku -----
        private void comboBox_GSTOP_G_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_GS_G.Enabled = false;
            comboBox_GS_M.Enabled = false;
        }
        //------------------------------------------------------------------

    }
}
