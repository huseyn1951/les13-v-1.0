using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
     public class Accountant:Worker
    {
        public void ShowSalary(string workerName,string workerSurname)
        {
            Console.WriteLine($"{workerName} {workerSurname}'s salary is {Salary}");
        }

        public void ShowSalaryAvarage(Worker[] workers)

        {
            int sum = 0;
            foreach (var worker in workers)
            {
                sum += worker.Salary;
            }

            int avarage = sum / workers.Length;
            Console.WriteLine($"Worker's salary avarage is {avarage} $");
        }
    }
}
