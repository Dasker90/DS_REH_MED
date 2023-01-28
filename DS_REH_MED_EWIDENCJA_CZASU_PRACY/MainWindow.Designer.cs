namespace Ewidencja_Czasu_Pracy
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar_MW = new System.Windows.Forms.ProgressBar();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_complete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "EWIDENCJA CZASU PRACY";
            // 
            // progressBar_MW
            // 
            this.progressBar_MW.BackColor = System.Drawing.Color.Yellow;
            this.progressBar_MW.ForeColor = System.Drawing.Color.IndianRed;
            this.progressBar_MW.Location = new System.Drawing.Point(20, 69);
            this.progressBar_MW.Name = "progressBar_MW";
            this.progressBar_MW.Size = new System.Drawing.Size(502, 29);
            this.progressBar_MW.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Linen;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_login.Location = new System.Drawing.Point(180, 116);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(169, 62);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ZALOGUJ";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_complete
            // 
            this.lbl_complete.AutoSize = true;
            this.lbl_complete.BackColor = System.Drawing.Color.Transparent;
            this.lbl_complete.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_complete.Location = new System.Drawing.Point(241, 73);
            this.lbl_complete.Name = "lbl_complete";
            this.lbl_complete.Size = new System.Drawing.Size(27, 20);
            this.lbl_complete.TabIndex = 3;
            this.lbl_complete.Text = "0%";
            this.lbl_complete.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ewidencja_Czasu_Pracy.Properties.Resources.Logo_INZ;
            this.pictureBox1.Location = new System.Drawing.Point(377, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(534, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_complete);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.progressBar_MW);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ewidencja Czasu Pracy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_MW;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_complete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

