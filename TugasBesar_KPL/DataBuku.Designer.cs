
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
            this.lblDataBuku = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.tbJudulBuku = new System.Windows.Forms.TextBox();
            this.tbPenerbit = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.lblCariBuku = new System.Windows.Forms.Label();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.lblDtBuku = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBanyakData = new System.Windows.Forms.Label();
            this.btHitung = new System.Windows.Forms.Button();
            this.lblbnyakData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataBuku
            // 
            this.lblDataBuku.AutoSize = true;
            this.lblDataBuku.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataBuku.Location = new System.Drawing.Point(331, 37);
            this.lblDataBuku.Name = "lblDataBuku";
            this.lblDataBuku.Size = new System.Drawing.Size(105, 25);
            this.lblDataBuku.TabIndex = 0;
            this.lblDataBuku.Text = "Data Buku";
            this.lblDataBuku.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(56, 66);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.button1_Click);
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
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(518, 286);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 39);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BTsubmit_Click);
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(256, 122);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(346, 23);
            this.tbIdBuku.TabIndex = 7;
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Location = new System.Drawing.Point(256, 160);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(346, 23);
            this.tbJudulBuku.TabIndex = 8;
            // 
            // tbPenerbit
            // 
            this.tbPenerbit.Location = new System.Drawing.Point(256, 203);
            this.tbPenerbit.Name = "tbPenerbit";
            this.tbPenerbit.Size = new System.Drawing.Size(346, 23);
            this.tbPenerbit.TabIndex = 9;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(256, 243);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(346, 23);
            this.tbStock.TabIndex = 10;
            this.tbStock.TextChanged += new System.EventHandler(this.tbStock_TextChanged);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBuku.Location = new System.Drawing.Point(128, 388);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowTemplate.Height = 25;
            this.dgvDataBuku.Size = new System.Drawing.Size(474, 143);
            this.dgvDataBuku.TabIndex = 11;
            this.dgvDataBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVdatabuku_CellClick);
            // 
            // lblCariBuku
            // 
            this.lblCariBuku.AutoSize = true;
            this.lblCariBuku.Location = new System.Drawing.Point(238, 352);
            this.lblCariBuku.Name = "lblCariBuku";
            this.lblCariBuku.Size = new System.Drawing.Size(121, 15);
            this.lblCariBuku.TabIndex = 12;
            this.lblCariBuku.Text = "Cari bedasarkan buku";
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(365, 349);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(141, 23);
            this.tbCari.TabIndex = 13;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(527, 348);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.BTcari_Click);
            // 
            // lblDtBuku
            // 
            this.lblDtBuku.AutoSize = true;
            this.lblDtBuku.Location = new System.Drawing.Point(84, 352);
            this.lblDtBuku.Name = "lblDtBuku";
            this.lblDtBuku.Size = new System.Drawing.Size(61, 15);
            this.lblDtBuku.TabIndex = 15;
            this.lblDtBuku.Text = "Data buku";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(157, 348);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BTback_Click);
            // 
            // lblBanyakData
            // 
            this.lblBanyakData.AutoSize = true;
            this.lblBanyakData.Location = new System.Drawing.Point(581, 541);
            this.lblBanyakData.Name = "lblBanyakData";
            this.lblBanyakData.Size = new System.Drawing.Size(12, 15);
            this.lblBanyakData.TabIndex = 17;
            this.lblBanyakData.Text = "-";
            // 
            // btHitung
            // 
            this.btHitung.Location = new System.Drawing.Point(423, 537);
            this.btHitung.Name = "btHitung";
            this.btHitung.Size = new System.Drawing.Size(75, 23);
            this.btHitung.TabIndex = 18;
            this.btHitung.Text = "Hitung";
            this.btHitung.UseVisualStyleBackColor = true;
            this.btHitung.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblbnyakData
            // 
            this.lblbnyakData.AutoSize = true;
            this.lblbnyakData.Location = new System.Drawing.Point(504, 541);
            this.lblbnyakData.Name = "lblbnyakData";
            this.lblbnyakData.Size = new System.Drawing.Size(80, 15);
            this.lblbnyakData.TabIndex = 19;
            this.lblbnyakData.Text = "Banyak data : ";
            // 
            // DataBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(685, 593);
            this.Controls.Add(this.lblbnyakData);
            this.Controls.Add(this.btHitung);
            this.Controls.Add(this.lblBanyakData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDtBuku);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.lblCariBuku);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPenerbit);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.tbIdBuku);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblDataBuku);
            this.Name = "DataBuku";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DataBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataBuku;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbJudulBuku;
        private System.Windows.Forms.TextBox tbPenerbit;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.DataGridView dgvDataBuku;
        private System.Windows.Forms.Label lblCariBuku;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label lblDtBuku;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBanyakData;
        private System.Windows.Forms.Button btHitung;
        private System.Windows.Forms.Label lblbnyakData;
    }
}