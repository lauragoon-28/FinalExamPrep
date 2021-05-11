using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Laura Goon", "MIS 3013", "May 11, 2021");

            string answer = "";
            double v1;
            double v2;
            double result = 0;

            Console.WriteLine("What operation would you like to perform? (add, substract, multiply, or divide)");
            answer = Console.ReadLine().ToLower();

            Console.WriteLine("Please enter 2 numbers");
            Console.Write("Variable 1:");
            string answer1 = Console.ReadLine();
            v1 = Convert.ToDouble(answer1);
            Console.Write("Variable 2:");
            string answer2 = Console.ReadLine();
            v2 = Convert.ToDouble(answer2);

            if (answer.ToLower() == "add")
            {
                result = Add(v1, v2);
                Console.WriteLine($"The sum of {v1.ToString()} and {v2.ToString()} is {result}.");
            }
            else if (answer.ToLower() == "subtract")
            {
                result = Subtract(v1, v2);
                Console.WriteLine($"The difference of {v1.ToString()} and {v2.ToString()} is {result}.");
            }
            else if (answer.ToLower() == "multiply")
            {
                result = Multiply(v1, v2);
                Console.WriteLine($"The product of {v1.ToString()} and {v2.ToString()} is {result}.");
            }
            else if (answer.ToLower() == "divide")
            {
                result = Division(v1, v2);
                Console.WriteLine($"The quotient of {v1.ToString()} and {v2.ToString()} is {result}.");
            }
            Console.WriteLine("Would you like to perform a new calculation? (yes or no)");
            answer = Console.ReadLine();
            while (answer.ToLower() == "yes")
            {
                Console.WriteLine("Would you like to use the result from your previous calculation as a variable?");
                string calcAnswer = Console.ReadLine();
                if (calcAnswer.ToLower() == "yes")
                {
                    Console.WriteLine("What operation would you like to perform? (add, substract, multiply, or divide)");
                    answer = Console.ReadLine().ToLower();

                    v1 = result;

                    Console.Write("Variable 2:");
                    answer2 = Console.ReadLine();
                    v2 = Convert.ToDouble(answer2);

                    if (answer.ToLower() == "add")
                    {
                        result = Add(v1, v2);
                        Console.WriteLine($"The sum of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "subtract")
                    {
                        result = Subtract(v1, v2);
                        Console.WriteLine($"The difference of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "multiply")
                    {
                        result = Multiply(v1, v2);
                        Console.WriteLine($"The product of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "divide")
                    {
                        result = Division(v1, v2);
                        Console.WriteLine($"The quotient of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                }
                if (calcAnswer.ToLower() == "no")
                {
                    Console.WriteLine("What operation would you like to perform? (add, substract, multiply, or divide)");
                    answer = Console.ReadLine().ToLower();
                    Console.WriteLine("Please enter 2 numbers");
                    Console.Write("Variable 1:");
                    answer1 = Console.ReadLine();
                    v1 = Convert.ToDouble(answer1);
                    Console.Write("Variable 2:");
                    answer2 = Console.ReadLine();
                    v2 = Convert.ToDouble(answer2);

                    if (answer.ToLower() == "add")
                    {
                        result = Add(v1, v2);
                        Console.WriteLine($"The sum of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "subtract")
                    {
                        result = Subtract(v1, v2);
                        Console.WriteLine($"The difference of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "multiply")
                    {
                        result = Multiply(v1, v2);
                        Console.WriteLine($"The product of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                    else if (answer.ToLower() == "divide")
                    {
                        result = Division(v1, v2);
                        Console.WriteLine($"The quotient of {v1.ToString()} and {v2.ToString()} is {result}.");
                    }
                }
                Console.WriteLine("Would you like to perform a new calculation? (yes or no)");
                answer = Console.ReadLine();
            }
        }

        static double Add(double v1, double v2)
        {
            double sum;
            sum = v1 + v2;
            return sum;
        }

        static double Subtract(double v1, double v2)
        {
            double difference;
            difference = v1 - v2;
            return difference;
        }

        static double Multiply(double v1, double v2)
        {
            double product;
            product = v1 * v2;
            return product;
        }

        static double Division(double v1, double v2)
        {
            double quotient;
            quotient = v1 / v2;
            return quotient;
        }

        static void DeveloperInformation(string Name, string Class, string Date)
        {
            Console.WriteLine($"This project was created by {Name}, for {Class}, on {Date}");
        }





    }
}
