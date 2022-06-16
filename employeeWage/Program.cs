﻿namespace employeeWage
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;

        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingdays = 0;

            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalworkingdays < NUM_OF_WORKING_DAYS)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs=8;
                        break;
                    default:
                        empHrs=0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day" + totalworkingdays + "Emp Hrs:" + empHrs);
            }
            int totalwage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total employee wage:" + totalwage);
        }


    }
}