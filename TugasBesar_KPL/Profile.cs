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
    public partial class Profile : Form
    {

        List<Pengguna> listUser = new List<Pengguna>();
        Pengguna user = new Pengguna();
        Dashboard tampilan = new Dashboard();
        public Profile()
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

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard tampil = new Dashboard();
            tampil.Show();
            this.Hide();
        }
    }
}
