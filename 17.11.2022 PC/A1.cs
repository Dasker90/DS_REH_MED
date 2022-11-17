using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_REH_MED
{
    public partial class A1 : Form
    {
        public A1()
        {
            InitializeComponent();
            cpbar1.Value = 0;
            timer1.Start();
        }
        private void A1_Load(object sender, EventArgs e)
        {
            btn_A1.Visible = false;
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cpbar1.Value += 1;
            cpbar1.Text = cpbar1.Value.ToString() + "%";
            if (cpbar1.Value == 100)
            {
                timer1.Enabled = false;
                btn_A1.Visible = true;
                cpbar1.ProgressColor = Color.Gold;
            }
        }
        // Przycisk
        private void btn_A1_Click(object sender, EventArgs e)
        {
            A2 a2 = new A2();
            a2.Show();
            this.Hide();
        }


    }
}
