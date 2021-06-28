
namespace TugasBesar_KPL
{
    partial class MeminjamBuku
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
            this.tbLibraryId = new System.Windows.Forms.TextBox();
            this.tbNamaPeminjam = new System.Windows.Forms.TextBox();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.tbJudulBuku = new System.Windows.Forms.TextBox();
            this.labelLibId = new System.Windows.Forms.Label();
            this.labelNamaPeminjam = new System.Windows.Forms.Label();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.labelJudulBuku = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvDataPeminjam = new System.Windows.Forms.DataGridView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLibraryId
            // 
            this.tbLibraryId.Location = new System.Drawing.Point(316, 28);
            this.tbLibraryId.Name = "tbLibraryId";
            this.tbLibraryId.Size = new System.Drawing.Size(316, 23);
            this.tbLibraryId.TabIndex = 0;
            this.tbLibraryId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNamaPeminjam
            // 
            this.tbNamaPeminjam.Location = new System.Drawing.Point(316, 69);
            this.tbNamaPeminjam.Name = "tbNamaPeminjam";
            this.tbNamaPeminjam.Size = new System.Drawing.Size(316, 23);
            this.tbNamaPeminjam.TabIndex = 1;
            this.tbNamaPeminjam.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(316, 109);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(316, 23);
            this.tbIdBuku.TabIndex = 2;
            this.tbIdBuku.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Location = new System.Drawing.Point(316, 148);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(316, 23);
            this.tbJudulBuku.TabIndex = 3;
            this.tbJudulBuku.TextChanged += new System.EventHandler(this.tbJudulBuku_TextChanged);
            // 
            // labelLibId
            // 
            this.labelLibId.AutoSize = true;
            this.labelLibId.Location = new System.Drawing.Point(180, 35);
            this.labelLibId.Name = "labelLibId";
            this.labelLibId.Size = new System.Drawing.Size(56, 15);
            this.labelLibId.TabIndex = 4;
            this.labelLibId.Text = "Library Id";
            // 
            // labelNamaPeminjam
            // 
            this.labelNamaPeminjam.AutoSize = true;
            this.labelNamaPeminjam.Location = new System.Drawing.Point(180, 76);
            this.labelNamaPeminjam.Name = "labelNamaPeminjam";
            this.labelNamaPeminjam.Size = new System.Drawing.Size(96, 15);
            this.labelNamaPeminjam.TabIndex = 5;
            this.labelNamaPeminjam.Text = "Nama Peminjam";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(180, 116);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(47, 15);
            this.labelIdBuku.TabIndex = 6;
            this.labelIdBuku.Text = "Id Buku";
            // 
            // labelJudulBuku
            // 
            this.labelJudulBuku.AutoSize = true;
            this.labelJudulBuku.Location = new System.Drawing.Point(180, 155);
            this.labelJudulBuku.Name = "labelJudulBuku";
            this.labelJudulBuku.Size = new System.Drawing.Size(65, 15);
            this.labelJudulBuku.TabIndex = 7;
            this.labelJudulBuku.Text = "Judul Buku";
            this.labelJudulBuku.Click += new System.EventHandler(this.labelJudulBuku_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(180, 188);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(192, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvDataPeminjam
            // 
            this.dgvDataPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjam.Location = new System.Drawing.Point(89, 257);
            this.dgvDataPeminjam.Name = "dgvDataPeminjam";
            this.dgvDataPeminjam.RowHeadersWidth = 51;
            this.dgvDataPeminjam.RowTemplate.Height = 25;
            this.dgvDataPeminjam.Size = new System.Drawing.Size(653, 150);
            this.dgvDataPeminjam.TabIndex = 11;
            this.dgvDataPeminjam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPeminjam_CellClick);
            this.dgvDataPeminjam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPeminjam_CellContentClick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(671, 188);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(71, 42);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKembalikan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKembalikan.Location = new System.Drawing.Point(440, 188);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(192, 42);
            this.btnKembalikan.TabIndex = 13;
            this.btnKembalikan.Text = "Kembalikan";
            this.btnKembalikan.UseVisualStyleBackColor = false;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);
            // 
            // MeminjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(811, 419);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvDataPeminjam);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelJudulBuku);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.labelNamaPeminjam);
            this.Controls.Add(this.labelLibId);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.tbIdBuku);
            this.Controls.Add(this.tbNamaPeminjam);
            this.Controls.Add(this.tbLibraryId);
            this.Name = "MeminjamBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeminjamBuku";
            this.Load += new System.EventHandler(this.MeminjamBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibraryId;
        private System.Windows.Forms.TextBox tbNamaPeminjam;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbJudulBuku;
        private System.Windows.Forms.Label labelLibId;
        private System.Windows.Forms.Label labelNamaPeminjam;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.Label labelJudulBuku;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvDataPeminjam;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnKembalikan;
    }
}