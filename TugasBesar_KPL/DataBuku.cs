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
    public partial class DataBuku : Form
    {
        AutomataDashboard.State posisi = AutomataDashboard.State.DATABUKU, nextPosisi;
    // connect mysql
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable ListBuku = new DataTable();
        MySqlCommand cmd = new MySqlCommand();

        private DataSet ds;
        private MySqlDataAdapter da;



        public DataBuku()
        {
            InitializeComponent();
            dgvDataBuku.DataSource = getDataBuku();
            
            
        }

        public DataTable getDataBuku()
        {
            // mengambil data dari database dan menampilkannya di dbgrid
            ListBuku.Reset();
            ListBuku = new DataTable();
            String query = "Select * From buku";
            using (cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                ListBuku.Load(reader);
            }
            conn.Close();
            return ListBuku;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // penggunaan automata
            nextPosisi = AutomataDashboard.State.DASHBOARD;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();
        }



        private void BTsubmit_Click(object sender, EventArgs e)
        {
            // penggunaan defensive programmming
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin submit data?", "submit Data", button);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO buku (id_buku, judul_buku, penerbit, stok) VALUES('" + tbIdBuku.Text + "','" + tbJudulBuku.Text + "','" + tbPenerbit.Text + "','" + tbStock.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil submit");
                    dgvDataBuku.DataSource = getDataBuku();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVdatabuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // menampilkan data saat tabel di klik
            btnSubmit.Visible = false;

            DataGridViewRow row = this.dgvDataBuku.Rows[e.RowIndex];
            tbIdBuku.Text = row.Cells[0].Value.ToString();
            tbJudulBuku.Text = row.Cells[1].Value.ToString();
            tbPenerbit.Text = row.Cells[2].Value.ToString();
            tbStock.Text = row.Cells[3].Value.ToString();

        }

        private void BTback_Click(object sender, EventArgs e)
        {
            // membuat semua textbox menjadi kosong
            btnSubmit.Visible = true;
            tbIdBuku.Text = "";
            tbJudulBuku.Text = "";
            tbPenerbit.Text = "";
            tbStock.Text = "";

        }

       

        private void BTcari_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                cmd = new MySqlCommand("select *from buku where judul_buku like '%" + tbCari.Text + "%' ", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "buku");
                dgvDataBuku.DataSource = ds;
                dgvDataBuku.DataMember = "buku";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            } 

          
          
        }



        private void button1_Click_1(object sender, EventArgs e)
        {


            DataPengembalian<int> hitung = new DataPengembalian<int>();
            hitung.Pengembalian = dgvDataBuku.RowCount - 1;
            lblBanyakData.Text = hitung.Pengembalian.ToString();
        }

        private void DataBuku_Load(object sender, EventArgs e)
        {

            DataPengembalian<int> hitung = new DataPengembalian<int>();
            hitung.Pengembalian = dgvDataBuku.RowCount - 1;
            lblBanyakData.Text = hitung.Pengembalian.ToString();
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {

        }

        class DataPengembalian<T>
        {
            public T Pengembalian { get; set; }
        }
    }

}



