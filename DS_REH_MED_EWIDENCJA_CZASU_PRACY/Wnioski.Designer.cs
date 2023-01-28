namespace Ewidencja_Czasu_Pracy
{
    partial class Wnioski
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wnioski));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_minim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_P = new System.Windows.Forms.CheckBox();
            this.checkBox_WS = new System.Windows.Forms.CheckBox();
            this.checkBox_PZ = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_GSTOP_M = new System.Windows.Forms.ComboBox();
            this.comboBox_GSTOP_G = new System.Windows.Forms.ComboBox();
            this.comboBox_GS_M = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_GS_G = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_PDF = new System.Windows.Forms.Button();
            this.btn_SEND = new System.Windows.Forms.Button();
            this.btn_drukuj = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 158);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(466, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_X.Location = new System.Drawing.Point(750, 8);
            this.btn_X.Name = "btn_X";
            this.btn_X.Size = new System.Drawing.Size(38, 43);
            this.btn_X.TabIndex = 11;
            this.btn_X.Text = "X";
            this.btn_X.UseVisualStyleBackColor = false;
            this.btn_X.Click += new System.EventHandler(this.btn_X_Click);
            // 
            // btn_minim
            // 
            this.btn_minim.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_minim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minim.Location = new System.Drawing.Point(706, 8);
            this.btn_minim.Name = "btn_minim";
            this.btn_minim.Size = new System.Drawing.Size(38, 43);
            this.btn_minim.TabIndex = 10;
            this.btn_minim.Text = "-";
            this.btn_minim.UseVisualStyleBackColor = false;
            this.btn_minim.Click += new System.EventHandler(this.btn_minim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ewidencja_Czasu_Pracy.Properties.Resources.Logo_INZ;
            this.pictureBox1.Location = new System.Drawing.Point(198, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "WNIOSKI";
            // 
            // checkBox_P
            // 
            this.checkBox_P.AutoSize = true;
            this.checkBox_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_P.Location = new System.Drawing.Point(19, 69);
            this.checkBox_P.Name = "checkBox_P";
            this.checkBox_P.Size = new System.Drawing.Size(238, 28);
            this.checkBox_P.TabIndex = 12;
            this.checkBox_P.Text = "WYJSCIE PRYWATNE";
            this.checkBox_P.UseVisualStyleBackColor = true;
            // 
            // checkBox_WS
            // 
            this.checkBox_WS.AutoSize = true;
            this.checkBox_WS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_WS.Location = new System.Drawing.Point(290, 69);
            this.checkBox_WS.Name = "checkBox_WS";
            this.checkBox_WS.Size = new System.Drawing.Size(236, 28);
            this.checkBox_WS.TabIndex = 13;
            this.checkBox_WS.Text = "WYJSCIE SLUZBOWE";
            this.checkBox_WS.UseVisualStyleBackColor = true;
            // 
            // checkBox_PZ
            // 
            this.checkBox_PZ.AutoSize = true;
            this.checkBox_PZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_PZ.Location = new System.Drawing.Point(572, 68);
            this.checkBox_PZ.Name = "checkBox_PZ";
            this.checkBox_PZ.Size = new System.Drawing.Size(185, 28);
            this.checkBox_PZ.TabIndex = 14;
            this.checkBox_PZ.Text = "PRACA ZDALNA";
            this.checkBox_PZ.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(354, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = "DATA";
            // 
            // comboBox_GSTOP_M
            // 
            this.comboBox_GSTOP_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_GSTOP_M.FormattingEnabled = true;
            this.comboBox_GSTOP_M.Location = new System.Drawing.Point(539, 254);
            this.comboBox_GSTOP_M.Name = "comboBox_GSTOP_M";
            this.comboBox_GSTOP_M.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GSTOP_M.TabIndex = 25;
            // 
            // comboBox_GSTOP_G
            // 
            this.comboBox_GSTOP_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_GSTOP_G.FormattingEnabled = true;
            this.comboBox_GSTOP_G.Location = new System.Drawing.Point(436, 254);
            this.comboBox_GSTOP_G.Name = "comboBox_GSTOP_G";
            this.comboBox_GSTOP_G.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GSTOP_G.TabIndex = 24;
            this.comboBox_GSTOP_G.SelectedIndexChanged += new System.EventHandler(this.comboBox_GSTOP_G_SelectedIndexChanged);
            // 
            // comboBox_GS_M
            // 
            this.comboBox_GS_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_GS_M.FormattingEnabled = true;
            this.comboBox_GS_M.Location = new System.Drawing.Point(273, 254);
            this.comboBox_GS_M.Name = "comboBox_GS_M";
            this.comboBox_GS_M.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GS_M.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(413, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "GODZINA STOP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(132, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "GODZINA START";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_GS_G
            // 
            this.comboBox_GS_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_GS_G.FormattingEnabled = true;
            this.comboBox_GS_G.Location = new System.Drawing.Point(170, 254);
            this.comboBox_GS_G.Name = "comboBox_GS_G";
            this.comboBox_GS_G.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GS_G.TabIndex = 20;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 132);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // btn_PDF
            // 
            this.btn_PDF.BackColor = System.Drawing.Color.Gold;
            this.btn_PDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_PDF.Location = new System.Drawing.Point(360, 10);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(64, 43);
            this.btn_PDF.TabIndex = 27;
            this.btn_PDF.Text = "PDF";
            this.btn_PDF.UseVisualStyleBackColor = false;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // btn_SEND
            // 
            this.btn_SEND.BackColor = System.Drawing.Color.Gold;
            this.btn_SEND.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SEND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_SEND.Location = new System.Drawing.Point(430, 10);
            this.btn_SEND.Name = "btn_SEND";
            this.btn_SEND.Size = new System.Drawing.Size(64, 43);
            this.btn_SEND.TabIndex = 28;
            this.btn_SEND.Text = "WYSLIJ";
            this.btn_SEND.UseVisualStyleBackColor = false;
            this.btn_SEND.Click += new System.EventHandler(this.btn_SEND_Click);
            // 
            // btn_drukuj
            // 
            this.btn_drukuj.BackColor = System.Drawing.Color.Gold;
            this.btn_drukuj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_drukuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_drukuj.Location = new System.Drawing.Point(500, 10);
            this.btn_drukuj.Name = "btn_drukuj";
            this.btn_drukuj.Size = new System.Drawing.Size(76, 43);
            this.btn_drukuj.TabIndex = 29;
            this.btn_drukuj.Text = "DRUKUJ";
            this.btn_drukuj.UseVisualStyleBackColor = false;
            this.btn_drukuj.Click += new System.EventHandler(this.btn_drukuj_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Wnioski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_drukuj);
            this.Controls.Add(this.btn_SEND);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox_GSTOP_M);
            this.Controls.Add(this.comboBox_GSTOP_G);
            this.Controls.Add(this.comboBox_GS_M);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_GS_G);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_PZ);
            this.Controls.Add(this.checkBox_WS);
            this.Controls.Add(this.checkBox_P);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_minim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wnioski";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wnioski";
            this.Load += new System.EventHandler(this.Wnioski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_minim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_P;
        private System.Windows.Forms.CheckBox checkBox_WS;
        private System.Windows.Forms.CheckBox checkBox_PZ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_GSTOP_M;
        private System.Windows.Forms.ComboBox comboBox_GSTOP_G;
        private System.Windows.Forms.ComboBox comboBox_GS_M;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_GS_G;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Button btn_SEND;
        private System.Windows.Forms.Button btn_drukuj;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}