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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MeminjamBuku_Load(object sender, EventArgs e)
        {
            fillDataPeminjaman();
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

        }
    }
}
