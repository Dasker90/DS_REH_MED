using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Ewidencja_Czasu_Pracy
{
    public partial class Window_1 : Form
    {
        // intiger czasu pracy stoper start ----------------------------------------
        System.Timers.Timer t;
        int h, m, s;

        // -------------------------------------------------------------------------
        public Window_1()
        {
            InitializeComponent();
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
        private void Window_1_Load(object sender, EventArgs e)
        {
            lbl_DTTime.Text = DateTime.Now.ToLongTimeString();
            lbl_DTTime2.Text = DateTime.Now.ToLongDateString();
            t = new System.Timers.Timer();
            t.Interval = 1000; // 1s.
            t.Elapsed += OnTimeEvent;
            btn_Koniec.Visible = false;
            btn_Przerwa.Visible = false;
        }
        //--------------------------------------------------------------------------
        // Data i Czas pod przyciskami
        private void timerDTTime_Tick(object sender, EventArgs e)
        {
            lbl_DTTime.Text = DateTime.Now.ToLongTimeString();
            timerDTTime.Start();
        }
        // Czas pracy stoper -------------------------------------------------------
       private void OnTimeEvent(object sender,System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                lbl_Work_Time.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
        //--------------------------------------------------------------------------

        //--------------------------------------------------------------------------
        // Przyciski ---------------------------------------------------------------
        private void btn_X_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wychodzisz z programu !", " EWIDENCJA CZASU PRACY ", MessageBoxButtons.YesNo);
            Application.Exit();
            this.Close();
        }

        // Minimalizacja apliakcji -------------------------------------------------
        private void btn_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btn_X.Visible = true;
        }
        // Start stoper ------------------------------------------------------------
        private void btn_start_Click(object sender, EventArgs e)
        {
            comboBox_GS_G.Enabled = false;
            comboBox_GS_M.Enabled = false;
            t.Start();
            btn_Koniec.Visible = true;
            btn_Przerwa.Visible = true;
            btn_start.Enabled = false;
        }
        // Przerwa ----------------------------------------------------------------
        private void btn_Przerwa_Click(object sender, EventArgs e)
        {
            comboBox_GS_G.Enabled = false;
            comboBox_GS_M.Enabled = false;
        }
        // Koniec pracy -----------------------------------------------------------
        private void btn_Koniec_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_Przerwa.Enabled = false;
            comboBox_GS_G.Enabled = false;
            comboBox_GS_M.Enabled = false;
            comboBox_GSTOP_G.Enabled=false;
            comboBox_GSTOP_M.Enabled=false;
            t.Stop();
            lbl_DTTime.Text = null;
            lbl_DTTime2.Text = null;
        }
        // - Przyciski Góra --------------------------------------------------------

        private void btn_ListObecn_Click(object sender, EventArgs e)
        {
            Lista_Obecnosci L1 = new Lista_Obecnosci();
            L1.Show();
        }

        private void comboBox_GS_G_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_GS_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_GSTOP_G_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_GSTOP_M_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_DTTime_Click(object sender, EventArgs e)
        {
            
        }
        private void btn_wnioski_Click(object sender, EventArgs e)
        {
            Wnioski W1 = new Wnioski();
            W1.Show();
        }

        private void btn_odpracow_Click(object sender, EventArgs e)
        {
            Odpracowania O1 = new Odpracowania();
            O1.Show();
        }
        //--------------------------------------------------------------------------
    }
}
