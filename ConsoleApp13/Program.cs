using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
     public class Program
    {
         public static void Main(string[] args)
        {
            Developer developer1 = new Developer()
            {
                Name = "Abdullah",
                Surname = "Zubir",
                Age = 32,
                ProgLanguage = "C#",
                WayOfProgramming = "backend",
                Salary = 4000,
                Experience = 5
            };
            Developer developer2 = new Developer()
            {
                Name = "Cristiano",
                Surname = "Ronaldo",
                Age = 36,
                ProgLanguage = "Javascript",
                WayOfProgramming = "Frontend",
                Salary = 3500,
                Experience = 9
            };

            ProjectManager projectManager = new ProjectManager()
            {
                Name = "Sir Alex",
                Surname = "Ferguson",
                Age = 76,
                Salary = 7000,
                Experience = 12
            };

            Accountant accountant = new Accountant()
            {
                Name = "Tahir",
                Surname = "Gozel",
                Age = 56,
                Salary = 4200,
                Experience = 7
            };

            Worker[] allWorkers = new Worker[] { projectManager, accountant, developer1, developer2 };

            projectManager.CreateProject("ABB aplication");
            developer1.ShowStack();
            developer2.ShowStack();
            developer1.StartWork();
            developer2.EndWork();
            accountant.ShowWorkers();
            developer1.ShowWorkers();

            accountant.ShowSalary(developer1.Name, developer1.Surname);
            accountant.ShowSalary(projectManager.Name, projectManager.Surname);
            accountant.ShowSalaryAvarage(allWorkers);
            
        }
    } }
