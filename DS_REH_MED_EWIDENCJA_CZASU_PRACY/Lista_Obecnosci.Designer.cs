namespace Ewidencja_Czasu_Pracy
{
    partial class Lista_Obecnosci
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Obecnosci));
            this.btn_X = new System.Windows.Forms.Button();
            this.btn_minim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.Label();
            this.txtdzial = new System.Windows.Forms.Label();
            this.numberFormatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFormatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(357, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "LISTA OBECNOSCI";
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(708, 426);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 13;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // cboSheet
            // 
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(86, 454);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 21);
            this.cboSheet.TabIndex = 14;
            this.cboSheet.SelectedIndexChanged += new System.EventHandler(this.cboSheet_SelectedIndexChanged);
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(86, 428);
            this.textFilename.Name = "textFilename";
            this.textFilename.ReadOnly = true;
            this.textFilename.Size = new System.Drawing.Size(616, 20);
            this.textFilename.TabIndex = 15;
            // 
            // txtFilename
            // 
            this.txtFilename.AutoSize = true;
            this.txtFilename.Location = new System.Drawing.Point(16, 431);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(68, 13);
            this.txtFilename.TabIndex = 16;
            this.txtFilename.Text = "Nazwa pliku:";
            // 
            // txtdzial
            // 
            this.txtdzial.AutoSize = true;
            this.txtdzial.Location = new System.Drawing.Point(48, 458);
            this.txtdzial.Name = "txtdzial";
            this.txtdzial.Size = new System.Drawing.Size(35, 13);
            this.txtdzial.TabIndex = 17;
            this.txtdzial.Text = "Dział:";
            // 
            // numberFormatBindingSource
            // 
            this.numberFormatBindingSource.DataSource = typeof(ExcelNumberFormat.NumberFormat);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 354);
            this.dataGridView1.TabIndex = 18;
            // 
            // Lista_Obecnosci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(796, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdzial);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.textFilename);
            this.Controls.Add(this.cboSheet);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_minim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Lista_Obecnosci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Obecnosci";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberFormatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_minim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.ComboBox cboSheet;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Label txtFilename;
        private System.Windows.Forms.Label txtdzial;
        private System.Windows.Forms.BindingSource numberFormatBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}