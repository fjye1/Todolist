using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- C# Sharp calculator ---");
            Console.WriteLine("enter your name for the log");
            Console.WriteLine("First name");
            var fname = Console.ReadLine();
            Console.WriteLine("last name");
            var lname = Console.ReadLine();
            Console.WriteLine(ProperCase(fname, lname));
            
            Console.WriteLine("Enter your first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your operator");
            string op = Console.ReadLine();
            Console.WriteLine("Enter your second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            //this is a switch expression
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("invalid operation");
                    return;
            }


           
            Console.WriteLine($"{num1}{op}{num2}={result}");
            Console.ReadKey();

            string ProperCase(string fname, string lname)
            {
                string fnameLower = fname.ToLower();
                string lnameLower = lname.ToLower();

                string newFname = char.ToUpper(fname[0]) + fnameLower.Substring(1);
                string newLname = char.ToUpper(lname[0]) + lnameLower.Substring(1);

                return newFname + " " + newLname;


            }

            //this is a switch statement 
            char convertPointsToGrade(int points)
            {
                return points switch
                {
                    10 or 9 => 'A',
                    8 or 7 or 6 => 'B',
                    5 or 4 or 3 => 'C',
                    2 or 1 => 'D',
                    0 => 'E',
                    _ => '!',
                };
            }
        }
    }
}
//tryparse()

//try parse is the better version of this method