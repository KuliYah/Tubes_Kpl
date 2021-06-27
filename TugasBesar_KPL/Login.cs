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
        //Init Variabel
        
        Admin user = new Admin();

        public Login()
        {
            InitializeComponent();
            AkunAdmin();
        }
        //Set Akun Admin
        public void AkunAdmin()
        {
            user = new Admin("admin", "admin123");
        }

        //Defensive Programming untuk login
        public void SignIn()
        {
            if (user.getLibId() != tbLibraryId.Text && user.getPassword() != tbPassword.Text)
            {
                throw new ArgumentException();
               
            }
            //berhasil login
                MessageBox.Show("Berhasil Login");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
