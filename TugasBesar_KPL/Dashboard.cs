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
        AutomataDashboard.State posisi = AutomataDashboard.State.DASHBOARD, nextPosisi; // automata
       



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
            {

                Application.Exit();
            }
            else if (result == DialogResult.No) { }

           
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);

            this.Hide();
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            nextPosisi = AutomataDashboard.State.LOGOUT;
            AutomataDashboard.setPosisi(posisi, nextPosisi);

            const string message = "Apakah anda yakin ingin Melakukan Logout?";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)

            AutomataDashboard.posisiTransition(nextPosisi);
            
            this.Hide();

        }

        private void btnMeminjamBuku_Click(object sender, EventArgs e)
        {

            
            nextPosisi = AutomataDashboard.State.MEMINJAMBUKU;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);


            this.Hide();

        }

        

        private void btnDataBuku_Click(object sender, EventArgs e)
        {
            nextPosisi = AutomataDashboard.State.DATABUKU;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();

        }

        private void btnPengembalianBuku_Click(object sender, EventArgs e)
        {
            nextPosisi = AutomataDashboard.State.PENGEMBALIAN;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();
        }
       

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            nextPosisi = AutomataDashboard.State.DATAPENGGUNA;
            AutomataDashboard.setPosisi(posisi, nextPosisi);
            AutomataDashboard.posisiTransition(nextPosisi);
            this.Hide();

        }
    }
}
