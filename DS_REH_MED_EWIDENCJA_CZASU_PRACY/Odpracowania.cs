using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ewidencja_Czasu_Pracy
{
    public partial class Odpracowania : Form
    {
        public Odpracowania()
        {
            InitializeComponent();
        }

        private void btn_minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btn_X.Visible = true;
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
