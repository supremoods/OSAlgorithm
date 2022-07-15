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
    public partial class sstfAlgo : Form
    {

        int[] arr = new int[100];
        int diskSize;
        int qSize;
        int head;
        int[] sequence;
        int totalSeekCount;
        public sstfAlgo()
        {
            InitializeComponent();
        }

        private void sstfAlgo_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(panel1);
     
        }

        public void getData()
        {



            diskSize = int.Parse(getDiskSize.Text);

            qSize = int.Parse(getSizeTrackNumber.Text);

            geTrackInput();

            head = int.Parse(gethead.Text);

            shortestSeekTimeFirst(arr, head);
         
        }

        private void geTrackInput()
        {
            int i = 0;
            string[] separators = new string[] { ",", " " };
            string track = getTrackNumber.Text;


            foreach (string numberRef in track.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                arr[i] = int.Parse(numberRef);
                Console.WriteLine(arr[i]);
                i++;
            }


            i = 0;

        }

        public void shortestSeekTimeFirst(int[] request,
                                               int head)

        {
            if (request.Length == 0)
                return;

            // create array of objects of class node
            node[] diff = new node[request.Length];


            for (int i = 0; i < qSize; i++)

                diff[i] = new node();

            // count total number of seek operation
            int seek_count = 0;


            int[] seek_sequence = new int[request.Length + 1];

            for (int i = 0; i < qSize; i++)
            {

                seek_sequence[i] = head;
                calculateDifference(request, head, diff);

                int index = findMin(diff);

                diff[index].accessed = true;


                seek_count += diff[index].distance;


                head = request[index];
            }

            // for last accessed track
            seek_sequence[seek_sequence.Length - 1] = head;

            Console.WriteLine("Total number of seek operations = "
                     + seek_count);

            totalSeekCount = seek_count;

            Console.WriteLine("Seek Sequence is");
            sequence = new int[qSize+1];
            // print the sequence
            for (int i = 0; i < qSize+1; i++)
            {
                Console.WriteLine(seek_sequence[i]);
                sequence[i] = seek_sequence[i];
            }

            sequence[qSize] = seek_sequence[seek_sequence.Length - 1];
        }

        public void calculateDifference(int[] queue, int head, node[] diff)
        {
            for (int i = 0; i < qSize; i++)
                diff[i].distance = Math.Abs(queue[i] - head);
        }

        // find unaccessed track which is at minimum distance from head
        public int findMin(node[] diff)
        {
            int index = -1, minimum = int.MaxValue;

            for (int i = 0; i < qSize; i++)
            {
                if (!diff[i].accessed && minimum > diff[i].distance)
                {

                    minimum = diff[i].distance;
                    index = i;
                }
            }
            return index;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            
            emptyTextBox();
            int countforString = 0;

            string[] separators = new string[] { ",", " " };
            string track = getTrackNumber.Text;

            foreach (string numberRef in track.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                countforString++;
            }

            if (string.IsNullOrEmpty(gethead.Text) || string.IsNullOrEmpty(getDiskSize.Text) || string.IsNullOrEmpty(gethead.Text))
            {
                checkEmpty();
            }
            else if (countforString > int.Parse(getSizeTrackNumber.Text))
            {
                trackValidation.Visible = true;
                trackValidation.Text = "Your Input is out of Range";

            }
            else if (countforString < int.Parse(getSizeTrackNumber.Text))
            {
                trackValidation.Visible = true;

                trackValidation.Text = "Please add " + (int.Parse(getSizeTrackNumber.Text) - countforString) + " more track(s)";

            }
            else
            {
                setSequence.Text = "";
                setTotal.Text = "";
                getData();
                graph();
                guna2Transition1.ShowSync(guna2Panel2);
                guna2Transition2.ShowSync(guna2Panel1);
                setTotal.Text = totalSeekCount.ToString();
                emptyTextBox();
            }

       
            
        }

        private void graph()
        {
            int count = 0;
            Bunifu.DataViz.WinForms.DataPoint dt;

            dt = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

           // dt.addLabely(count.ToString(), head.ToString());
       
            for (int i = 0; i < sequence.Length; i++)
            {

                dt.addLabely(count.ToString(), sequence[i].ToString());
                setSequence.Text += sequence[i].ToString() + " ";
                count++;

            }


            canvas.addData(dt);
            bunifuDataViz1.Render(canvas);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            diskScheduling ds = new diskScheduling();
            ds.Show();
            this.Close();
        }
        private void emptyTextBox()
        {
            trackValidation.Text = "";
            diskSizeValidation.Text = "";
            headValidation.Text = "";
        
        }

        private void checkEmpty()
        {

            emptyTextBox();


            if (string.IsNullOrEmpty(getTrackNumber.Text))
            {
                trackValidation.Visible = true;
                trackValidation.Text = "Input track Number";

            }

            if (string.IsNullOrEmpty(getDiskSize.Text))
            {
                diskSizeValidation.Visible = true;
                diskSizeValidation.Text = "Input Disk Size Number";
            }

            if (string.IsNullOrEmpty(gethead.Text))
            {
                headValidation.Visible = true;
                headValidation.Text = "Input Initial Head Number";
            }



        }
        private void getDiskSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gethead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void getTrackNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    public class node
    {
        // represent difference between head position and track number
        public int distance = 0;

        // true if track has been accessed
        public Boolean accessed = false;
    }



}
