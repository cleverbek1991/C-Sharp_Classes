﻿using System;
using System.Collections.Generic;

namespace classes
{
    public class Program
    {
        static void Main(string[] args)
            {
                Company company = new Company("Microsoft", DateTime.Now);
                Employee washington = new Employee("Washington", "Developer", "January 2");
                Employee trump = new Employee("Trump", "Designer", "July 2");
                Employee bush = new Employee("Bush", "Someone", "May 2");
                company.addEmployee(washington);
                company.addEmployee(trump);
                company.addEmployee(bush);
                company.ListEmployees();
            }
    }

    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }

        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> employeeList = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void addEmployee(Employee employee)
        {
            employeeList.Add(employee);
        }

        // Create a method that allows external code to remove an employee
        public void removeEmployee(Employee employee)
        {
            employeeList.Remove(employee);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string name, DateTime createdon)
        {
            Name = name;
            CreatedOn = createdon;
        }

        public void ListEmployees ()
        {
            foreach (Employee e in employeeList)
            {
                Console.WriteLine($"{e.Name}, {e.JobTitle}, {e.StarTDate}");
            }
        }
        
    }

    public class Employee
    {
        public string Name; 
        public string JobTitle; 
        public string StarTDate;
        public Employee (string name, string jobtitle, string startdate)
        {
            Name = name;
            JobTitle = jobtitle;
            StarTDate = startdate;
        }
    }
}
