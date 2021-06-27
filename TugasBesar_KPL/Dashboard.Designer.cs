﻿
namespace TugasBesar_KPL
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMeminjamBuku = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDoaIbu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnMeminjamBuku);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(30, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(138, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMeminjamBuku
            // 
            this.btnMeminjamBuku.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.peminjaman;
            this.btnMeminjamBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeminjamBuku.FlatAppearance.BorderSize = 0;
            this.btnMeminjamBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeminjamBuku.Location = new System.Drawing.Point(57, 146);
            this.btnMeminjamBuku.Name = "btnMeminjamBuku";
            this.btnMeminjamBuku.Size = new System.Drawing.Size(75, 148);
            this.btnMeminjamBuku.TabIndex = 2;
            this.btnMeminjamBuku.Text = "Meminjam Buku";
            this.btnMeminjamBuku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeminjamBuku.UseVisualStyleBackColor = true;
            this.btnMeminjamBuku.Click += new System.EventHandler(this.btnMeminjamBuku_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.avatar50px;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(57, 24);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 93);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblNama);
            this.panel2.Controls.Add(this.lblSelamatDatang);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 40);
            this.panel2.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(111, 15);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(12, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "-";
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Location = new System.Drawing.Point(20, 13);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(96, 15);
            this.lblSelamatDatang.TabIndex = 1;
            this.lblSelamatDatang.Text = "Selamat Datang, ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(586, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(114, 40);
            this.panel4.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.icons8_close_window_24;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(70, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.icons8_minimize_window_24;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(32, 11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDoaIbu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 410);
            this.panel3.TabIndex = 2;
            // 
            // btnDoaIbu
            // 
            this.btnDoaIbu.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.doa_ibu_cover;
            this.btnDoaIbu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoaIbu.FlatAppearance.BorderSize = 0;
            this.btnDoaIbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoaIbu.Location = new System.Drawing.Point(31, 35);
            this.btnDoaIbu.Name = "btnDoaIbu";
            this.btnDoaIbu.Size = new System.Drawing.Size(152, 175);
            this.btnDoaIbu.TabIndex = 0;
            this.btnDoaIbu.Text = "Doa Ibu";
            this.btnDoaIbu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDoaIbu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDoaIbu.UseVisualStyleBackColor = true;
            this.btnDoaIbu.Click += new System.EventHandler(this.btnDoaIbu_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        
        private System.Windows.Forms.Button btnMeminjamBuku;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Button btnDoaIbu;
    }
}

