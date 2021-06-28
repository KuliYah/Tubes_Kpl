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
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable ListBuku = new DataTable();
        MySqlCommand cmd = new  MySqlCommand();

        public DataBuku()
        {
            InitializeComponent();
            DGVdatabuku.DataSource = getDataBuku();
           
        }

        public DataTable getDataBuku()
        {

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
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }



        private void BTsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin ADD data?", "Add Data", button);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO buku (id_buku, judul_buku, penerbit, stok) VALUES('" + TBidbuku.Text + "','" + TBjudulbuku.Text + "','" + TBpenerbit.Text + "','" + TBstock.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Add");
                    DGVdatabuku.DataSource = getDataBuku();
                }
                else
                {
                    //Do Nothing
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
