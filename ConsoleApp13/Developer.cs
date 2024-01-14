using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
     public class Developer : Worker
    {
        public string ProgLanguage { get; set; }
        public string WayOfProgramming { get; set; }

        public void ShowStack()
        {
            Console.WriteLine($"{this.Name} {this.Surname}'s way of programming is {this.WayOfProgramming} he works in {this.ProgLanguage} language, his experience is {this.Experience} years");
        }
    }
}
