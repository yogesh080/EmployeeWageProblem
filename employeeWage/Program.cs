namespace employeeWage
{
     class Program
    {
            public const int partTime = 1;
            public const int fullTime = 2;
            public const int PerHourRate = 20;
            public const int numOfWorkingday = 2;
            public const int maxHoursInMonth = 10;
        static void Main(string[] args)
        {

            int empHr = 0;
            int totalEmpHrs = 0;
            int totalWorkingday = 0;
            while (totalEmpHrs < maxHoursInMonth && numOfWorkingday < totalWorkingday)
            {
                totalWorkingday++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

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
                totalEmpHrs += empHr;
                Console.WriteLine("day:" + totalWorkingday + "emp hrs:" + empHr);
            }

            int totalemployeeWage = totalEmpHrs + PerHourRate;
            Console.WriteLine("total emp wage:" + totalemployeeWage);



        }
    }
}