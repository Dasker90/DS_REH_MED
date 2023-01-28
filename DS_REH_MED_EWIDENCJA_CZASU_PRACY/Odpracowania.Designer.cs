namespace Ewidencja_Czasu_Pracy
{
    partial class Odpracowania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Odpracowania));
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_minim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DTTime2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_X
            // 
            this.btn_X.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_X.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_X.Location = new System.Drawing.Point(745, 10);
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
            this.btn_minim.Location = new System.Drawing.Point(703, 10);
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
            this.pictureBox1.Location = new System.Drawing.Point(539, 10);
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "ODPRACOWANIA";
            // 
            // lbl_DTTime2
            // 
            this.lbl_DTTime2.Font = new System.Drawing.Font("Commodore 64 Angled", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DTTime2.Location = new System.Drawing.Point(7, 366);
            this.lbl_DTTime2.Name = "lbl_DTTime2";
            this.lbl_DTTime2.Size = new System.Drawing.Size(779, 39);
            this.lbl_DTTime2.TabIndex = 17;
            this.lbl_DTTime2.Text = "W TRAKCIE PROJEKTOWANIA";
            this.lbl_DTTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 294);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "";
            // 
            // Odpracowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lbl_DTTime2);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_minim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Odpracowania";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odpracowania";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_minim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DTTime2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}