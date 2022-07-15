using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Text.RegularExpressions;

namespace OSAlgorithms
{
    public partial class cscanAlgo : Form
    {
        static int headtobePrint;
        static int size;
        static int disk_size;
        static List<int> left = new List<int>();
        static List<int> right = new List<int>();
        static List<int> seek_sequence = new List<int>();
        int[] arr;
        int head;
        int flag;
        int totalSeekCount = 0;

        public cscanAlgo()
        {
            InitializeComponent();
        }



        private void cscanAlgo_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(panel1);

        }

        public void getData()
        {



            disk_size = int.Parse(getDiskSize.Text);

            size = int.Parse(getSizeTrackNumber.Text);

            arr = new int[size];

            geTrackInput();

            head = headtobePrint = int.Parse(gethead.Text);



            if (getflag.Text == "Left")
            {

                flag = 1;
                towardsZero(arr, head);

            }
            if (getflag.Text == "Right")
            {

                flag = 0;
                towardsHigher(arr, head);
            }



        }


        public static void display(int seek_count)
        {
            Console.WriteLine("Total number of seek "
                    + "operations = " + seek_count);

            Console.WriteLine("Seek Sequence is");
            Console.WriteLine(headtobePrint);
            for (int i = 0; i < seek_sequence.Count; i++)
            {
                Console.WriteLine(seek_sequence[i]);
            }
        }
        public void towardsHigher(int[] arr, int head)
        {
            int seek_count = 0;
            int distance, cur_track;
            // Appending end values which has to be visited before reversingthe direction
            left.Add(0);
            right.Add(disk_size);

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < head)
                    left.Add(arr[i]);
                if (arr[i] > head)
                    right.Add(arr[i]);
            }


            // Sorting left and right list
            left.Sort();
            right.Sort();

            for (int i = 0; i < right.Count; i++)
            {
                cur_track = right[i];

                // Appending current track to seek sequence
                seek_sequence.Add(cur_track);

                // Calculate absolute distance
                distance = Math.Abs(cur_track - head);

                // Increase the total count
                seek_count += distance;

                // Accessed track is now new head
                head = cur_track;
            }

            // Once reached the right end jump to the beggining.
            head = 0;

            // adding seek count for head returning from 199 to
            // 0
            seek_count += (disk_size);

            // Now service the requests again which are left.
            for (int i = 0; i < left.Count; i++)
            {
                cur_track = left[i];

                // Appending current track to seek sequence
                seek_sequence.Add(cur_track);

                // Calculate absolute distance
                distance = Math.Abs(cur_track - head);

                // Increase the total count
                seek_count += distance;

                // Accessed track is now the new head
                head = cur_track;
            }

            totalSeekCount = seek_count;
            display(seek_count);

        }



        //Method for the direction towards zero value
        public void towardsZero(int[] arr, int head)
        {

            int seek_count = 0;
            int distance, cur_track;

            // Appending end values which has to be visitedbefore reversing the direction
            left.Add(disk_size);
            right.Add(0);



            for (int i = 0; i < size; i++)
            {
                if (arr[i] < head)
                    right.Add(arr[i]);
                if (arr[i] > head)
                    left.Add(arr[i]);
            }

            // Sorting left and right list and reverse
            left.Sort();
            right.Sort();
            left.Reverse();
            right.Reverse();


            for (int i = 0; i < right.Count; i++)
            {
                cur_track = right[i];
                Console.WriteLine("This is right");
                // Appending current track to seek sequence
                seek_sequence.Add(cur_track);
                Console.Write(cur_track + " - " + head);
                // Calculate absolute distance
                distance = Math.Abs(cur_track - head);
                Console.WriteLine(" = " + distance);
                // Increase the total count
                seek_count += distance;

                // Accessed track is now new head
                head = cur_track;

            }
            head = 0;
            seek_count += (0);

            for (int i = 0; i < left.Count; i++)
            {
                cur_track = left[i];
                //  Console.WriteLine("This is left");
                // Appending current track to
                // seek sequence
                seek_sequence.Add(cur_track);
                //Console.Write(cur_track + " - " + head);
                // Calculate absolute distance
                distance = Math.Abs(cur_track - head);
                // Console.WriteLine(" = " + distance);
                // Increase the total count
                seek_count += distance;

                // Accessed track is now the new head
                head = cur_track;
            }
            totalSeekCount = seek_count;
            display(seek_count);
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
            Console.WriteLine(arr.Length);

            i = 0;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            diskScheduling ds = new diskScheduling();
            ds.Show();  
            this.Close();

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



            if (string.IsNullOrEmpty(gethead.Text) || string.IsNullOrEmpty(getDiskSize.Text) || string.IsNullOrEmpty(gethead.Text) || string.IsNullOrEmpty(getflag.Text))
            {
                checkEmpty();
            } else if (countforString > int.Parse(getSizeTrackNumber.Text))
            {
                trackValidation.Visible = true;
                trackValidation.Text = "Your Input is out of Range";

            } else if (countforString < int.Parse(getSizeTrackNumber.Text))
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
                clearAllList();
                emptyTextBox();
            }

           


        }
        private void clearAllList()
        {
            seek_sequence.Clear();
            left.Clear();
            right.Clear();
            totalSeekCount = 0;

        }
        private void graph()
        {
            int count = 0;
            Bunifu.DataViz.WinForms.DataPoint dt;

            dt = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_line);
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            dt.addLabely(count.ToString(), headtobePrint.ToString());
            setSequence.Text += headtobePrint.ToString() + " ";
            count++;
            for (int i = 0; i < seek_sequence.Count; i++)
            {

                dt.addLabely(count.ToString(), seek_sequence[i].ToString());
                setSequence.Text += seek_sequence[i].ToString() + " ";
                count++;

            }


            canvas.addData(dt);
            bunifuDataViz1.Render(canvas);
        }
        private void emptyTextBox(){
            trackValidation.Text = "";
            diskSizeValidation.Text = "";
            headValidation.Text = "";
            directionValidation.Text = "";
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

            if (string.IsNullOrEmpty(getflag.Text))
            {
                directionValidation.Visible = true;
                directionValidation.Text = "Choose Direction Number";

            }

           
        }

        private void getDiskSize_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gethead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
