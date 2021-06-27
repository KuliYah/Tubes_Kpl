
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
            this.LVdatabuku = new System.Windows.Forms.ListView();
            this.id_buku = new System.Windows.Forms.ColumnHeader();
            this.Judul_buku = new System.Windows.Forms.ColumnHeader();
            this.penerbit = new System.Windows.Forms.ColumnHeader();
            this.stock = new System.Windows.Forms.ColumnHeader();
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
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stock";
            // 
            // BTsubmit
            // 
            this.BTsubmit.Location = new System.Drawing.Point(98, 299);
            this.BTsubmit.Name = "BTsubmit";
            this.BTsubmit.Size = new System.Drawing.Size(75, 23);
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
            // LVdatabuku
            // 
            this.LVdatabuku.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_buku,
            this.Judul_buku,
            this.penerbit,
            this.stock});
            this.LVdatabuku.HideSelection = false;
            this.LVdatabuku.Location = new System.Drawing.Point(161, 341);
            this.LVdatabuku.Name = "LVdatabuku";
            this.LVdatabuku.Size = new System.Drawing.Size(487, 97);
            this.LVdatabuku.TabIndex = 11;
            this.LVdatabuku.UseCompatibleStateImageBehavior = false;
            this.LVdatabuku.View = System.Windows.Forms.View.Details;
            this.LVdatabuku.SelectedIndexChanged += new System.EventHandler(this.LVdatabuku_SelectedIndexChanged);
            // 
            // id_buku
            // 
            this.id_buku.Text = "id_buku";
            this.id_buku.Width = 120;
            // 
            // Judul_buku
            // 
            this.Judul_buku.Text = "judul_buku";
            this.Judul_buku.Width = 120;
            // 
            // penerbit
            // 
            this.penerbit.Text = "penerbit";
            this.penerbit.Width = 120;
            // 
            // stock
            // 
            this.stock.Text = "stock";
            this.stock.Width = 120;
            // 
            // DataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LVdatabuku);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ListView LVdatabuku;
        private System.Windows.Forms.ColumnHeader id_buku;
        private System.Windows.Forms.ColumnHeader Judul_buku;
        private System.Windows.Forms.ColumnHeader penerbit;
        private System.Windows.Forms.ColumnHeader stock;
    }
}