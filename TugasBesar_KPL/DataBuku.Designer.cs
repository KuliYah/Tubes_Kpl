
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(346, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(256, 203);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(346, 23);
            this.textBox3.TabIndex = 9;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(256, 243);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(346, 23);
            this.txtStock.TabIndex = 10;
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
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ListView LVdatabuku;
        private System.Windows.Forms.ColumnHeader id_buku;
        private System.Windows.Forms.ColumnHeader Judul_buku;
        private System.Windows.Forms.ColumnHeader penerbit;
        private System.Windows.Forms.ColumnHeader stock;
    }
}