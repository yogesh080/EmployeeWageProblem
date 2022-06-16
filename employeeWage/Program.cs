namespace employeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random = new Random();
            int isEmppresent = random.Next(0, 2);
            if (isEmppresent == 1)
            {
                Console.WriteLine("is present");
            }
            else
            {
                Console.WriteLine("absent");
            }
        }
    }
}