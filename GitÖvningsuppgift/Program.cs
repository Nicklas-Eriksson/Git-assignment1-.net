using System;
using System.Collections.Generic;
using System.Linq;


namespace GitÖvningsuppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Titel
            Console.Title = "Movember Assignment";

            //Variables            
            double term1;
            double term2;
            double term3;
            double kalk1 = 0;
            double sum = 0;
            int[] sumArray = new int[Convert.ToInt32(sum)];

            char operator1;
            char operator2;

            string answer = "";
            GrowingArray growingArray = new GrowingArray();

            start:
            //Input from user
            Console.Write("Enter first operator: ");
            operator1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second operator: ");
            operator2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter first term: ");
            term1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter second term: ");
            term2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter third term:  ");
            term3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            bool isRunning = true;
            while (isRunning == true)
            {

                //For first part of the equation
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

                    ////////////////////////////////


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
                    //Converts the terms and sum to string for console
                    string sTerm1 = Convert.ToString(term1);
                    string sTerm2 = Convert.ToString(term2);
                    string sTerm3 = Convert.ToString(term3);
                    //string sSum = Convert.ToString(sum);
                    //Displays the calculation to the user
                    Console.Write(sTerm1 + " " + operator1 + " " + sTerm2 + " " + operator2 + " " + sTerm3 + " = ");
                    Console.WriteLine(sum);

                    break;
                }

                double listSum = 0;
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
                        
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: ");                      
                        
                        break;
                    }
                    //else
                    //    Console.WriteLine("Sorry I did not get that, try again");
                    //kod som kör loopen igen
                }
                else if (sum == 100)
                {
                    Console.WriteLine("\nThe sum is exactly one hundred");
                    Console.WriteLine("\n\tAnother try?\n\t[y]es or [n]o");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        
                        Console.WriteLine("You'r answer is yes");
                        goto start;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: " + listSum);
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
                        
                        Console.WriteLine("You'r answer is yes");
                        goto start;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Thank you for playing. The sum of all rounds is: " + listSum);
                        break;
                    }
                }
                
                
                

            }

            //Så den inte stängs
            Console.ReadKey(true);
        }
        static double MyList()
        {
            double sum = 0;
            List<double> listSum = new List<double>();

            for (int i = 0; i < listSum.Count; i++)
            {
                listSum.Add(sum);
                
                listSum.ToArray();
            }
            for (int i = 1; i != listSum.Count; i++)
            {
                //sum *= listSum[i];
                Console.WriteLine();
                listSum.Sum();

            }
            return sum;
        }
        
    }
}
