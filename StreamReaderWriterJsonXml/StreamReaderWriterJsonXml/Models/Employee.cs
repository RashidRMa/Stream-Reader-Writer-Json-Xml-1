using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderWriterJsonXml.Models
{
    class Employee
    {
        private static int _id;
        public int ID { get; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            _id++;
            ID = _id;
            Name = name;
            Salary = salary;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID} \n" +
                $"Name: {Name} \n" +
                $"Salary: {Salary}");
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
