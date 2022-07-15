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
    public partial class OSAlgo : Form
    {
       
 

        public OSAlgo()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            pageReplacement pr = new pageReplacement() ;
            pr.Show();
            this.Hide();
            
        }

 
        private void btn_show_Click(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            btn_hide.Visible = true;
            guna2GradientPanel1.Visible = false;
            guna2GradientPanel1.Width = 331;
            guna2Transition1.ShowSync(guna2GradientPanel1);


        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            guna2GradientPanel1.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible = true;
            guna2GradientPanel1.Width = 52;
            guna2Transition1.ShowSync(guna2GradientPanel1);
        }

        //dev
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            dev d = new dev();
            d.Show();
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            diskScheduling ds = new diskScheduling();
            ds.Show();
            this.Hide();
          

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Transition2.ShowSync(label1);
        }
    }
}
