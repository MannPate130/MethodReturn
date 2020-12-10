using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //1.  Get values for question 1 and call the Add method. Accept the
            //    returned value and then display it.
            //
            //    Sample input and output:
            //
            //    Input: 4, 5
            //    4 + 5 = 9
            //
            //    Input: 6, 1
            //    6 + 1 = 7;

            int num1 = Convert.ToInt16(q1Num1Input.Text);
            int num2 = Convert.ToInt16(q1Num2Input.Text);
           
            int answer = Add(num1, num2);
            q1Output.Text = $"{num1} + {num2} = {answer}";


            //2.  Get values for question 2 and call the Area method. Accept the
            //    returned value and then display it.
            //
            //    Sample input and output:
            //
            //    Input: 4, 5
            //    The area is 20 units squared
            //
            //    Input: 6, 2
            //    The area is 18 units squared

            int Length = Convert.ToInt16(lengthInput.Text);
            int Width = Convert.ToInt16(widthInput.Text);

            int areaAnswer = Area(Length, Width);
            q2Output.Text = $"{Length} x {Width} = {areaAnswer}";

            //3.  Get a value for question 3 and call the PrintPrice method. Accept the
            //    returned value and then display it.
            //
            //    Sample input and output:
            //
            //    Input: 5
            //    The total price is $5.00
            //
            //    Input: 75
            //    The total price is $48.75
            //
            //    Input: 200
            //    The total price is $100.00

            int print = Convert.ToUInt16(copiesInput.Text);
            double ten = print * 1.00;
            double fifty = print * 0.75;
            double hundred = print * 0.65;
            double overHundred = print * 0.50;

            PrintPrice( print, ten, fifty, hundred, overHundred);


        }

        // 1. Create a method called Add, that accepts 2 int parameters, (x and y),
        //    adds them together, and then returns the result back to the method call.       


        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
            
        }



        // 2. Create a method called Area, that accepts 2 int parameters, (x and y),
        //    uses them to determine the area of a rectangle , and then returns the 
        //    result back to the method call.
        public int Area(int x, int y)
        {
            int area = x * y;
            return area;
            
        }


        // 3. Create a method called PrintPrice, that accepts 1 int parameter, (prints),
        //    uses it to determine the price for the customer based on the following
        //    pricing structure, and returns the result back to the method call.
        //
        //    0 - 10 prints:  $1.00/print
        //    11 - 50 prints:  $0.75/print
        //    51 - 100 prints:  $0.65/print
        //    101 or over:  $0.50/print
        public void PrintPrice(int print, double ten, double fifty, double hundred, double overHundred)
        {
            if (print < 11 )
            {
                q3Output.Text = $"The total price is {ten.ToString("C")}";
            }
            else if (print < 51 && print > 11)
            {
                q3Output.Text = $"The total price is {fifty.ToString("C")}";
            }
            else if (print < 101 && print > 51)
            {
                q3Output.Text = $"The total price is {hundred.ToString("C")}";
            }
            else if (print > 101)
            {
                q3Output.Text = $"The total price is {overHundred.ToString("C")}";
            }
        }

    }
}
