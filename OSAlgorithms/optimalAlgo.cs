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
    public partial class optimalAlgo : Form
    {
        int frameSize = 0;          //rows
        int Size_of_String = 0;     //columns
        int[] refString;
        int countGlobal = 0;
        int[,] outputData;


        private int faults = 0; //number of faults
        private int num_frames; //number of frames
        private int hits = 0; //number of hits
        private int num_pages = 0; //length of reference string
        private int marker = 0; // to check if = frames
        private int[] memory;
        private int[] references; //reference string
        private int[,] memoryDisplay;
        private bool checkFull = false; // check if memory is full
        private float faultRate;
        private float hitRate;

        public void Optimal(int num_frames, int[] references, int num_pages)
        {
            this.num_frames = num_frames;
            this.references = references;
            this.num_pages = num_pages;
            memoryDisplay = new int[num_pages, num_frames];
            memory = new int[num_frames];
            displayMemory();
        }

        public optimalAlgo()
        {
            InitializeComponent();
        }


        private void optimalAlgo_Load(object sender, EventArgs e)
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


            if (string.IsNullOrEmpty(no_Of_frames.Text) || string.IsNullOrEmpty(getRefString.Text))
            {
                checkEmpty();
            }
            else if (countforString > int.Parse(getStringSize.Text))
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
                getOptimalAlgoData();
                reset();
                guna2Transition1.ShowSync(data_tbl);
            }
        
           
        }

        private void getTheRefString()
        {
            int i = 0;
            string[] separators = new string[] { ",", " "};
            string reference = getRefString.Text;


            foreach (string numberRef in reference.Split(separators, StringSplitOptions.RemoveEmptyEntries))
            {
                refString[i] = int.Parse(numberRef);
                Console.WriteLine(refString[i]);
                i++;
            }
               
            
            i = 0;

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            pageReplacement pr = new pageReplacement();
            pr.Show();
            this.Close();
        }

        private void getOptimalAlgoData()
        {
            Size_of_String = int.Parse(getStringSize.Text);
            refString = new int[Size_of_String];
            frameSize = int.Parse(no_Of_frames.Text);

            getTheRefString();
            outputData = new int[frameSize,Size_of_String];


            Optimal(frameSize, refString, Size_of_String);

            DataTable dt = new DataTable("Summary");

            dt.Columns.Add("f"); ;
            for (int i = 0; i < Size_of_String+1; i++)
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
                        if(outputData[j - 1, i - 2] == -1)
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

   
        private void calculateOptimal()
        {
            for (int j = 0; j < num_frames; j++)
                memory[j] = -1;


            for (int i = 0; i < num_pages; i++)
            {
                int search = -1;
                for (int j = 0; j < num_frames; j++)
                {
                    if (memory[j] == references[i])
                    {
                        search = j;
                        hits++;
                        break;
                    }
                }
                if (search == -1)
                {
                    if (checkFull)
                    {
                        int[] temp = new int[num_frames];
                        bool[] tempMarker = new bool[num_frames];

                        for (int j = i + 1; j < num_pages; j++)
                        {
                            for (int k = 0; k < num_frames; k++)
                            {
                                if ((references[j] == memory[k]) && (tempMarker[k] == false))
                                {
                                    temp[k] = j;
                                    tempMarker[k] = true;
                                    break;
                                }
                            }
                        }
                        int position = temp[0]; //last number in reference string, if exists
                        marker = 0;
                        if (position == 0)
                            position = 200;
                        for (int j = 0; j < num_frames; j++)
                        {
                            if (temp[j] == 0)
                                temp[j] = 200;
                            if (temp[j] > position)
                            {
                                position = temp[j];
                                marker = j;
                            }
                        }
                    }
                    memory[marker] = references[i];
                    faults++;
                    if (!checkFull)
                    {
                        marker++;
                        if (marker == num_frames)
                        {
                            marker = 0;
                            checkFull = true;
                        }
                    }
                }
                //copying memory elements into the memory display array 
                //Array.Copy(memory, 0, memoryDisplay, 0, frames);
                Output(memory, num_frames, num_pages);
            }
            countGlobal = 0;
        }

        private void Output(int[] input, int height, int width)
        {

            int[,] output = new int[height, width];
            int[,] output2 = new int[height, width];
            int count = 0;
            Console.WriteLine("Number of input: " + input.Length);
            Console.WriteLine("Number of heigth: " + height);
            Console.WriteLine("Number of width: " + width);
            for (int i = 0; i < height; i++)

            {
               
                for (int j = 0; j < width; j++)

                {
                    if (count == input.Length) break;


                    output[i, j] = input[count];
                    outputData[j, countGlobal] = input[count];

                    

                    //System.out.printf("[%d][%d]= %d\n",i,j,output[i][j]);
                    Console.Write("   " + output[i, j] + "  |");

                    Console.Write("[" + i + "]" + "[" + j + "]" + "[" + count + "]");
                    count++;
                    // System.arraycopy(output,0,output2,0,width);


                }
                if (i % height != 0) break;
                Console.WriteLine();
                countGlobal++;
            }
            //for (int i = 0; i < height; i++)
            //{

            //    for (int j = 0; j < width; j++)
            //        Console.Write("   " + output[i, j] + "  |");
            //    Console.WriteLine();

            //}
        }
        private void displayMemory()
        {
            guna2Panel1.Visible = false;
            setHit.Text = "";
            setFaults.Text = "";
            setHitRate.Text = "";
            setFaultRate.Text = "";
            //-------------MEMORY DISPLAY-------------//


            calculateOptimal();

            for (int i = 0; i < frameSize; i++)
            {
                for (int j = 0; j < Size_of_String; j++)
                {
                    Console.Write(" " + outputData[i, j] + "  |");
                }
                Console.WriteLine();
            }

            /*
            for (int i = 0; i < frames; i++)
            {

                for (int j = 0; j < length; j++)
                   Console.Write(" %3d |", memoryDisplay[j,i]);
               Console.WriteLine();

            }
            /* for(int i =0; i<frames; i++)
            {
                System.out.printf(" %3d |",  tempMarker[i]);
                 System.out.println();

             }*/


           // guna2Panel1.Visible = true;
            guna2Transition2.ShowSync(guna2Panel1);

            //-------------OUTPUT-------------//
            hitRate = ((float)hits / num_pages) * (100);
            faultRate = ((float)faults / num_pages) * (100);

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
            setHitRate.Text = hitRate.ToString()+"%";
            Console.WriteLine("Fault ratio: " + string.Format("{0:0.##}", faultRate));
            setFaultRate.Text = faultRate.ToString()+"%";

 

        //   memory
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
        private void emptyTextBox()
        {
            frameValidation.Text = "";
            ReferenceString.Text = "";
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

        private void reset()
        {
            hits = 0;
            faults = 0;

            checkFull = false; // check if memory is full


            num_frames = 0; //number of frames

            num_pages = 0; //length of reference string
            marker = 0; // to check if = frames

            memory = new int [0];
            references = new int [0]; //reference string

        }
    }
}
