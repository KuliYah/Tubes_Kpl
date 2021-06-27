
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbJudulBuku = new System.Windows.Forms.TextBox();
            this.labelLibId = new System.Windows.Forms.Label();
            this.labelNamaPeminjam = new System.Windows.Forms.Label();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.labelJudulBuku = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LibraryId = new System.Windows.Forms.ColumnHeader();
            this.NamaPeminjam = new System.Windows.Forms.ColumnHeader();
            this.IdBuku = new System.Windows.Forms.ColumnHeader();
            this.JudulBuku = new System.Windows.Forms.ColumnHeader();
            this.TglPinjam = new System.Windows.Forms.ColumnHeader();
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            this.btnSubmit.Size = new System.Drawing.Size(452, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LibraryId,
            this.NamaPeminjam,
            this.IdBuku,
            this.JudulBuku,
            this.TglPinjam});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 158);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.NamaPeminjam.Width = 150;
            // 
            // IdBuku
            // 
            this.IdBuku.Name = "IdBuku";
            this.IdBuku.Text = "Id Buku";
            this.IdBuku.Width = 100;
            // 
            // JudulBuku
            // 
            this.JudulBuku.Name = "JudulBuku";
            this.JudulBuku.Text = "JudulBuku";
            this.JudulBuku.Width = 200;
            // 
            // TglPinjam
            // 
            this.TglPinjam.Name = "TglPinjam";
            this.TglPinjam.Text = "Tanggal Pinjam";
            this.TglPinjam.Width = 150;
            // 
            // MeminjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(811, 419);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelJudulBuku);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.labelNamaPeminjam);
            this.Controls.Add(this.labelLibId);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbJudulBuku;
        private System.Windows.Forms.Label labelLibId;
        private System.Windows.Forms.Label labelNamaPeminjam;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.Label labelJudulBuku;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LibraryId;
        private System.Windows.Forms.ColumnHeader NamaPeminjam;
        private System.Windows.Forms.ColumnHeader IdBuku;
        private System.Windows.Forms.ColumnHeader JudulBuku;
        private System.Windows.Forms.ColumnHeader TglPinjam;
    }
}