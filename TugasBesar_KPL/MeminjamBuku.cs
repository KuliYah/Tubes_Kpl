using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TugasBesar_KPL
{
    public partial class MeminjamBuku : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable dataTable = new DataTable();
        public MeminjamBuku()
        {
            InitializeComponent();
        }

        public DataTable getDataPeminjaman()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            String query = "Select * From peminjaman";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                
            }
            return dataTable;
        }

        public void fillDataPeminjaman()
        {
            dgvDataPeminjam.DataSource = getDataPeminjaman();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MeminjamBuku_Load(object sender, EventArgs e)
        {
            fillDataPeminjaman();
            btnReset.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tbJudulBuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelJudulBuku_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbLibraryId.Text == "" || tbNamaPeminjam.Text == "" || tbIdBuku.Text == "" || tbJudulBuku.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                MySqlCommand cmd;
                conn.Open();

                DateTime dateTime = DateTime.Now;
                dateTime.ToString("yyyy-MM-dd");
                
                try
                {
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into peminjaman(libraryId, namaPeminjam, id_buku, namaBuku, tgl_pinjam) values(@LibId, @namaPeminjam, @idBuku, @namaBuku, @tglPinjam)";
                    cmd.Parameters.AddWithValue("@LibId", tbLibraryId.Text);
                    cmd.Parameters.AddWithValue("@namaPeminjam", tbNamaPeminjam.Text);
                    cmd.Parameters.AddWithValue("@idBuku", tbIdBuku.Text);
                    cmd.Parameters.AddWithValue("@namaBuku", tbJudulBuku.Text);
                    cmd.Parameters.AddWithValue("@tglPinjam", dateTime);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Berhasil meminjam buku");
                    dgvDataPeminjam.Columns.Clear();
                    dataTable.Clear();
                    fillDataPeminjaman();
                    resetKolomPeminjam();
                } catch
                {

                }
                
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvDataPeminjam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void resetKolomPeminjam()
        {
            tbLibraryId.Text = "";
            tbNamaPeminjam.Text = "";
            tbIdBuku.Text = "";
            tbJudulBuku.Text = "";
        }

        private void dgvDataPeminjam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbLibraryId.Text = dgvDataPeminjam.SelectedRows[0].Cells[0].Value.ToString();
            tbNamaPeminjam.Text = dgvDataPeminjam.SelectedRows[0].Cells[1].Value.ToString();
            tbIdBuku.Text = dgvDataPeminjam.SelectedRows[0].Cells[2].Value.ToString();
            tbJudulBuku.Text = dgvDataPeminjam.SelectedRows[0].Cells[3].Value.ToString();

            tbLibraryId.Enabled = false;
            tbNamaPeminjam.Enabled = false;
            tbIdBuku.Enabled = false;
            tbJudulBuku.Enabled = false;

            btnReset.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetKolomPeminjam();
            tbLibraryId.Enabled = true;
            tbNamaPeminjam.Enabled = true;
            tbIdBuku.Enabled = true;
            tbJudulBuku.Enabled = true;
            btnReset.Enabled = false;
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            conn.Open();

            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "delete from peminjaman where id_buku = @idBuku AND libraryId = @LibId";
                cmd.Parameters.AddWithValue("@LibId", tbLibraryId.Text);
                cmd.Parameters.AddWithValue("@idBuku", tbIdBuku.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Berhasil mengembalikan buku");
                dgvDataPeminjam.Columns.Clear();
                dataTable.Clear();
                fillDataPeminjaman();
                resetKolomPeminjam();
            }
            catch
            {

            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Dashboard back = new Dashboard();
            back.Show();
            this.Hide();
        }
    }
}
