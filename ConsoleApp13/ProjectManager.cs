using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
     public class ProjectManager : Worker
    {
        public void CreateProject(string projectName)
        {
            Console.WriteLine($"{this.Name} {this.Surname} created {projectName} project!!!!");
        }
    }
}
