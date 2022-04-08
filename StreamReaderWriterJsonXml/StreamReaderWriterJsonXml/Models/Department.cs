using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderWriterJsonXml.Models
{
    class Department
    {
        private static int _id;
        public int ID { get; }
        public string Name { get; set; }

        List<Employee> employees;

        public Department()
        {
            _id++;
            ID = _id;
            employees= new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void GetEmployeeById(int? id)
        {
            Employee employee1=employees.Find(x => x.ID == id);
            if (employee1 == null)
            {
                throw new Exception($"The employee is not found with this { ID }");

            }
            Console.WriteLine(employee1);
        }
    }
}
