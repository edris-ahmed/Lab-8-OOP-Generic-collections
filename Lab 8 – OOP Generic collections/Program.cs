using System.Reflection;
using System.Xml.Linq;


namespace Lab_8___OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "John", "Male", 37500);
            Employee employee2 = new Employee(102, "Simon", "Male", 66300);
            Employee employee3 = new Employee(103, "Lara", "Female", 53800);
            Employee employee4 = new Employee(104, "Leon", "Male", 52000);
            Employee employee5 = new Employee(105, "Ada", "Female", 48700);

            Stack<Employee> employeeStack = new Stack<Employee>();
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack - {employeeStack.Count}");
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Retrieve Using Pop Method");
            while (employeeStack.Count > 0)
            {
                Employee employee = employeeStack.Pop();
                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the stack - {employeeStack.Count}");
            }

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine("---------------------------");
            Console.WriteLine("Retrieve Using Peek Method");

            for (int i = 0; i < 2; i++)
            {
                if (employeeStack.Count > 0)
                {
                    var employee = employeeStack.Peek();
                    Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                    Console.WriteLine($"Items left in the stack - {employeeStack.Count}");
                }
            }

            Console.WriteLine("---------------------------");

            bool containsEmployee3 = employeeStack.Contains(employee3);

            if (containsEmployee3 == true)
            {
                Console.WriteLine("Emp3 is in stack.");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack.");
            }

            Console.WriteLine();

            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee(101, "John", "Male", 37500));
            employeeList.Add(new Employee(102, "Simon", "Male", 66300));
            employeeList.Add(new Employee(103, "Lara", "Female", 53800));
            employeeList.Add(new Employee(104, "Leon", "Male", 52000));
            employeeList.Add(new Employee(105, "Ada", "Female", 48700));

            Employee employeeToCheck = new Employee(102, "Simon", "Male", 66300);
            if (employeeList.Contains(employeeToCheck))
            {
                Console.WriteLine("Employee 2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list.");
            }

            Employee firstMaleEmployee = employeeList.Find(e => e.Gender == "Male");
            Console.WriteLine($"\nId = {firstMaleEmployee.Id}, Name = {firstMaleEmployee.Name}, Gender = {firstMaleEmployee.Gender}, Salary = {firstMaleEmployee.Salary}");

            Console.WriteLine();
            List<Employee> maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
            foreach (var maleEmployee in maleEmployees)
            {
                Console.WriteLine($"Id = {maleEmployee.Id}, Name = {maleEmployee.Name}, Gender = {maleEmployee.Gender}, Salary = {maleEmployee.Salary}");
            }
        }
    }
}