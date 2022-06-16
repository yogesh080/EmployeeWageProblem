namespace employeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            int empRatePerHour = 20;

            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int empcheck = random.Next(0, 2);
            if (empcheck == fullTime)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * empRatePerHour;
            Console.WriteLine("Emp wage:" + empWage);


        }
    }
}