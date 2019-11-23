
namespace Interface_Example
{
using System;
    public class StartUp
    {
        public static void Main()
        {
            ConstantMinimalSalaryProvider constant = new ConstantMinimalSalaryProvider();
            CurrentYearMinimalSalaryProvider currentyearSalary = new CurrentYearMinimalSalaryProvider();
            Console.WriteLine(constant.GetMinimalSalary()); // 300
            Console.WriteLine(currentyearSalary.GetMinimalSalary()); // 600
        }
    }

    public interface IMinimamSalaraProvider
    {
        int GetMinimalSalary();
    }

    public class ConstantMinimalSalaryProvider : IMinimamSalaraProvider
    {
        public int GetMinimalSalary()
        {
            return 300;
        }
    }

    public class CurrentYearMinimalSalaryProvider : IMinimamSalaraProvider
    {
        public int GetMinimalSalary()
        {
            return 600;
        }
    }
}
