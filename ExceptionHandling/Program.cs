namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] cars = new string[3];
                cars[0] = "BMW";
                cars[1] = "Mazda";
                cars[2] = "Honda";

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(cars[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Only 3 cars are allowed each time!");
                //Console.WriteLine(ex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("End!");
            }
        }
    }
}
