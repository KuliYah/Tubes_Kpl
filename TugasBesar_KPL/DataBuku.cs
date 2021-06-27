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
    public partial class DataBuku : Form
    {
        public DataBuku()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTsubmit_Click(object sender, EventArgs e)
        {
            string[] baris = new string[4];
            ListViewItem item;

            baris[0] = TBidbuku.Text;
            baris[1] = TBjudulbuku.Text;
            baris[2] = TBpenerbit.Text;
            baris[3] = TBstock.Text;

            item = new ListViewItem(baris);
            LVdatabuku.Items.Add(item);

            
        }

        private void LVdatabuku_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
