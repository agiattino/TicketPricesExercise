﻿using System;

namespace TicketPricesExercise
{
    class Program
    {
        static void checkAge(int age)
        {
            if (age < 0)
            {
                throw new ArithmeticException("Age must begreater than 0.");
            }
        }
        static void Main(string[] args)
        {
            bool isStudent = false;
            int age;
            int price = 14;
            char student;


            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            try
            {
                checkAge(age);
            }
            catch (ArithmeticException e)
            {
                // Error
                Console.WriteLine("Something went wrong.", e.GetType().Name);
                throw new ArithmeticException("Age must be greater than 0.", e);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }


            Console.WriteLine("Are you a student Y or N");
            student = Convert.ToChar(Console.ReadLine());

            if (student == 'Y' || student =='y')
            {
                isStudent = true;
            }

            if (isStudent == true || age < 13)
            {
                price = 8;
            }

            if ((age > 64) && (isStudent = false))
            {
                price = 10;
            }
            

            Console.WriteLine($"Your ticket price is: ${price} ");

        }
    }
}
