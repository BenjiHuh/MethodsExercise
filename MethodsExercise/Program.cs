using System.ComponentModel;
using System.Transactions;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateStory());
            Console.WriteLine("give me a integer number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("give me another integer number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("here's the sum of those two numbers: " + Add(num1, num2));
            Console.WriteLine("here's the difference of those two numbers: " + Subtract(num1, num2));
            Console.WriteLine("here's the product of those two numbers: " + Multiply(num1, num2));
            Console.WriteLine("here's the quotient of those two numbers: " + Divide(num1, num2));
        }

        //The CreateStory method takes no paramaters but asks for string inputs in the console and returns a story related to the inputs given in the console.
        //The story created may not make sense if the responses to the prompt do not make sense.
        private static String CreateStory()
        {
            Console.WriteLine("tell me your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("tell me your favorite food: ");
            String food = Console.ReadLine();
            Console.WriteLine("give me the name of a random animal: ");
            String animal = Console.ReadLine();
            String output = name + " went to a restaurant and ordered " + food + ", his favorite food. \n" + "Then " + name + " went outside and saw a " + animal + " randomly walking outside.";
            return output;
        }
        private static int Add (params int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            return sum;
        }

        private static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Multiply (int num1, int num2)
        {
            return num1 * num2;
        }

        private static double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
    }
}
