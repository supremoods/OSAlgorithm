using System;
using System.Collections;
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
    public partial class lruAlgo : Form
    {
        int frameSize = 0;          //rows
        int Size_of_String = 0;     //columns
        int[] refString;
        int countGlobal = 0;
        int[,] outputData;

        private int num_frames;
        private int num_pages;
        private int[] memory;
        private int[] references;
        private int counter = 0;
        private int[] time;
        private int flag1;
        private int flag2;
        private int pos;
        private int faults = 0;
        private int hits = 0;
        private float hitRate;
        private float faultRate;
        private int[,] memoryDisplay;

       // private bool checkFull = false; // check if memory is full


        public void LRU(int num_frames, int[] references, int num_pages)
        {
            this.num_frames = num_frames;
            this.references = references;
            this.num_pages = num_pages;
            memoryDisplay = new int[num_pages, num_frames]; ;
            time = new int[num_frames];
            memory = new int[num_frames];
            calculateLRU();
            countGlobal = 0;
            displayMemory();
        }
        public int findLRU(int[] time, int n)
        {
            int i, minimum = time[0], pos = 0;

            for (i = 1; i < n; ++i)
            {
                if (time[i] < minimum)
                {
                    minimum = time[i];
                    pos = i;
                }
            }
            return pos;
        }
        public void calculateLRU()
        {

            for (int i = 0; i < num_frames; ++i)
            {
                memory[i] = -1;
            }

            for (int i = 0; i < num_pages; ++i)
            {
                flag1 = flag2 = 0;

                for (int j = 0; j < num_frames; ++j)
                {
                    if (memory[j] == references[i])
                    {
                        counter++;  
                        time[j] = counter;
                        flag1 = flag2 = 1;
                        break;
                    }
                }

                if (flag1 == 0)
                {
                    for (int j = 0; j < num_frames; ++j)
                    {
                        if (memory[j] == -1)
                        {
                            counter++;
                            faults++;
                            memory[j] = references[i];
                            time[j] = counter;
                            flag2 = 1;
                            break;
                        }
                    }
                }

                if (flag2 == 0)
                {
                    pos = findLRU(time, num_frames);
                    counter++;
                    faults++;
                    memory[pos] = references[i];
                    time[pos] = counter;
                }

                Console.WriteLine();

                for (int j = 0; j < num_frames; ++j)
                {

                    Console.Write(" " + memory[j] + " \t");
                    outputData[j, countGlobal] = memory[j];
                }
                countGlobal++;
            }

        }

        private void displayMemory()
        {

            guna2Panel1.Visible = false;
            //-------------MEMORY DISPLAY-------------//

            hits = Math.Abs(faults - num_pages);
            hitRate = ((float)hits / num_pages) * 100;
            faultRate = ((float)faults / num_pages) * 100;
            //-------------OUTPUT-------------//

            guna2Transition2.ShowSync(guna2Panel1);
            Console.WriteLine();
            Console.WriteLine("Number of frames: " + num_frames);
            Console.Write("Reference String: ");
            for (int i = 0; i < num_pages; i++)
                Console.Write(references[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Number of hits: " + hits);
            setHit.Text = hits.ToString();
            Console.WriteLine("Number of faults: " + faults);
            setFaults.Text = faults.ToString();
            Console.WriteLine("Hit ratio: " + string.Format("{0:0.##}", hitRate));
            setHitRate.Text = hitRate.ToString() + "%";
            Console.WriteLine("Fault ratio: " + string.Format("{0:0.##}", faultRate));
            setFaultRate.Text = faultRate.ToString() + "%";

            hits = 0;
            faults = 0;

        }

        public lruAlgo()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            pageReplacement pr = new pageReplacement();
            pr.Show();
            this.Close();
        }



        private void getTheRefString()
        {
            int i = 0;
            string[] separators = new string[] { ",", " " };
            string reference = getRefString.Text;


            foreach (string numberRef in reference.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                refString[i] = int.Parse(numberRef);
                Console.WriteLine(refString[i]);
                i++;
            }


            i = 0;

        }
        private void getLRUAlgoData()
        {
            Size_of_String = int.Parse(getStringSize.Text);
            refString = new int[Size_of_String];
            frameSize = int.Parse(no_Of_frames.Text);

            getTheRefString();
            outputData = new int[frameSize, Size_of_String];

            LRU(frameSize, refString, Size_of_String);

            DataTable dt = new DataTable("Summary");

            dt.Columns.Add("f"); ;
            for (int i = 0; i < Size_of_String + 1; i++)
            {
                dt.Columns.Add((i).ToString()); ;
            }

            /*      for (int i = 2; i < dt.Columns.Count; i++)
                  {
                      dt.Columns[i].AllowDBNull = false;
                  }
      */

            for (int j = 0; j < frameSize + 1; j++)
            {
                DataRow dr = dt.NewRow();
                if (j == 0)
                {
                    for (int i = 2; i < refString.Length + 2; i++)
                    {
                        dr[i] = refString[i - 2];

                    }
                }
                else
                {
                    dr[0] = j;
                    for (int i = 2; i < refString.Length + 2; i++)
                    {
                        if (outputData[j - 1, i - 2] == -1)
                        {
                            dr[i] = " ";
                        }
                        else
                        {
                            dr[i] = outputData[j - 1, i - 2];
                        }


                    }
                }


                dt.Rows.Add(dr);

            }



            data_tbl.DataSource = dt;
        }

        private void lruAlgo_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(panel1);
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            emptyTextBox();
            int countforString = 0;
            string[] separators = new string[] { ",", " " };
            string reference = getRefString.Text;


            foreach (string numberRef in reference.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                countforString++;
            }


            if (string.IsNullOrEmpty(no_Of_frames.Text) || string.IsNullOrEmpty(getRefString.Text) )
            {
                checkEmpty();
            }
            else if(countforString > int.Parse(getStringSize.Text))
            {
                ReferenceString.Visible = true;
                ReferenceString.Text = "Your Input is out of Range";
            }
            else if (countforString < int.Parse(getStringSize.Text))
            {
                ReferenceString.Visible = true;
                ReferenceString.Text = "Please add " + (int.Parse(getStringSize.Text) - countforString) + " more String(s)";
            }
            else
            {
                data_tbl.Visible = false;
                getLRUAlgoData();
                guna2Transition1.ShowSync(data_tbl);
            }
           
        }

        private void checkEmpty()
        {

            emptyTextBox();



            if (string.IsNullOrEmpty(no_Of_frames.Text))
            {
                frameValidation.Visible = true;
                frameValidation.Text = "Input Number of Frames";

            }

            if (string.IsNullOrEmpty(getRefString.Text))
            {
                ReferenceString.Visible = true;
                ReferenceString.Text = "Input Reference String";
            }

           


        }

        private void emptyTextBox()
        {
            frameValidation.Text = "";
            ReferenceString.Text = "";
        }


        private void getRefString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void no_Of_frames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
