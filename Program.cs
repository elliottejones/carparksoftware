using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Title = "Bob's Car Park";
            Console.ForegroundColor = ConsoleColor.White;

            string reg = "";


            void write(string str)
            {
                Console.WriteLine(str);
            }


            bool entry()
            {
                Console.Clear();
                write("############################");
                write("");
                write("Welcome To Bob's Car Park");
                write("");
                write("Enter Your Reg Number");
                write("");
                write("############################");
                write("");
                while (true)
                {
                    reg = Console.ReadLine();

                    if (reg == "")
                    {
                        write("Please Enter A Reg Number");
                        write("");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear() ;
                write("############################");
                write("");
                write("You Entered: "+reg+". Is that correct? (y/n)");
                write("");
                write("############################");
                write("");

                string confirm = Console.ReadLine();

                if (confirm == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            while (true)
            {
                if (entry() == true)
                {
                    break;
                }
                
            }

        }
    }
}
