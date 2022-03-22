using System;

namespace MethodExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //console.writeline("what is your name");
            //string username = console.readline();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            // Console.WriteLine("What is a name for a dog");
            //string userDogName = Console.ReadLine();

            // Console.WriteLine("What color is your dog");
            // string userDogColor = Console.ReadLine();

            // Console.WriteLine($"There was a man named {userName}, he was {age} years old");
            // Console.WriteLine($"He had a {userDogColor} dog named {userDogName}");

            Console.WriteLine("Give a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine("Give me a  number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++) 
            {
                sum = sum + list[i];
            }
            return sum;  
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        
    }
}
