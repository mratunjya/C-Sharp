using System;

namespace _4.__Branches_and_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, counter, Sum, i;

            // Make decisions using the if statement

            a = 5;
            b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

            // Output: The answer is greater than 10.

            // Make if and else work together

            a = 5;
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            // Output: The answer is not greater than 10

            a = 5;
            b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            // Output: The answer is not greater than 10

            a = 5;
            b = 3;
            c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }

            /* Output:
             * The answer is not greater than 10
             * Or the first number is not equal to the second */

            a = 5;
            b = 3;
            c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            /* Output:
             * The answer is greater than 10
             * Or the first number is equal to the second */



            // Use loops to repeat operations

            counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }

            /* Output:
             * Hello World! The counter is 0
             * Hello World! The counter is 1
             * Hello World! The counter is 2
             * Hello World! The counter is 3
             * Hello World! The counter is 4
             * Hello World! The counter is 5
             * Hello World! The counter is 6
             * Hello World! The counter is 7
             * Hello World! The counter is 8
             * Hello World! The counter is 9
             */

            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);

            /* Output:
             * Hello World! The counter is 0
             * Hello World! The counter is 1
             * Hello World! The counter is 2
             * Hello World! The counter is 3
             * Hello World! The counter is 4
             * Hello World! The counter is 5
             * Hello World! The counter is 6
             * Hello World! The counter is 7
             * Hello World! The counter is 8
             * Hello World! The counter is 9
             */



            // Work with the for loop

            for (counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }

            /* Output:
             * Hello World! The counter is 0
             * Hello World! The counter is 1
             * Hello World! The counter is 2
             * Hello World! The counter is 3
             * Hello World! The counter is 4
             * Hello World! The counter is 5
             * Hello World! The counter is 6
             * Hello World! The counter is 7
             * Hello World! The counter is 8
             * Hello World! The counter is 9
             */



            // Combine branches and loops

            /*Now that you've seen the if statement and the looping constructs in the C# language, see if you can write C# code to find the sum of all integers 1 through 20 that are divisible by 3.
             * Here are a few hints:
                * The % operator gives you the remainder of a division operation.
                * The if statement gives you the condition to see if a number should be part of the sum.
                * The for loop can help you repeat a series of steps for all the numbers 1 through 20.
                * Try it yourself. Then check how you did. As a hint, you should get 63 for an answer.
             */

            Sum = 0;
            for (i = 1; i < 21; i++)
            {
                if (i % 3 == 0)
                    Sum = Sum + i;
            }
            Console.WriteLine($"The Sum of the Numbers which are divisible by 3 till 20 is {Sum}");

            // Output: The Sum of the Numbers which are divisible by 3 till 20 is 63
        }
    }
}