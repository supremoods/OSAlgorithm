using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace OSAlgorithms
{
    public partial class diskScheduling : Form
    {
        public diskScheduling()
        {
            InitializeComponent();



        }

        private void diskExitbtn_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();
        }

        private void sstfbtn_Click(object sender, EventArgs e)
        {
            sstfAlgo st = new sstfAlgo();
            st.Show();
            this.Close();
        }

        private void hoverSSTF(object sender, EventArgs e)
        {
     
            guna2Transition1.ShowSync(sstf_txt);
            guna2Transition1.ShowSync(sstf_line);
            guna2Transition1.HideSync(cScan_txt);
            guna2Transition1.HideSync(cScan_line);

        }

        private void hoverCscan(object sender, EventArgs e)
        {

            guna2Transition1.Show(cScan_txt);
            guna2Transition1.Show(cScan_line);
            //   guna2Transition1.ShowSync(cScan_line);
            guna2Transition1.HideSync(sstf_txt);
            guna2Transition1.HideSync(sstf_line);
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void diskScheduling_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(label3);
            guna2Transition1.ShowSync(guna2Separator3);

        }

        private void cScanbtn_Click(object sender, EventArgs e)
        {
            cscanAlgo cs = new cscanAlgo();
            cs.Show();
            this.Hide();
        }
    }
}
