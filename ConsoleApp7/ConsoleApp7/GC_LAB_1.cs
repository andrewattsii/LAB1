using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GC_LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {

            {


                Console.WriteLine("Enter three numbers :");
                string inputOne = Console.ReadLine();
                Double num1 = Convert.ToDouble(inputOne);


                string inputTwo = Console.ReadLine();
                Double num2 = Convert.ToDouble(inputTwo);

                string inputThree = Console.ReadLine();
                Double num3 = Convert.ToDouble(inputThree);


                var total = num1 + num2 + num3;
                var average = total / 3;


                Console.WriteLine("Total:" + total);
                Console.WriteLine("Average:" + average);


                Double[] Double = new Double[] { num1, num2, num3 };
                Console.WriteLine(Double.Max());
                Console.WriteLine(Double.Min());


                Console.WriteLine("Us:" + total.ToString("C"));
                Console.WriteLine("Sweedish:" + total.ToString("C", new CultureInfo("sv-SE")));
                Console.WriteLine("Japanese:" + total.ToString("C", new CultureInfo("ja-JP")));
                Console.WriteLine("Thai" + total.ToString("C", new CultureInfo("th-TH")));










            }




        }



    }
}
