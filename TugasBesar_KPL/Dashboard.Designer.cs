
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDataPengguna = new System.Windows.Forms.Label();
            this.lblDataBuku = new System.Windows.Forms.Label();
            this.lblMeminjamBuku = new System.Windows.Forms.Label();
            this.btnDataPengguna = new System.Windows.Forms.Button();
            this.btnDataBuku = new System.Windows.Forms.Button();
            this.btnMeminjamBuku = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(17, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(138, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblDashboard);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(47, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 40);
            this.panel2.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDashboard.Location = new System.Drawing.Point(6, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(126, 25);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(739, 0);
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
            this.panel3.Controls.Add(this.lblDataPengguna);
            this.panel3.Controls.Add(this.lblDataBuku);
            this.panel3.Controls.Add(this.lblMeminjamBuku);
            this.panel3.Controls.Add(this.btnDataPengguna);
            this.panel3.Controls.Add(this.btnDataBuku);
            this.panel3.Controls.Add(this.btnMeminjamBuku);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(47, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 410);
            this.panel3.TabIndex = 2;
            // 
            // lblDataPengguna
            // 
            this.lblDataPengguna.AutoSize = true;
            this.lblDataPengguna.Location = new System.Drawing.Point(581, 248);
            this.lblDataPengguna.Name = "lblDataPengguna";
            this.lblDataPengguna.Size = new System.Drawing.Size(94, 15);
            this.lblDataPengguna.TabIndex = 8;
            this.lblDataPengguna.Text = "  Data Pengguna";
            this.lblDataPengguna.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDataBuku
            // 
            this.lblDataBuku.AutoSize = true;
            this.lblDataBuku.Location = new System.Drawing.Point(380, 248);
            this.lblDataBuku.Name = "lblDataBuku";
            this.lblDataBuku.Size = new System.Drawing.Size(61, 15);
            this.lblDataBuku.TabIndex = 7;
            this.lblDataBuku.Text = "Data Buku";
            // 
            // lblMeminjamBuku
            // 
            this.lblMeminjamBuku.AutoSize = true;
            this.lblMeminjamBuku.Location = new System.Drawing.Point(152, 248);
            this.lblMeminjamBuku.Name = "lblMeminjamBuku";
            this.lblMeminjamBuku.Size = new System.Drawing.Size(95, 15);
            this.lblMeminjamBuku.TabIndex = 6;
            this.lblMeminjamBuku.Text = "Meminjam Buku";
            // 
            // btnDataPengguna
            // 
            this.btnDataPengguna.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.anggota;
            this.btnDataPengguna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDataPengguna.FlatAppearance.BorderSize = 0;
            this.btnDataPengguna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataPengguna.Location = new System.Drawing.Point(581, 133);
            this.btnDataPengguna.Name = "btnDataPengguna";
            this.btnDataPengguna.Size = new System.Drawing.Size(99, 112);
            this.btnDataPengguna.TabIndex = 5;
            this.btnDataPengguna.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDataPengguna.UseVisualStyleBackColor = true;
            this.btnDataPengguna.Click += new System.EventHandler(this.btnDataPengguna_Click);
            // 
            // btnDataBuku
            // 
            this.btnDataBuku.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.buku1;
            this.btnDataBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDataBuku.FlatAppearance.BorderSize = 0;
            this.btnDataBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataBuku.Location = new System.Drawing.Point(361, 133);
            this.btnDataBuku.Name = "btnDataBuku";
            this.btnDataBuku.Size = new System.Drawing.Size(99, 112);
            this.btnDataBuku.TabIndex = 4;
            this.btnDataBuku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDataBuku.UseVisualStyleBackColor = true;
            this.btnDataBuku.Click += new System.EventHandler(this.btnDataBuku_Click);
            // 
            // btnMeminjamBuku
            // 
            this.btnMeminjamBuku.BackgroundImage = global::TugasBesar_KPL.Properties.Resources.peminjaman;
            this.btnMeminjamBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeminjamBuku.FlatAppearance.BorderSize = 0;
            this.btnMeminjamBuku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeminjamBuku.Location = new System.Drawing.Point(148, 133);
            this.btnMeminjamBuku.Name = "btnMeminjamBuku";
            this.btnMeminjamBuku.Size = new System.Drawing.Size(99, 112);
            this.btnMeminjamBuku.TabIndex = 2;
            this.btnMeminjamBuku.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeminjamBuku.UseVisualStyleBackColor = true;
            this.btnMeminjamBuku.Click += new System.EventHandler(this.btnMeminjamBuku_Click);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMeminjamBuku;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblDataPengguna;
        private System.Windows.Forms.Label lblDataBuku;
        private System.Windows.Forms.Label lblMeminjamBuku;
        private System.Windows.Forms.Button btnDataPengguna;
        private System.Windows.Forms.Button btnDataBuku;
    }
}

