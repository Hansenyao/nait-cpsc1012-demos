namespace ConsoleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print "Hello" + Name in a seperate line
            Console.Write("Hello: ");
            Console.WriteLine("Hansen");

            int a = 13;
            int b = 11;

            // Print the sum of two numbers
            Console.WriteLine("The sum of " + a + " + " + b + " is " + Sum(a, b));

            // Print the dividing of two numbers
            Console.WriteLine("The dividing of " + a + " / " + b + " is " + Divide(a, b));

            // Print the result of swap two numbers
            Console.WriteLine("The original two numbers ( " + a + ", " + b + " )");
            Swap(ref a, ref b);
            Console.WriteLine("The result after swap ( " + a + ", " + b + " )");
        }

        // Sum of two numbers
        static int Sum(int a, int b)
        {
            return a + b;
        }

        // Return the result of dividing of two numbers
        static double Divide(double a, double b)
        {
            return a / b;
        }

        // To Swap two numbers
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
