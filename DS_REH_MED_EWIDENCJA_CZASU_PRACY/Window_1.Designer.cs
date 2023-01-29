namespace Ewidencja_Czasu_Pracy
{
    
           
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(545, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "GODZINA STOP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_DTTime2
            // 
            this.lbl_DTTime2.Font = new System.Drawing.Font("Commodore 64 Angled", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DTTime2.Location = new System.Drawing.Point(11, 206);
            this.lbl_DTTime2.Name = "lbl_DTTime2";
            this.lbl_DTTime2.Size = new System.Drawing.Size(779, 39);
            this.lbl_DTTime2.TabIndex = 16;
            this.lbl_DTTime2.Text = "0000 : 00 : 00";
            this.lbl_DTTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDTTime
            // 
            this.timerDTTime.Enabled = true;
            this.timerDTTime.Tick += new System.EventHandler(this.timerDTTime_Tick);
            // 
            // comboBox_GS_M
            // 
            this.comboBox_GS_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_GS_M.FormattingEnabled = true;
            this.comboBox_GS_M.Location = new System.Drawing.Point(148, 309);
            this.comboBox_GS_M.Name = "comboBox_GS_M";
            this.comboBox_GS_M.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GS_M.TabIndex = 17;
            this.comboBox_GS_M.SelectedIndexChanged += new System.EventHandler(this.comboBox_GS_M_SelectedIndexChanged);
            // 
            // comboBox_GSTOP_M
            // 
            this.comboBox_GSTOP_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_GSTOP_M.FormattingEnabled = true;
            this.comboBox_GSTOP_M.Location = new System.Drawing.Point(671, 309);
            this.comboBox_GSTOP_M.Name = "comboBox_GSTOP_M";
            this.comboBox_GSTOP_M.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GSTOP_M.TabIndex = 19;
            this.comboBox_GSTOP_M.SelectedIndexChanged += new System.EventHandler(this.comboBox_GSTOP_M_SelectedIndexChanged);
            // 
            // comboBox_GSTOP_G
            // 
            this.comboBox_GSTOP_G.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox_GSTOP_G.FormattingEnabled = true;
            this.comboBox_GSTOP_G.Location = new System.Drawing.Point(568, 309);
            this.comboBox_GSTOP_G.Name = "comboBox_GSTOP_G";
            this.comboBox_GSTOP_G.Size = new System.Drawing.Size(97, 26);
            this.comboBox_GSTOP_G.TabIndex = 18;
            this.comboBox_GSTOP_G.SelectedIndexChanged += new System.EventHandler(this.comboBox_GSTOP_G_SelectedIndexChanged);
            // 
            // lbl_napis_czas_pracy
            // 
            this.lbl_napis_czas_pracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_napis_czas_pracy.Location = new System.Drawing.Point(273, 330);
            this.lbl_napis_czas_pracy.Name = "lbl_napis_czas_pracy";
            this.lbl_napis_czas_pracy.Size = new System.Drawing.Size(275, 39);
            this.lbl_napis_czas_pracy.TabIndex = 20;
            this.lbl_napis_czas_pracy.Text = "CZAS PRACY";
            this.lbl_napis_czas_pracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Work_Time
            // 
            this.lbl_Work_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Work_Time.Location = new System.Drawing.Point(273, 369);
            this.lbl_Work_Time.Name = "lbl_Work_Time";
            this.lbl_Work_Time.Size = new System.Drawing.Size(275, 39);
            this.lbl_Work_Time.TabIndex = 21;
            this.lbl_Work_Time.Text = "00:00:00";
            this.lbl_Work_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.Location = new System.Drawing.Point(12, 411);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(245, 27);
            this.btn_start.TabIndex = 22;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btn_Przerwa
            // 
            this.btn_Przerwa.BackColor = System.Drawing.Color.Yellow;
            this.btn_Przerwa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Przerwa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Przerwa.Location = new System.Drawing.Point(288, 411);
            this.btn_Przerwa.Name = "btn_Przerwa";
            this.btn_Przerwa.Size = new System.Drawing.Size(245, 27);
            this.btn_Przerwa.TabIndex = 23;
            this.btn_Przerwa.Text = "Przerwa";
            this.btn_Przerwa.UseVisualStyleBackColor = false;
            this.btn_Przerwa.Visible = false;
            this.btn_Przerwa.Click += new System.EventHandler(this.btn_Przerwa_Click);
            // 
            // btn_Koniec
            // 
            this.btn_Koniec.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Koniec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Koniec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_Koniec.Location = new System.Drawing.Point(549, 411);
            this.btn_Koniec.Name = "btn_Koniec";
            this.btn_Koniec.Size = new System.Drawing.Size(245, 27);
            this.btn_Koniec.TabIndex = 24;
            this.btn_Koniec.Text = "KONIEC";
            this.btn_Koniec.UseVisualStyleBackColor = false;
            this.btn_Koniec.Visible = false;
            this.btn_Koniec.Click += new System.EventHandler(this.btn_Koniec_Click);
            // 
            // Window_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Koniec);
            this.Controls.Add(this.btn_Przerwa);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_Work_Time);
            this.Controls.Add(this.lbl_napis_czas_pracy);
            this.Controls.Add(this.comboBox_GSTOP_M);
            this.Controls.Add(this.comboBox_GSTOP_G);
            this.Controls.Add(this.comboBox_GS_M);
            this.Controls.Add(this.lbl_DTTime2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_GS_G);
            this.Controls.Add(this.lbl_DTTime);
            this.Controls.Add(this.btn_odpracow);
            this.Controls.Add(this.btn_wnioski);
            this.Controls.Add(this.btn_ListObecn);
            this.Controls.Add(this.btn_X);
            this.Controls.Add(this.btn_minim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ewidencja Czasu Pracy";
            this.Load += new System.EventHandler(this.Window_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_minim;
        private System.Windows.Forms.Button btn_X;
        private System.Windows.Forms.Button btn_ListObecn;
        private System.Windows.Forms.Button btn_wnioski;
        private System.Windows.Forms.Button btn_odpracow;
        private System.Windows.Forms.Label lbl_DTTime;
        private System.Windows.Forms.ComboBox comboBox_GS_G;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DTTime2;
        private System.Windows.Forms.Timer timerDTTime;
        private System.Windows.Forms.ComboBox comboBox_GS_M;
        private System.Windows.Forms.ComboBox comboBox_GSTOP_M;
        private System.Windows.Forms.ComboBox comboBox_GSTOP_G;
        private System.Windows.Forms.Label lbl_napis_czas_pracy;
        private System.Windows.Forms.Label lbl_Work_Time;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Przerwa;
        private System.Windows.Forms.Button btn_Koniec;
    }
}
