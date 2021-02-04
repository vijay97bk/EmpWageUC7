using System;

    class Program
    {
    public const int IS_FULL_TIME = 2;
    public const int IS_PART_TIME = 1;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUMBER_OF_WORKING_DAYS = 20;
    public const int MAX_HOURS_IN_MONTH = 100;
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The arguments.</param>
    public static void EmpWage()
    {
        int empHours = 0;
        int empWage = 0;
        int totalEmpWage = 0;
        int totalEmpHours = 0;
        int totalWorkingDays = 0;

        while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays <= NUMBER_OF_WORKING_DAYS)
            totalWorkingDays++;
        Random random = new Random();
        int Emp_Check = random.Next(0, 3);
        switch (Emp_Check)
        {
            case IS_PART_TIME:
                empHours = 4;
                break;
            case IS_FULL_TIME:
                empHours = 8;
                break;
            default:
                empHours = 0;
                break;
        }
        empWage = empHours * EMP_RATE_PER_HOUR;
        totalEmpWage += empWage;
        Console.WriteLine("employee wage is" + empWage);
        Console.WriteLine("total wage is" + totalEmpWage);
        Console.WriteLine("total working days:" + totalWorkingDays + "emp hours:" + empHours);
        Console.WriteLine("total employee wage is :" + totalEmpWage);
    }
    static void Main(string[] args)
        {
        EmpWage();
 
        }
    
    }


