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


        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable ListBuku = new DataTable();
        MySqlCommand cmd = new  MySqlCommand();

        private DataSet ds;
        private MySqlDataAdapter da;


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
            nextPosisi = AutomataDashboard.State.DASHBOARD;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();
        }



        private void BTsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin ingin submit data?", "submit Data", button);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO buku (id_buku, judul_buku, penerbit, stok) VALUES('" + TBidbuku.Text + "','" + TBjudulbuku.Text + "','" + TBpenerbit.Text + "','" + TBstock.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil submit");
                    DGVdatabuku.DataSource = getDataBuku();
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
            BTsubmit.Visible = false;

            DataGridViewRow row = this.DGVdatabuku.Rows[e.RowIndex];
            TBidbuku.Text = row.Cells[0].Value.ToString();
            TBjudulbuku.Text = row.Cells[1].Value.ToString();
            TBpenerbit.Text = row.Cells[2].Value.ToString();
            TBstock.Text = row.Cells[3].Value.ToString();

        }

        private void BTback_Click(object sender, EventArgs e)
        {
            BTsubmit.Visible = true;
            TBidbuku.Text = "";
            TBjudulbuku.Text = "";
            TBpenerbit.Text = "";
            TBstock.Text = "";

        }

        private void BTcari_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                cmd = new MySqlCommand("select *from buku where judul_buku like '%" + TBcari.Text + "%' ", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "buku");
                DGVdatabuku.DataSource = ds;
                DGVdatabuku.DataMember = "buku";

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
    }
}
