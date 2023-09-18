using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

                var confirm = Console.ReadKey();

                if (confirm.Key == ConsoleKey.Y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int payment()
            {
                Console.Clear();

                write("############################");
                write("");
                write("Please Select Time Slot (Numbers 1-7)");
                write("");
                write("############################");
                write("");
                write("Please select duration:    (Press number 1-7)\r\n\r\n1       Up to 30 minutes        £1\r\n2       30-60 minutes           £2\r\n3       Up to 2 hours           £3\r\n4       Up to 3 hours           £4\r\n5       Up to 4 hours           £5\r\n6       Up to 6 hours           £6\r\n7       Up to 12 hours          £10");
                write("");

                int price = 0;

                switch (Char.ToString(Console.ReadKey().KeyChar))
                {
                    case "1":
                        {
                            price = 1;
                            break;
                        }
                    case "2":
                        {
                            price = 2;
                            break;
                        }
                    case "3":
                        {
                            price = 3;
                            break;
                        }
                    case "4":
                        {
                            price = 4;
                            break;
                        }
                    case "5":
                        {
                            price = 5;
                            break;
                        }
                    case "6":
                        {
                            price = 6;
                            break;
                        }
                    case "7":
                        {
                            price = 10;
                            break;
                        }

                }

                Console.Clear();

                if (price == 0)
                {
                    return -1;
                }

                else
                {
                    write("############################");
                    write("");
                    write("Amount Due For Your Selected Time Slot Is £" + price + ".");
                    write("Continue? (y/n)");
                    write("");
                    write("############################");
                    write("");
                }
                

                var confirm = Console.ReadKey();

                if (confirm.Key == ConsoleKey.Y)
                {
                    return price;
                }
                else
                {
                    return -1;
                }

                
            }

            bool charge()
            {
                float due = payment();

                if (due != -1)
                {
                    while (due > 0)
                    {
                        Console.Clear();
                        write("############################");
                        write("");
                        write("You Currently Owe: £" + due + ".");
                        write("Please Enter Money");
                        write("");
                        write("############################");
                        write("");
                        due -= float.Parse(Console.ReadLine());
                    }

                    Console.Clear();

                    due = due * -1;

                    write("############################");
                    write("");
                    write("You are due: £" + due + " change.");
                    write("Do you want to print receipt?");
                    write("");
                    write("############################");

                    var confirm = Console.ReadKey();

                    if (confirm.Key == ConsoleKey.Y)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
                    while (charge() != true)
                    {

                    }

                    break;
                }
                
            }

            


            
                

            // Cannot Return Now

            Console.Clear();

            

            
            
            




        }
    }
}
