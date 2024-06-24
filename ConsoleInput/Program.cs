namespace ConsoleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input user full name
            Console.Write("Please input your full name:");
            String fullName = Console.ReadLine() ?? "";
            if (fullName.Length <= 0)
            {
                Console.WriteLine("You don't input anything!");
                return;
            }
            Console.Write("Your full name is:");
            Console.WriteLine(fullName);

            const string domainName = "@gamil.com";
            string email = fullName.Replace(" ", ".") + domainName;
            Console.Write("Your email is:");
            Console.WriteLine(email);

            // Input user age
            Console.Write("Please input your age:");
            int age = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.Write("Your age is :");
            Console.WriteLine(age);

            // Output with parameters
            Console.WriteLine($"FullName: {fullName}, age: {age}");
            Console.WriteLine("FullName: {0}, age: {1}",fullName, age);
        }
    }
}
