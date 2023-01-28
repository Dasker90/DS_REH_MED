using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ewidencja_Czasu_Pracy
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            btn_login.BackColor = Color.White;
            lbl_complete.Visible = false;
            btn_login.Enabled = true;
        }
        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10); //Used to simulate lenght of operation.
                }
            });
        }

        private async void btn_login_Click(object sender, EventArgs e)
        {
            lbl_complete.Visible = true;
            btn_login.Enabled = false;
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
                lbl_complete.Text = "Working...";
            }
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lbl_complete.Text = String.Format("Ładuje...{0}%", report.PercentComplete);
                progressBar_MW.Value = report.PercentComplete;
                progressBar_MW.Update();
            };
            await ProcessData(list, progress);
            lbl_complete.Text = "Done !";
            // warunki dla przycisku 
            if (progressBar_MW.Value == 1)
            {
                lbl_complete.BackColor = Color.Aqua;
                btn_login.Enabled = false;
            }
            if (progressBar_MW.Value == 100)
            {
                lbl_complete.BackColor = Color.YellowGreen;
                MessageBox.Show("Dostęp uznany ! ","Ewidencja Czasu pracy v.0.1");
                Window_1 W1 = new Window_1();
                W1.Show();
                this.Hide();
            }
        }
    }
}
