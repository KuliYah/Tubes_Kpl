using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Ihsan Asfari Hanifan -1302194105

//penggunaan automata, table-driven, dan defensive programming
namespace TugasBesar_KPL
{
    public partial class Login : Form
    {
        AutomataDashboard.State posisi = AutomataDashboard.State.LOGIN, nextPosisi;
        public Login()
        {
            InitializeComponent();
        }

        

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Apakah anda yakin ingin keluar dari aplikasi?";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else if(result == DialogResult.No){ }
        }


        string LibraryId, Password; // atribut

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Enum LibID = TableDrivenAdmin.LibraryId.admin; // pengambilan 
                LibraryId = LibID.ToString();
                Password = TableDrivenAdmin.getAdmin(TableDrivenAdmin.LibraryId.admin);


                if ((tbLibraryId.Text == LibraryId) && (tbPassword.Text == Password))
                {
                    MessageBox.Show("Selamat anda berhasil login");
                    nextPosisi = AutomataDashboard.State.DASHBOARD;
                    AutomataDashboard.setPosisi(posisi, nextPosisi);
                    AutomataDashboard.posisiTransition(nextPosisi);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Library id atau Password anda salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        


    }
}
