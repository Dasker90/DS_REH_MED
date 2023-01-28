using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;

namespace Ewidencja_Czasu_Pracy
{
    public partial class Lista_Obecnosci : Form
    {
        DataTableCollection tableCollection; // w pliku excela szukanie tabel.
        public Lista_Obecnosci()
        {
            InitializeComponent();
        }
        //  Co wybrać z excela --------------------------------------------------------
        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // po wybraniu pliku excel wybieramy komorke i wers arkusza - arkusz.
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            dataGridView1.DataSource = dt;
        }
        // Przycisk Browse --------------------------------------
        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() {Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx",ValidateNames=true})
            {
                if(openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    txtFilename.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName,FileMode.Open,FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=>new ExcelDataTableConfiguration() { UseHeaderRow = true}
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            // Pętla do szukania wartości i tabel w excelu.
                            foreach(DataTable table in tableCollection)
                            {
                                cboSheet.Items.Add(table.TableName);
                            }
                        }
                    }
                }
            }
        }
        // Przycisk minimalizacji app
        private void btn_minim_Click(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.WindowsDefaultLocation;
            btn_X.Visible = true;
        }
        // Przycisk Wyjście z programu
        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

    }
}
