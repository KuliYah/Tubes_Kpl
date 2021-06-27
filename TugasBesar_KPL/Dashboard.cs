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
        Automata.State posisi = Automata.State.DASHBOARD, nextPosisi;
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
            //Profile menampilkan = new Profile();
            //menampilkan.Show();
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);

            this.Hide();
        }

        private void btnMeminjamBuku_Click(object sender, EventArgs e)
        {

            // MeminjamBuku menampilkan2 = new MeminjamBuku();
            //menampilkan2.Show();
            nextPosisi = Automata.State.MEMINJAMBUKU;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);


            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
            nextPosisi = Automata.State.LOGOUT;
            Automata.setPosisi(posisi, nextPosisi);

            const string message = "Apakah anda yakin ingin Melakukan Logout?";
            const string caption = "";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
               
            Automata.posisiTransition(nextPosisi);
            
            this.Hide();

        }

        private void btnDoaIbu_Click(object sender, EventArgs e)
        {

        }
    }
}
