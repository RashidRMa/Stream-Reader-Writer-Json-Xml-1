using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReaderWriterJsonXml.Models
{
    class Department
    {
        private static int _id;
        public int ID { get; set; }
        public string Name { get; set; }
        

        List<Employee> employees;

        public Department(string name)
        {
            _id++;
            ID = _id;
            employees= new List<Employee>();
            Name = name;
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
        public void RemoveEmployeeById(int? id)
        {            
            foreach (var item in employees)
            {
                if (id == item.ID)
                {
                    employees.Remove(item);
                }
            }
        }
        
    }
}
