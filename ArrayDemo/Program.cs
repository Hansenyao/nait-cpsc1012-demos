namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates array of length 2, default values
            string[] array1 = new string[2];
            // creates populated array of length 2
            string[] array2 = new string[] { "A", "B" };
            // creates populated array of length 2
            string[] array3 = { "A", "B" };
            // creates populated array of length 2
            string[] array4 = new[] { "A", "B" };
            // creates populated array of length 2
            string[] array5 = ["A", "B"];


            int[] numbers = { 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
