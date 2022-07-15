using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSAlgorithms
{
    public partial class dev : Form
    {
        
        public dev()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();
        }

        private void dev_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(label1);
            guna2Transition1.ShowSync(guna2PictureBox1);
            guna2Transition1.ShowSync(label2);
            guna2Transition1.ShowSync(guna2PictureBox2);
            guna2Transition1.ShowSync(label3);
            guna2Transition1.ShowSync(guna2PictureBox4);
            guna2Transition1.ShowSync(label4);
            guna2Transition1.ShowSync(guna2PictureBox3);
            guna2Transition1.ShowSync(label5);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            this.Close();
            home.Show();
        }
    }
}
