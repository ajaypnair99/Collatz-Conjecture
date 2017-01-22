using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;

namespace CollatzConjucture
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        BigInteger SeriesEndInput, SeriesStartInput;


        #region Compute Button handler for click
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            #region Series Start Checking
            //BigInteger SeriesStartInput;

            if (String.IsNullOrEmpty(SeriesStart.Text) || SeriesStart.Text == "Starting Number")
            {
                LoglblF2.Text += "Enter a starting Series, default set to 7";
                SeriesStartInput = 7;

            }
            else
            {
                SeriesStartInput = BigInteger.Parse(SeriesStart.Text);
            }

            if (SeriesStartInput < 0)
            {
                SeriesStartInput = ~SeriesStartInput + 1;
            }
            #endregion

            #region Series End Checking
            
            if (String.IsNullOrEmpty(SeriesEnd.Text) || SeriesStart.Text == "Ending Number")
            {
                LoglblF2.Text += "Enter a Ending Series, default set to 7";
                SeriesEndInput = 7;

            }
            else
            {
                SeriesEndInput = BigInteger.Parse(SeriesEnd.Text);
            }

            if (SeriesEndInput < 0)
            {
                SeriesEndInput = ~SeriesEndInput + 1;
            }
            #endregion

            #region Thred Caller
            Thread Caller = new Thread(new ThreadStart(Calc));
            Caller.Start();
            #endregion


        }

        #endregion


        #region Calc
        void Calc()
        {
                BigInteger counter, Result, steps = 0;
                counter = SeriesStartInput;
                Result = counter;
                var watch = Stopwatch.StartNew();
                for (counter = SeriesStartInput; counter <= SeriesEndInput; counter++) //change the counter before comitting
                {
                    Result = SeriesStartInput;
                    while (Result != 1) // loop will run till the result equals 1, after that it will loop as 4 , 2 ,1 so its of no use after 1
                    {
                        if (Result % 2 == 0)
                        {
                            Result = Result / 2;//dividing the result by 2

                        }
                        else if (Result % 2 != 0) // if not even
                        {
                            Result = (3 * Result) + 1; // Collatz Conjecture , equation
                        }

                        steps++; // incrementing steps
                    }
                    SeriesStartInput++; // incrementing input for next number in result
                }
                watch.Stop();
                //MessageBox.Show(Convert.ToString(steps));
                var elapsedtime = watch.ElapsedMilliseconds;
            LoglblF2.Text += "\nTime taken : " + elapsedtime;
            LoglblF2.Text += "\nSteps taken : " + steps;

        }
        #endregion


    }
}



    

