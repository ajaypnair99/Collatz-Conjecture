using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;

namespace CollatzConjucture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        BigInteger input,result; // Input takes input , and result is used for calculations


        //Compute Button
        private void ComputeButton_Click(object sender, EventArgs e)
        {
            input = BigInteger.Parse(InputNumberBox.Text);// converting the input from the textbox to biginteger

            //converting input to a postive intger 
            if (input < 0)
            {
                input = ~input + 1; // converting value of input to positive if the integer is negative
                
            }
            
            CollatzConjectureCalc(input); // calling the function and passing input as a value
        }

        //Benchmark Button
        private void BenchmarkButton_Click(object sender, EventArgs e)
        {
            CollatzConjectureBenchmark(); // calling benchmark function

        }

       
        //Collatz Conjecture checking function
        int CollatzConjectureCalc(BigInteger input)
        {
            result = input;// setting the value of result as input

            int steps =0; // initializing steps to 0

           // var watch = Stopwatch.StartNew();//initializing stop watch

            ResultLabel.Text = ""; // clearing the log label


            while(result!=1 )
            {
                //Checking if even 
                if (result % 2 == 0)
                {
                    result = result / 2;//dividing the result by 2

                } else if (result%2 != 0) // if not even
                {
                    result = (3 * result) + 1; // Collatz Conjecture , equation
                }
                
                steps++; // incrementing the steps
            }
           // watch.Stop(); // stopping the watch

            //var elapsedtime = watch.ElapsedMilliseconds; // setting elapsed time to the time taken to execute the steps

            ResultLabel.Text += "End Result = "+result; // displaying the result
            //ResultLabel.Text += "\nElapsed Time =" + elapsedtime; // displaying time elapsed
            ResultLabel.Text += "\nSteps taken = " + steps; // displaying the steps

            return 0;
        }

        //Benchmarking function
        private void CollatzConjectureBenchmark()
        {
            BigInteger counter = 10,steps=0; // setting values of counter and steps

            BigInteger result, input=5;   
            var watch = Stopwatch.StartNew();
            for (counter = 1; counter <= 10000000; counter++) //change the counter before comitting
            {
                result = input;
                while (result != 1) // loop will run till the result equals 1, after that it will loop as 4 , 2 ,1 so its of no use after 1
                {
                    if (result % 2 == 0)
                    {
                        result = result / 2;//dividing the result by 2

                    }
                    else if (result % 2 != 0) // if not even
                    {
                        result = (3 * result) + 1; // Collatz Conjecture , equation
                    }
                    
                    steps++; // incrementing steps
                }
                input++; // incrementing input for next number in result
            }
            watch.Stop();//stopping the watch
            var elapsedtime = watch.ElapsedMilliseconds; // setting the value of elapsed time 

            ResultLabel.Text += "\nElapsed time : " + elapsedtime;//displaying elapsed time
            ResultLabel.Text += "\nSteps taken : " + steps; //displaying steps taken
        }
    }
}
