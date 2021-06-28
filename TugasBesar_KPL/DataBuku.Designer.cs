
namespace TugasBesar_KPL
{
    partial class DataBuku
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
            this.LBLdatabuku = new System.Windows.Forms.Label();
            this.BTkembali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTsubmit = new System.Windows.Forms.Button();
            this.TBidbuku = new System.Windows.Forms.TextBox();
            this.TBjudulbuku = new System.Windows.Forms.TextBox();
            this.TBpenerbit = new System.Windows.Forms.TextBox();
            this.TBstock = new System.Windows.Forms.TextBox();
            this.DGVdatabuku = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TBcari = new System.Windows.Forms.TextBox();
            this.BTcari = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BTback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatabuku)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLdatabuku
            // 
            this.LBLdatabuku.AutoSize = true;
            this.LBLdatabuku.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLdatabuku.Location = new System.Drawing.Point(331, 37);
            this.LBLdatabuku.Name = "LBLdatabuku";
            this.LBLdatabuku.Size = new System.Drawing.Size(105, 25);
            this.LBLdatabuku.TabIndex = 0;
            this.LBLdatabuku.Text = "Data Buku";
            this.LBLdatabuku.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTkembali
            // 
            this.BTkembali.Location = new System.Drawing.Point(56, 66);
            this.BTkembali.Name = "BTkembali";
            this.BTkembali.Size = new System.Drawing.Size(75, 23);
            this.BTkembali.TabIndex = 1;
            this.BTkembali.Text = "kembali";
            this.BTkembali.UseVisualStyleBackColor = true;
            this.BTkembali.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "id buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Penerbit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stok";
            // 
            // BTsubmit
            // 
            this.BTsubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTsubmit.Location = new System.Drawing.Point(148, 284);
            this.BTsubmit.Name = "BTsubmit";
            this.BTsubmit.Size = new System.Drawing.Size(84, 39);
            this.BTsubmit.TabIndex = 6;
            this.BTsubmit.Text = "Submit";
            this.BTsubmit.UseVisualStyleBackColor = true;
            this.BTsubmit.Click += new System.EventHandler(this.BTsubmit_Click);
            // 
            // TBidbuku
            // 
            this.TBidbuku.Location = new System.Drawing.Point(256, 122);
            this.TBidbuku.Name = "TBidbuku";
            this.TBidbuku.Size = new System.Drawing.Size(346, 23);
            this.TBidbuku.TabIndex = 7;
            // 
            // TBjudulbuku
            // 
            this.TBjudulbuku.Location = new System.Drawing.Point(256, 160);
            this.TBjudulbuku.Name = "TBjudulbuku";
            this.TBjudulbuku.Size = new System.Drawing.Size(346, 23);
            this.TBjudulbuku.TabIndex = 8;
            // 
            // TBpenerbit
            // 
            this.TBpenerbit.Location = new System.Drawing.Point(256, 203);
            this.TBpenerbit.Name = "TBpenerbit";
            this.TBpenerbit.Size = new System.Drawing.Size(346, 23);
            this.TBpenerbit.TabIndex = 9;
            // 
            // TBstock
            // 
            this.TBstock.Location = new System.Drawing.Point(256, 243);
            this.TBstock.Name = "TBstock";
            this.TBstock.Size = new System.Drawing.Size(346, 23);
            this.TBstock.TabIndex = 10;
            // 
            // DGVdatabuku
            // 
            this.DGVdatabuku.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGVdatabuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdatabuku.Location = new System.Drawing.Point(148, 381);
            this.DGVdatabuku.Name = "DGVdatabuku";
            this.DGVdatabuku.RowTemplate.Height = 25;
            this.DGVdatabuku.Size = new System.Drawing.Size(474, 150);
            this.DGVdatabuku.TabIndex = 11;
            this.DGVdatabuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdatabuku_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cari bedasarkan buku";
            // 
            // TBcari
            // 
            this.TBcari.Location = new System.Drawing.Point(388, 349);
            this.TBcari.Name = "TBcari";
            this.TBcari.Size = new System.Drawing.Size(141, 23);
            this.TBcari.TabIndex = 13;
            // 
            // BTcari
            // 
            this.BTcari.Location = new System.Drawing.Point(547, 348);
            this.BTcari.Name = "BTcari";
            this.BTcari.Size = new System.Drawing.Size(75, 23);
            this.BTcari.TabIndex = 14;
            this.BTcari.Text = "cari";
            this.BTcari.UseVisualStyleBackColor = true;
            this.BTcari.Click += new System.EventHandler(this.BTcari_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data buku";
            // 
            // BTback
            // 
            this.BTback.Location = new System.Drawing.Point(157, 348);
            this.BTback.Name = "BTback";
            this.BTback.Size = new System.Drawing.Size(75, 23);
            this.BTback.TabIndex = 16;
            this.BTback.Text = "back";
            this.BTback.UseVisualStyleBackColor = true;
            this.BTback.Click += new System.EventHandler(this.BTback_Click);
            // 
            // DataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(764, 554);
            this.Controls.Add(this.BTback);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BTcari);
            this.Controls.Add(this.TBcari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVdatabuku);
            this.Controls.Add(this.TBstock);
            this.Controls.Add(this.TBpenerbit);
            this.Controls.Add(this.TBjudulbuku);
            this.Controls.Add(this.TBidbuku);
            this.Controls.Add(this.BTsubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTkembali);
            this.Controls.Add(this.LBLdatabuku);
            this.Name = "DataBuku";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatabuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLdatabuku;
        private System.Windows.Forms.Button BTkembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTsubmit;
        private System.Windows.Forms.TextBox TBidbuku;
        private System.Windows.Forms.TextBox TBjudulbuku;
        private System.Windows.Forms.TextBox TBpenerbit;
        private System.Windows.Forms.TextBox TBstock;
        private System.Windows.Forms.DataGridView DGVdatabuku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBcari;
        private System.Windows.Forms.Button BTcari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTback;
    }
}