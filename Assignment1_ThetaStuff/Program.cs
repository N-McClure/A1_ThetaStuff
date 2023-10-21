using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_ThetaStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program pr = new Program();

            pr.function_Display();
            Console.WriteLine();
            Console.WriteLine("Do you want to do this again? (yes/no): ");
            string YorN = Console.ReadLine();
            YorN.ToLower();

            do
            {
                pr.function_Display();
                Console.WriteLine();
                Console.WriteLine("Do you want to do this again? (yes/no): ");
                YorN = Console.ReadLine();
                YorN.ToLower();
            }
            while (YorN.Equals("yes"));
            if(YorN.Equals("no"))
            {
                Environment.Exit(exitCode: 0);
            }

            Console.Read();
        }

        //Function 1 ('f'):
        public void function_F(double theta)
        {
            //Calculating and Displaying:
            Console.Write((2 * Math.Sin(theta)));
        }

        //Function 2 ('g'):
        public void function_g(double theta)
        {
            //Calculating and Displaying:
            Console.Write(Math.Log(theta ,2));
        }

        //Funtion 3 ('Display):
        public void function_Display()
        {
            //Getting the value of Lower Theta for Functions:
            Console.WriteLine("Enter a value for Lower Theta to be used in Functions: ");
            double LowerTheta = double.Parse(Console.ReadLine());

            //Getting the value of Upper Theta for Functions:
            Console.WriteLine("Enter a value for Upper Theta to be used in Functions: ");
            double UpperTheta = double.Parse(Console.ReadLine());

            //Getting the Number of spaces you wish to see:
            Console.WriteLine("Enter the Number of Spaces you want to see: ");
            double SpacesInputted = double.Parse(Console.ReadLine());
            double spaces = UpperTheta / SpacesInputted;

            Program pr = new Program();

            double theta = LowerTheta;

            for (double i = 0; theta <= UpperTheta; i++)
            {
                Console.Write(theta);
                Console.Write("     |     ");
                pr.function_F(theta);
                Console.Write("     |     ");
                pr.function_g(theta);
                Console.WriteLine();

                double newTheta = theta + spaces;
                theta = newTheta;
            }
        }
    }
}
