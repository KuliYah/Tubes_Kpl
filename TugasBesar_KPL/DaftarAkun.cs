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
    public partial class DaftarAkun : Form
    {
        List<Pengguna> listUser = new List<Pengguna>();
        Pengguna user = new Pengguna();

        public DaftarAkun()
        {
            InitializeComponent();
            getData();
        }

        public void EmptyTextBox()
        {
            tbLibId.Text = null;
            tbNama.Text = null;
            tbEmail.Text = null;
            tbNoHP.Text = null;
            tbPass.Text = null;
        }
        public void InputUser()
        {
            String libraryId = tbLibId.Text;
            String nama = tbNama.Text;
            String email = tbEmail.Text;
            String noHP = tbNoHP.Text;
            String pass = tbPass.Text;

            user = new Pengguna(libraryId, nama, email, noHP, pass);
            listUser.Add(user);
        }

        public void getData()
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                listUser[i].getLibId();
                listUser[i].getNama();
                listUser[i].getEmail();
                listUser[i].getNoHP();
                listUser[i].getPassword();
            }
        }
        public Boolean ValidasiSignUp()
        {
            bool valid = true;
            for (int i = 0; i < listUser.Count; i++)
            {
                if(listUser[i].getLibId().ToString() == tbLibId.Text)
                {
                    valid = false;
                }else
                {
                    valid = true;
                }
                
            }
            return valid;
        }

        private void DaftarAkun_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidasiSignUp() == true)
            {
                InputUser();
                MessageBox.Show("Berhasil Daftar Akun");
                EmptyTextBox();
            }
            else if (ValidasiSignUp() == false)
            {
                MessageBox.Show("Library Id sudah ada" +
                    " Anda gagal membuat akun");
                EmptyTextBox();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


    }
}
