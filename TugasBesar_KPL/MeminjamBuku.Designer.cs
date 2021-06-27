
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
            this.labelNama = new System.Windows.Forms.Label();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.labelJudulBuku = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lvDataPeminjam = new System.Windows.Forms.ListView();
            this.LibraryId = new System.Windows.Forms.ColumnHeader();
            this.NamaPeminjam = new System.Windows.Forms.ColumnHeader();
            this.IdBook = new System.Windows.Forms.ColumnHeader();
            this.JudulBuku = new System.Windows.Forms.ColumnHeader();
            this.TanggalPinjam = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // tbLibraryId
            // 
            this.tbLibraryId.Location = new System.Drawing.Point(276, 19);
            this.tbLibraryId.Name = "tbLibraryId";
            this.tbLibraryId.Size = new System.Drawing.Size(398, 23);
            this.tbLibraryId.TabIndex = 0;
            this.tbLibraryId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNamaPeminjam
            // 
            this.tbNamaPeminjam.Location = new System.Drawing.Point(276, 58);
            this.tbNamaPeminjam.Name = "tbNamaPeminjam";
            this.tbNamaPeminjam.Size = new System.Drawing.Size(398, 23);
            this.tbNamaPeminjam.TabIndex = 1;
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(276, 102);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(398, 23);
            this.tbIdBuku.TabIndex = 2;
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Location = new System.Drawing.Point(276, 144);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(398, 23);
            this.tbJudulBuku.TabIndex = 3;
            // 
            // labelLibId
            // 
            this.labelLibId.AutoSize = true;
            this.labelLibId.Location = new System.Drawing.Point(112, 26);
            this.labelLibId.Name = "labelLibId";
            this.labelLibId.Size = new System.Drawing.Size(56, 15);
            this.labelLibId.TabIndex = 4;
            this.labelLibId.Text = "Library Id";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(112, 65);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(96, 15);
            this.labelNama.TabIndex = 5;
            this.labelNama.Text = "Nama Peminjam";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(112, 109);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(47, 15);
            this.labelIdBuku.TabIndex = 6;
            this.labelIdBuku.Text = "Id Buku";
            // 
            // labelJudulBuku
            // 
            this.labelJudulBuku.AutoSize = true;
            this.labelJudulBuku.Location = new System.Drawing.Point(112, 151);
            this.labelJudulBuku.Name = "labelJudulBuku";
            this.labelJudulBuku.Size = new System.Drawing.Size(65, 15);
            this.labelJudulBuku.TabIndex = 7;
            this.labelJudulBuku.Text = "Judul Buku";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(112, 188);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(562, 38);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lvDataPeminjam
            // 
            this.lvDataPeminjam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LibraryId,
            this.NamaPeminjam,
            this.IdBook,
            this.JudulBuku,
            this.TanggalPinjam});
            this.lvDataPeminjam.HideSelection = false;
            this.lvDataPeminjam.Location = new System.Drawing.Point(29, 244);
            this.lvDataPeminjam.Name = "lvDataPeminjam";
            this.lvDataPeminjam.Size = new System.Drawing.Size(755, 163);
            this.lvDataPeminjam.TabIndex = 9;
            this.lvDataPeminjam.UseCompatibleStateImageBehavior = false;
            this.lvDataPeminjam.View = System.Windows.Forms.View.Details;
            this.lvDataPeminjam.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // LibraryId
            // 
            this.LibraryId.Name = "LibraryId";
            this.LibraryId.Text = "Library Id";
            this.LibraryId.Width = 100;
            // 
            // NamaPeminjam
            // 
            this.NamaPeminjam.Name = "NamaPeminjam";
            this.NamaPeminjam.Text = "Nama Peminjam";
            this.NamaPeminjam.Width = 200;
            // 
            // IdBook
            // 
            this.IdBook.Name = "IdBook";
            this.IdBook.Text = "Id Buku";
            this.IdBook.Width = 100;
            // 
            // JudulBuku
            // 
            this.JudulBuku.Name = "JudulBuku";
            this.JudulBuku.Text = "Judul Buku";
            this.JudulBuku.Width = 200;
            // 
            // TanggalPinjam
            // 
            this.TanggalPinjam.Name = "TanggalPinjam";
            this.TanggalPinjam.Text = "Tanggal Pinjam";
            this.TanggalPinjam.Width = 150;
            // 
            // MeminjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 419);
            this.Controls.Add(this.lvDataPeminjam);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelJudulBuku);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelLibId);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.tbIdBuku);
            this.Controls.Add(this.tbNamaPeminjam);
            this.Controls.Add(this.tbLibraryId);
            this.Name = "MeminjamBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeminjamBuku";
            this.Load += new System.EventHandler(this.MeminjamBuku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibraryId;
        private System.Windows.Forms.TextBox tbNamaPeminjam;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbJudulBuku;
        private System.Windows.Forms.Label labelLibId;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.Label labelJudulBuku;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView lvDataPeminjam;
        private System.Windows.Forms.ColumnHeader LibraryId;
        private System.Windows.Forms.ColumnHeader NamaPeminjam;
        private System.Windows.Forms.ColumnHeader IdBook;
        private System.Windows.Forms.ColumnHeader JudulBuku;
        private System.Windows.Forms.ColumnHeader TanggalPinjam;
    }
}