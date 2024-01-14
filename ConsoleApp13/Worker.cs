using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        public void StartWork()
        {
            Console.WriteLine($"{this.Name} {this.Surname} started his work");
        }
        public void EndWork()
        {
            Console.WriteLine($"{this.Name} {this.Surname} ended his  work");
        }
        public void ShowWorkers()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} years old, salary is {this.Salary}$, experience is {this.Experience} years");
        }

       

    }
    }
