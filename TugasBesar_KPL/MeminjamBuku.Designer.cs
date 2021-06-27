
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDataPeminjam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjam)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLibraryId
            // 
            this.tbLibraryId.Location = new System.Drawing.Point(361, 37);
            this.tbLibraryId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLibraryId.Name = "tbLibraryId";
            this.tbLibraryId.Size = new System.Drawing.Size(361, 27);
            this.tbLibraryId.TabIndex = 0;
            this.tbLibraryId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNamaPeminjam
            // 
            this.tbNamaPeminjam.Location = new System.Drawing.Point(361, 92);
            this.tbNamaPeminjam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNamaPeminjam.Name = "tbNamaPeminjam";
            this.tbNamaPeminjam.Size = new System.Drawing.Size(361, 27);
            this.tbNamaPeminjam.TabIndex = 1;
            this.tbNamaPeminjam.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Location = new System.Drawing.Point(361, 145);
            this.tbIdBuku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(361, 27);
            this.tbIdBuku.TabIndex = 2;
            this.tbIdBuku.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbJudulBuku
            // 
            this.tbJudulBuku.Location = new System.Drawing.Point(361, 197);
            this.tbJudulBuku.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbJudulBuku.Name = "tbJudulBuku";
            this.tbJudulBuku.Size = new System.Drawing.Size(361, 27);
            this.tbJudulBuku.TabIndex = 3;
            this.tbJudulBuku.TextChanged += new System.EventHandler(this.tbJudulBuku_TextChanged);
            // 
            // labelLibId
            // 
            this.labelLibId.AutoSize = true;
            this.labelLibId.Location = new System.Drawing.Point(206, 47);
            this.labelLibId.Name = "labelLibId";
            this.labelLibId.Size = new System.Drawing.Size(71, 20);
            this.labelLibId.TabIndex = 4;
            this.labelLibId.Text = "Library Id";
            // 
            // labelNamaPeminjam
            // 
            this.labelNamaPeminjam.AutoSize = true;
            this.labelNamaPeminjam.Location = new System.Drawing.Point(206, 101);
            this.labelNamaPeminjam.Name = "labelNamaPeminjam";
            this.labelNamaPeminjam.Size = new System.Drawing.Size(118, 20);
            this.labelNamaPeminjam.TabIndex = 5;
            this.labelNamaPeminjam.Text = "Nama Peminjam";
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Location = new System.Drawing.Point(206, 155);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(58, 20);
            this.labelIdBuku.TabIndex = 6;
            this.labelIdBuku.Text = "Id Buku";
            // 
            // labelJudulBuku
            // 
            this.labelJudulBuku.AutoSize = true;
            this.labelJudulBuku.Location = new System.Drawing.Point(206, 207);
            this.labelJudulBuku.Name = "labelJudulBuku";
            this.labelJudulBuku.Size = new System.Drawing.Size(79, 20);
            this.labelJudulBuku.TabIndex = 7;
            this.labelJudulBuku.Text = "Judul Buku";
            this.labelJudulBuku.Click += new System.EventHandler(this.labelJudulBuku_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(206, 251);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(219, 56);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(503, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Kembalikan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDataPeminjam
            // 
            this.dgvDataPeminjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjam.Location = new System.Drawing.Point(55, 343);
            this.dgvDataPeminjam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDataPeminjam.Name = "dgvDataPeminjam";
            this.dgvDataPeminjam.RowHeadersWidth = 51;
            this.dgvDataPeminjam.RowTemplate.Height = 25;
            this.dgvDataPeminjam.Size = new System.Drawing.Size(834, 200);
            this.dgvDataPeminjam.TabIndex = 11;
            this.dgvDataPeminjam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPeminjam_CellContentClick);
            // 
            // MeminjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(927, 559);
            this.Controls.Add(this.dgvDataPeminjam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.labelJudulBuku);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.labelNamaPeminjam);
            this.Controls.Add(this.labelLibId);
            this.Controls.Add(this.tbJudulBuku);
            this.Controls.Add(this.tbIdBuku);
            this.Controls.Add(this.tbNamaPeminjam);
            this.Controls.Add(this.tbLibraryId);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDataPeminjam;
    }
}