namespace DecisionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your taxable income: ");
            double taxableIncome = int.Parse(Console.ReadLine() ?? "0");
            double tax = 0;

            if (taxableIncome > 100000)
            {
                tax = (taxableIncome - 100000) * 0.3 + (100000 - 50000) * 0.2 + (50000 - 35000) * 0.1;
            }
            else if (taxableIncome > 50000)
            {
                tax = (taxableIncome - 50000) * 0.2 + (50000 - 35000) * 0.1;
            }
            else if (taxableIncome > 35000)
            {
                tax = (taxableIncome - 35000) * 0.1;
            }
            else
            {
                tax = 0;
            }

            Console.WriteLine("Your tax is: {0}", string.Format("{0:f2}", tax));
            Console.WriteLine("Your income after tax is: {0}", string.Format("{0:f2}", taxableIncome - tax));
        }
    }
}
