// See https://aka.ms/new-console-template for more information


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace Sloth1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int cubedNumber = cube(5);
            string characterName = "John";
            int characterAge;
            characterAge = 35;
            string phrase = "Sloth Academy";
            char grade = 'A';
            int someoneAge = 30;
            int negativeAge = -30;

            // data types
            // least accurate to most precise decimals 
            // float, double, decimal
            double gpa = 3.75;

            // working with strings
            string dog = "My dog's name is Amy";
            
            Console.WriteLine("Hello World");
            Console.WriteLine(cubedNumber);
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old.");
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But did not like being " + characterAge);

            Console.WriteLine(dog);
            Console.WriteLine("The dog string is " + dog.Length + " characters long.");

            // methods

            // Capitalize all letters
            Console.WriteLine(dog.ToUpper());

            // Lowercase all strings
            Console.WriteLine(dog.ToLower());

            // Contains certain characters
            Console.WriteLine(dog.Contains("Amy"));

            // Find the first character of a string
            Console.WriteLine(dog[0]);

            // Find index where Amy starts
            Console.WriteLine(dog.IndexOf("Amy"));

            Console.WriteLine(dog.Substring(8, 3));

            Console.WriteLine("Sloth\nAcademy");

            Console.WriteLine(100 / 25);





            Console.WriteLine(Math.Abs(-50));
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Sqrt(100));
            Console.WriteLine(Math.Max(5, 100));
            Console.WriteLine(Math.Min(5, 100));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.8));


            
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);


            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            // Basic Calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            // Advanced Calculator
            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator");
            string op = Console.ReadLine();


            Console.Write("Enter a number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num3 + num4);
            } else if (op == "-")
            {
                Console.Write(num3 - num4);
            }
            else if (op == "*")
            {
                Console.Write(num3 * num4);
            }
            else if (op == "/")
            {
                Console.Write(num3 / num4);
            } else
            {
                Console.Write("Invalid Operator");
            }


            // Mad Libs Game    

            string color, pluralNoun, celebrity;

            Console.WriteLine("\nLet's play the Mad Libs Game!");
            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);


            // Arrays
            // elements inside array
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[10]; // create an array with 10 elements
            friends[0] = "Jim";
            friends[1] = "Kelly";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            // Methods (block of code to perform specific tasks)

            SayHi("Vincent", 29);
            Console.WriteLine(cube(5));

            // If Statements

            
            // booleans
            bool isMale = false;
            bool isTall = true;
            // bool isFemale = true;
            // if (isMale && isTall)
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall guy");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short guy");
            } else if(!isMale && isTall)
            {
                Console.WriteLine("You are a tall girl");
            }
            else
            {
                Console.WriteLine("You are a short girl");
            }

            Console.WriteLine(GetMax(2,10,20));

            // Switch Statements

            Console.WriteLine(GetDay(100));

            // While Loops

            int index = 6;
            /*while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }*/

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            // Guessing Game
            string secretWord = "sloth";
            string guess = "";

            while (guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.Write("You win!");




            Console.ReadLine(); 

            



        }
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            /* if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            } */

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            } else
            {
                result = num3;
            }

            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        
    }
}
