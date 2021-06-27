using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TugasBesar_KPL
{
   
    public partial class Login : Form
    { 
        List<Pengguna> listUser = new List<Pengguna>();
        Pengguna user = new Pengguna();
        DaftarAkun akun = new DaftarAkun();
        public Login()
        {
            InitializeComponent();
            getData();
        }

        public void getData()
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                listUser[i].getLibId().ToString();
                listUser[i].getNama().ToString();
                listUser[i].getEmail().ToString();
                listUser[i].getNoHP().ToString();
                listUser[i].getPassword().ToString();
            }
        }
        public Boolean ValidLogin()
        {
            String libid = null;
            String pass = null;
            bool Loginvalid = false;

            for (int i = 0; i < listUser.Count; i++)
            {
                if(listUser[i].getLibId().ToString() == tbLibraryId.Text && listUser[i].getPassword().ToString() == tbPassword.Text)
                {
                    libid = tbLibraryId.Text;
                    pass = tbPassword.Text;
                }
                else
                {
                    libid = null;
                    pass = null;
                }
            }
            
            if ( libid == tbLibraryId.Text && pass == tbPassword.Text)
            {
                Loginvalid = true;
            }
            else
            {
                Loginvalid = false;
            }

            return Loginvalid;
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            DaftarAkun daftar = new DaftarAkun();
            daftar.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(ValidLogin() == true)
            {
                MessageBox.Show("Berhasil Login");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }else if(ValidLogin() == false)
            {
                MessageBox.Show("Gagal Login");

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
