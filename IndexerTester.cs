using System;

namespace ncit_hari
{
    internal class IndexerTester
    {
        public class Employee
        {
            //private fields
            int eid;
            string name;
            string job;
            double salary;
            //constructor 
            public Employee(int eid, string name, string job, double salary)
            {
                this.eid = eid;
                this.name = name;
                this.job = job;
                this.salary = salary;
            }
            //indexer 
            public object this[int index]
            {
                get
                {
                    if (index == 0)
                    {
                        return eid;
                    }
                    else if (index == 1)
                    {
                        return name;
                    }
                    else if (index == 2)
                    {
                        return job;
                    }
                    else if (index == 3)
                    {
                        return salary;
                    }
                    return null;
                }
                set
                {
                    if (index == 0)
                    {
                        eid = (int)value;
                    }
                    else if (index == 1)
                    {
                        name = (string)value;
                    }
                    else if (index == 2)
                    {
                        job = (string)value;
                    }
                    else if (index == 3)
                    {
                        salary = (double)value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
            }
        }

        // Main method - entry point of the program
        public static void Main(string[] args)
        {
            // You can write your code to test the Indexer here
            // For example:
            Employee employee = new Employee(1, "John Doe", "Software Engineer", 50000.00);
            Console.WriteLine($"Employee ID: {employee[0]}");
            Console.WriteLine($"Employee Name: {employee[1]}");
            Console.WriteLine($"Employee Job: {employee[2]}");
            Console.WriteLine($"Employee Salary: {employee[3]}");
        }
    }
}
