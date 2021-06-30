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
    //Rizky Naufal Alghifari
    public partial class Data_Pengguna : Form
    {
        
        //Init Variable
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; password=; database = tugasakhir");
        DataTable listPengguna = new DataTable();
        MySqlCommand cmd = new MySqlCommand();
        public static Data_Pengguna instance;
        private Data_Pengguna()
        {
            InitializeComponent();
            dgvDataPengguna.DataSource = getDataPengguna();
            setDisabled();
       
        }
       
        //Design Pattern
        public static Data_Pengguna GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Data_Pengguna();
            }
            return instance;
        }
        //Set Data Table
        public DataTable getDataPengguna()
        {
            
            listPengguna.Reset();
            listPengguna = new DataTable();
            String query = "Select * From member";
            using (cmd= new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                listPengguna.Load(reader);
            }
            conn.Close();
            return listPengguna;
        }
        //Defensive Programming
        public void AddMember(String libId)
        {
            libId = tbLibId.Text;
            conn.Open();
            cmd = new MySqlCommand("SELECT libraryId FROM member", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            if(libId == reader.ToString())
            {
                throw new ArgumentException();
            }
        }
        public void setTextBox(DataGridViewCellEventArgs e)
        {  
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDataPengguna.Rows[e.RowIndex];
                tbLibId.Text = row.Cells[0].Value.ToString();
                tbNama.Text = row.Cells[1].Value.ToString();
                tbEmail.Text = row.Cells[2].Value.ToString();
                tbNohp.Text = row.Cells[3].Value.ToString();
                tbPass.Text = row.Cells[4].Value.ToString();
            }

        }
        public void setDisabled()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            String libId = tbLibId.Text;
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin ADD data?", "Add Data", button);
                if (result == DialogResult.Yes)
                {
                    AddMember(libId);
                    conn.Open();
                    cmd = new MySqlCommand("INSERT INTO member (libraryId, nama, email, noHp, password) VALUES('" +tbLibId.Text +"','" + tbNama.Text + "','"+ tbEmail.Text + "','" + tbNohp.Text + "','" + tbPass.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Add");
                    dgvDataPengguna.DataSource = getDataPengguna();
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

        private void dgvDataPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnAdd.Enabled = false;
            label1.Enabled = false;
            tbLibId.Enabled = false;
            
            setTextBox(e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin UPDATE data?", "Update Data", button);
                if(result == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new MySqlCommand("UPDATE member SET nama= '" + tbNama.Text + "',email= '" + tbEmail.Text + "',noHp= '" + tbNohp.Text + "',password= '" + tbPass.Text + "' WHERE libraryId ='" + tbLibId.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Update");
                    dgvDataPengguna.DataSource = getDataPengguna();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            tbLibId.Text = "";
            tbNama.Text = "";
            tbEmail.Text = "";
            tbNohp.Text = "";
            tbPass.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons button = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah anda yakin DELETE data?", "Delete Data", button);
                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    cmd= new MySqlCommand("DELETE FROM member WHERE libraryId='"+tbLibId.Text+"'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Berhasil Delete");
                    dgvDataPengguna.DataSource = getDataPengguna();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void dgvDataPengguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnJumlah_Click(object sender, EventArgs e)
        {
            //PENGGUNAAN GENERIC 
            JumlahMember<int> hitung = new JumlahMember<int>();
            hitung.Member = dgvDataPengguna.RowCount - 1;
            row.Text = hitung.Member.ToString();
        }

        class JumlahMember<T>
        {
            //PENGGUNAAN GENERIC 
            public T Member { get; set; }
        }
    

        private void Data_Pengguna_Load(object sender, EventArgs e)
        {

        }
    }
}
