using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace exercise_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tinyCalculator();
            //evenOrOdd();
            //echo();
            //anserToLife();
            //countingNumbers();
            //sumOfNum();
            //amountAndSum();
            //iteratingToInput();
            //numAndCal();
            //printPhrase();
            //howManyTimes();
            //printUntilNumber();
            //printFromNumberToOne();
            //division();
            divisibleByThreeInRange();
        }

        //exercise 23
        public static void tinyCalculator() 
        {
            Console.WriteLine("Give the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int anserOne = firstNum + secondNum;
            Console.WriteLine(anserOne);
            int anserTwo = firstNum - secondNum;
            Console.WriteLine(anserTwo);
            int anserTree = firstNum * secondNum;
            Console.WriteLine(anserTree);
            int anserFour = firstNum / secondNum;
            Console.WriteLine(anserFour);
        }

        //exercise 31
        public static void evenOrOdd()
        {
            Console.WriteLine("Give a number");
        int oddEvenNumber = Convert.ToInt32(Console.ReadLine());
        if (oddEvenNumber % 2 == 0)
        {
            Console.WriteLine("This number is even");
        } else
        {
            Console.WriteLine("This number is odd");
        }
        }

        //exercise 33
        public static void echo()
        {
            Console.WriteLine("Give two strings");
            string stringOne = Console.ReadLine();
            string stringTwo = Console.ReadLine();
            if (stringOne == stringTwo)
            {
                Console.WriteLine("Echo");
            } else
            {
                Console.WriteLine("Nope");
            }
        }

        //exercise 35
        public static void anserToLife()
        {
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int fourtyTwo = Convert.ToInt32(Console.ReadLine());
                if (fourtyTwo == 42)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("Done!");
        }

        //exercise 37
        public static void countingNumbers()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("Give a number: ");
                int zero = Convert.ToInt32(Console.ReadLine());
                if (zero == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    i++;
                    continue;
                }
            }

            Console.WriteLine("Done!");
        }

        //exercise 39
        public static void sumOfNum()
        {
            int i = 0;
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Give a number: ");
                int zeroCountUp = int.Parse(Console.ReadLine());
                if (zeroCountUp == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    i = sum += zeroCountUp;
                    continue;
                }
            }

            Console.WriteLine("Done!");
        }

        //exercise 40
        public static void amountAndSum()
        {
            int i = 0;
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Give a number: ");
                int amountAndSum = int.Parse(Console.ReadLine());
                if (amountAndSum == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    i++;
                    sum += amountAndSum;
                    continue;
                }
            }

            Console.WriteLine("Total amount of numbers: " + i);
            Console.WriteLine("Sum of all numbers: " + sum);
        }

        //exercise 2-5
        public static void iteratingToInput()
        {
            int i = 0;

            Console.WriteLine("Give a number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            while (i != inputNumber)
            {
                if (i != inputNumber)
                {
                    i++;
                    Console.WriteLine(i);
                    continue;
                }
                else
                {
                    Console.WriteLine("the number is" + i);
                    break;
                }
            }
        }

        //exercise 2-8
        public static void numAndCal()
        {
            double i = 0;
            double sum = 0;
            int even = 0;
            int odd = 0;

            while (true)
            {
                Console.WriteLine("Give numbers");
                int zeroCountUp = int.Parse(Console.ReadLine());
                if (zeroCountUp == -1)
                {
                    break;
                } else
                {
                    i++;
                    sum += zeroCountUp;

                    if (zeroCountUp % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                    continue;
                }
            }
            Console.WriteLine("Tnx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Number: " + i);
            Console.WriteLine("Average: " + sum / i);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd " + odd);
        }

        //exercise 2-9
        public static void printPhrase()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine("In a hole in the ground there lived a method.");
                number--;
            }
        }

        //exerise 2-10
        public static void howManyTimes()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                Console.WriteLine("In a hole in the ground there lived a method.");
                number--;
            }
        }

        //exercise 2-11
        public static void printUntilNumber()
        {
            
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            
            while (number > -1)
            {
                Console.WriteLine(number);
                number--;
            }
            
        }

        //exercise 2-12
        public static void printFromNumberToOne()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());

            while (number > -1)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        //exercise 2-13
        public static void division()
        {
            Console.Write("Give the first number: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Give the second number: ");
            double num2 = int.Parse(Console.ReadLine());

            double sum3 = num1 / num2;
            Console.WriteLine(sum3);
        }


        //exercise 2-14
        public static void divisibleByThreeInRange()
        {
            Console.Write("Give the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Give the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int num3 = num1; num3 < num2; num3++)
            {
                if (num3 % 3 == 0)
                {
                    Console.WriteLine(num3);
                }
            }
        }
    }
}