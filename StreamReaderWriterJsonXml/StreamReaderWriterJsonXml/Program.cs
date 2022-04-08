using Newtonsoft.Json;
using StreamReaderWriterJsonXml.Models;
using System;
using System.IO;

namespace StreamReaderWriterJsonXml
{
    internal class Program
    {
        enum menu { AddEmployee = 1, GetEmployeeById, RemoveEmployee, Quit = 0 }
        static void Main(string[] args)
        {
            string pathFolder = @"C:\Users\HP\Desktop\CodeAcademy\Development\Stream-Reader-Writer-Json-Xml\Database.json";
            
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }

            string pathFile = @"C:\Users\HP\Desktop\CodeAcademy\Development\Stream-Reader-Writer-Json-Xml\Database.json\database.json";
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }

            Console.WriteLine("Please enter Department Name: ");
            string inputDepartment = Console.ReadLine();

            Department deparment = new Department(inputDepartment);
            int input;
            do
            {
                Console.Clear();
                MainMenu();
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case (int)menu.AddEmployee:
                        Console.WriteLine("Please enter Name Employee: ");
                        string inputName = Console.ReadLine();
                        Console.WriteLine("Please enter Salary Employee: ");
                        double inputSalary = int.Parse(Console.ReadLine());
                        Employee employee = new Employee(inputName,inputSalary);
                        deparment.AddEmployee(employee);
                        string result = JsonConvert.SerializeObject(employee);
                        using (StreamWriter streamWriter=new StreamWriter(pathFile))
                        {
                            
                        }
                        break;                        
                    
                    case (int)menu.GetEmployeeById:
                        break;

                    case (int)menu.RemoveEmployee:
                        break;
                    case (int)menu.Quit:
                        break;
                }

            } while (input != 0);
        }
        public static void MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Add Employee \n" +
                "2. Get employee by ID \n" +
                "3. Remove employee \n" +
                "0.Quit");
            Console.WriteLine("Please input your choice: ");
        }
    }
}
