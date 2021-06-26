using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBesar_KPL
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string message = "Apakah anda yakin ingin keluar dari aplikasi?";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile menampilkan = new Profile();
            menampilkan.Show();
            this.Hide();
        }

        private void btnMeminjamBuku_Click(object sender, EventArgs e)
        {
            MeminjamBuku menampilkan2 = new MeminjamBuku();
            menampilkan2.Show();
            this.Hide();

        }

        private void btnLogout(object sender, EventArgs e)
        {
            const string message = "Apakah anda yakin ingin melakukan Logout?";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes);
            Login menampilkan3 = new Login();
            menampilkan3.Show();
            this.Hide();
            

            
        }
    }
}
