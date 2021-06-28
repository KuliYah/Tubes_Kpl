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
    public partial class PengembalianBuku : Form
    {


        //PENGGUNAAN AUTOMATA PADA BUTTON KEMBALI - I KOMANG DANDA PRIYOWITTESA 1302194017
        AutomataDashboard.State posisi = AutomataDashboard.State.PENGEMBALIAN, nextPosisi;

        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable dataTable1 = new DataTable();
        DataTable dataTable2 = new DataTable();
        public PengembalianBuku()
        {
            InitializeComponent();
        }
        public DataTable getDataPeminjaman()
        {
            dataTable1.Reset();
            dataTable1 = new DataTable();
            String query = "Select * From peminjaman";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable1.Load(reader);

            }
            return dataTable1;
        }

        public DataTable getDataPengembalian()
        {
            dataTable2.Reset();
            dataTable2 = new DataTable();
            String query = "Select * From pengembalian";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                conn.Open();

                MySqlDataReader reader = command.ExecuteReader();
                dataTable2.Load(reader);

            }
            return dataTable2;
        }

        public void fillDataPeminjaman()
        {
            dgvDataPeminjam.DataSource = getDataPeminjaman();
            conn.Close();
        }

        public void fillDataPengembalian()
        {
            dgvPengembalian.DataSource = getDataPengembalian();
            conn.Close();
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

        private void PengembalianBuku_Load(object sender, EventArgs e)
        {
            fillDataPeminjaman();
            fillDataPengembalian();
            btnReset.Enabled = false;
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
            //PENGGUNAAN DEFENSIVE PROGRAMMING - HANDLING EXCEPTION - I KOMANG DANDA PRIYOWITTESA 1302194017
            if (tbLibraryId.Text != "" && tbIdBuku.Text != "")
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
                    dataTable1.Clear();

                    dgvPengembalian.Columns.Clear();
                    dataTable2.Clear();

                    fillDataPengembalian();
                    fillDataPeminjaman();
                    resetKolomPeminjam();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("Library Id dan Id Buku kosong, tekan salah 1 row !");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHitungPengembalian_Click(object sender, EventArgs e)
        {
            //PENGGUNAAN GENERIC - I KOMANG DANDA PRIYOWITTESA 1302194017
            DataPengembalian<int> hitung = new DataPengembalian<int>();
            hitung.Pengembalian = dgvPengembalian.RowCount-1;
            RowPengembalian.Text = hitung.Pengembalian.ToString();
        }

        class DataPengembalian<T>
        {
            //PENGGUNAAN GENERIC - I KOMANG DANDA PRIYOWITTESA 1302194017
            public T Pengembalian { get; set; }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            //PENGGUNAAN AUTOMATA PADA BUTTON KEMBALI - I KOMANG DANDA PRIYOWITTESA 1302194017
            nextPosisi = AutomataDashboard.State.DASHBOARD;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();
        }
    }
}
