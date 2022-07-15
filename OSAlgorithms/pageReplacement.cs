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
    public partial class pageReplacement : Form
    {
      

        public pageReplacement()
        {
            InitializeComponent();
        }



 

        private void pageReplacement_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(label1);
            guna2Transition1.ShowSync(guna2Separator1);
        }

        private void lru_Click(object sender, EventArgs e)
        {
            lruAlgo lru = new lruAlgo();
            lru.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {

            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();

        }

   

        private void optimalHover(object sender, EventArgs e)
        {

            guna2Transition1.ShowSync(optimal_line);
            guna2Transition1.ShowSync(optimalCircle);
            guna2Transition1.ShowSync(label3);
            guna2Transition1.HideSync(lruLine);
            guna2Transition1.HideSync(lruCircle);
            guna2Transition1.HideSync(label2);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();
        }

        private void lruHover(object sender, EventArgs e)
        {
  
            guna2Transition1.ShowSync(lruLine);
            guna2Transition1.ShowSync(lruCircle);
            guna2Transition1.ShowSync(label2);
            guna2Transition1.HideSync(optimal_line);
            guna2Transition1.HideSync(optimalCircle);
            guna2Transition1.HideSync(label3);

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            OSAlgo home = new OSAlgo();
            home.Show();
            this.Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void optimal_Click(object sender, EventArgs e)
        {
            optimalAlgo opt = new optimalAlgo();
            opt.Show();
            this.Close();
            
        }
    }
}
