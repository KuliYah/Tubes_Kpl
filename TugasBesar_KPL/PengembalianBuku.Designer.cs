
namespace TugasBesar_KPL
{
    partial class PengembalianBuku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengembalianBuku));
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvDataPeminjam = new System.Windows.Forms.DataGridView();
            this.labelJudulBuku = new System.Windows.Forms.Label();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.labelNamaPeminjam = new System.Windows.Forms.Label();
            this.labelLibId = new System.Windows.Forms.Label();
            this.tbJudulBuku = new System.Windows.Forms.TextBox();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.tbNamaPeminjam = new System.Windows.Forms.TextBox();
            this.tbLibraryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPengembalian = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(36, 28);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 26;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKembalikan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKembalikan.Location = new System.Drawing.Point(314, 203);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(192, 42);
            this.btnKembalikan.TabIndex = 25;
            this.btnKembalikan.Text = "Kembalikan";
            this.btnKembalikan.UseVisualStyleBackColor = false;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(512, 203);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 42);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvDataPeminjam
            // 
            this.dgvDataPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjam.Location = new System.Drawing.Point(12, 272);
            this.dgvDataPeminjam.Name = "dgvDataPeminjam";
            this.dgvDataPeminjam.RowHeadersWidth = 51;
            this.dgvDataPeminjam.RowTemplate.Height = 25;
            this.dgvDataPeminjam.Size = new System.Drawing.Size(368, 150);
            this.dgvDataPeminjam.TabIndex = 23;
            this.dgvDataPeminjam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPeminjam_CellClick);
            // 
            // labelJudulBuku
            // 
            this.labelJudulBuku.AutoSize = true;
            this.labelJudulBuku.Location = new System.Drawing.Point(203, 170);
            this.labelJudulBuku.Name = "labelJudulBuku";
            this.labelJudulBuku.Size = new System.Drawing.Size(65, 15);
            this.labelJudulBuku.TabIndex = 22;
            this.labelJudulBuku.Text = "Judul Buku";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(203, 131);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(47, 15);
            this.labelIdBuku.TabIndex = 21;
            this.labelIdBuku.Text = "Id Buku";
            // 
            // labelNamaPeminjam
            // 
            this.labelNamaPeminjam.AutoSize = true;
            this.labelNamaPeminjam.Location = new System.Drawing.Point(203, 91);
            this.labelNamaPeminjam.Name = "labelNamaPeminjam";
            this.labelNamaPeminjam.Size = new System.Drawing.Size(96, 15);
            this.labelNamaPeminjam.TabIndex = 20;
            this.labelNamaPeminjam.Text = "Nama Peminjam";
            // 
            // labelLibId
            // 
            this.labelLibId.AutoSize = true;
            this.labelLibId.Location = new System.Drawing.Point(203, 50);
            this.labelLibId.Name = "labelLibId";
            this.labelLibId.Size = new System.Drawing.Size(56, 15);
            this.labelLibId.TabIndex = 19;
            this.labelLibId.Text = "Library Id";
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Location = new System.Drawing.Point(339, 163);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(316, 23);
            this.tbJudulBuku.TabIndex = 18;
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(339, 124);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(316, 23);
            this.tbIdBuku.TabIndex = 17;
            // 
            // tbNamaPeminjam
            // 
            this.tbNamaPeminjam.Location = new System.Drawing.Point(339, 84);
            this.tbNamaPeminjam.Name = "tbNamaPeminjam";
            this.tbNamaPeminjam.Size = new System.Drawing.Size(316, 23);
            this.tbNamaPeminjam.TabIndex = 16;
            // 
            // tbLibraryId
            // 
            this.tbLibraryId.Location = new System.Drawing.Point(339, 43);
            this.tbLibraryId.Name = "tbLibraryId";
            this.tbLibraryId.Size = new System.Drawing.Size(316, 23);
            this.tbLibraryId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Data Peminjam";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPengembalian
            // 
            this.dgvPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengembalian.Location = new System.Drawing.Point(410, 272);
            this.dgvPengembalian.Name = "dgvPengembalian";
            this.dgvPengembalian.RowTemplate.Height = 25;
            this.dgvPengembalian.Size = new System.Drawing.Size(378, 150);
            this.dgvPengembalian.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data Pengembalian";
            // 
            // PengembalianBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPengembalian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvDataPeminjam);
            this.Controls.Add(this.labelJudulBuku);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.labelNamaPeminjam);
            this.Controls.Add(this.labelLibId);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.tbIdBuku);
            this.Controls.Add(this.tbNamaPeminjam);
            this.Controls.Add(this.tbLibraryId);
            this.Name = "PengembalianBuku";
            this.Text = "PengembalianBuku";
            this.Load += new System.EventHandler(this.PengembalianBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnKembalikan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvDataPeminjam;
        private System.Windows.Forms.Label labelJudulBuku;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.Label labelNamaPeminjam;
        private System.Windows.Forms.Label labelLibId;
        private System.Windows.Forms.TextBox tbJudulBuku;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbNamaPeminjam;
        private System.Windows.Forms.TextBox tbLibraryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPengembalian;
        private System.Windows.Forms.Label label2;
    }
}