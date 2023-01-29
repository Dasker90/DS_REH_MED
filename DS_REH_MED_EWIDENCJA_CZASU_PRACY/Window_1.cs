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
