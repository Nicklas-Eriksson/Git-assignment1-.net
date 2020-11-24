using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GitÖvningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {   //Titel
            Console.Title = "Movember Assignment";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            
            
            //Variables            
            double term1;
            double term2;
            double term3;
            double kalk1 = 0;
            double sum = 0;
            List<double> sumList = new List<double>();
            char operator1;
            char operator2;
            string answer = "";
            bool isRunning = true;

            start:
            //Input from user
            Console.Write("Enter first operator: ");
            operator1 = Convert.ToChar(Console.ReadLine());
            Console.Beep(400, 300);
            Console.WriteLine();
            Console.Write("Enter second operator: ");
            operator2 = Convert.ToChar(Console.ReadLine());
            Console.Beep(400, 300);
            Console.WriteLine();
            Console.Write("Enter first term: ");
            term1 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(200, 300);
            Console.WriteLine();
            Console.Write("Enter second term: ");
            term2 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(200, 300);
            Console.WriteLine();
            Console.Write("Enter third term:  ");
            term3 = Convert.ToDouble(Console.ReadLine());
            Console.Beep(200, 300);
            Console.WriteLine();

            while (isRunning == true)
            {   //For first part of the equation
                bool firstRun = true;
                while (firstRun == true)
                {
                    if (operator1 == '+')
                    {
                        kalk1 = term1 + term2;
                    }
                    else if (operator1 == '-')
                    {
                        kalk1 = term1 - term2;
                    }
                    else if (operator1 == '*')
                    {
                        kalk1 = term1 * term2;
                    }
                    else if (operator1 == '/')
                    {
                        kalk1 = term1 / term2;
                    }

                    //Operator round 2
                    if (operator2 == '+')
                    {
                        sum = kalk1 + term3;
                    }
                    else if (operator2 == '-')
                    {
                        sum = kalk1 - term3;
                    }
                    else if (operator2 == '*')
                    {
                        sum = kalk1 * term3;
                    }
                    else if (operator2 == '/')
                    {
                        sum = kalk1 / term3;
                    }

                    sumList.Add(sum);// Adds the sum the the List

                    //Displays the calculation to the user
                    Console.Write($"{term1} {operator1} {term2} {operator2} {term3} = {sum}");

                    break;
                }

                // Checks what the sum was
                if (sum < 100)
                {
                    Console.WriteLine("\nThe sum is less than a hundred");
                    Console.WriteLine("\n\tAnother try?\n\t[y]es or [n]o");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("You'r answer is yes\n");
                        goto start;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: " + sumList.Sum());
                        Console.Beep(933, 300);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(1047, 400);
                        break;
                    }
                }
                else if (sum == 100)
                {
                    Console.WriteLine("\nThe sum is exactly one hundred");
                    Console.WriteLine("\n\tAnother try?\n\t[y]es or [n]o");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("You'r answer is yes\n");
                        goto start;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: " + sumList.Sum());
                        Console.Beep(933, 300);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(1047, 400);
                        break;
                    }
                }
                else if (sum > 100)
                {
                    Console.WriteLine("\nThe sum is more than a hundred");
                    Console.WriteLine("\n\tAnother try?\n\t[y]es or [n]o");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("You'r answer is yes\n");
                        goto start;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: " + sumList.Sum());
                        Console.Beep(933, 300);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(933, 100);
                        Console.Beep(1047, 400);
                        break;
                    }
                }
            }
        }
    }
}
