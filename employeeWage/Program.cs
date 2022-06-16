namespace employeeWage
{
     class Program
    {
            public const int partTime = 1;
            public const int fullTime = 2;
            public const int PerHourRate = 20;
        static void Main(string[] args)
        {

            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empcheck = random.Next(0,2);
            switch (empcheck)
            {
                case partTime:
                    empHr = 4;
                    break;
                case fullTime:
                    empHr=8;
                    break;
                default:
                    empHr=0;
                    break;
            }
            empWage = empHr * PerHourRate;
            Console.WriteLine(empWage);



        }
    }
}