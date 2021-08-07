using System;
using CorporateClass.Corporation;

namespace CorporateClass
{
    class Program
    {
        static void AddEmplooyees(ref Company company)
        {
            string name;
            string title;
            bool exit = false;
            ConsoleKeyInfo inputKey;
            while (!exit)
            {
                Console.WriteLine("     Select option");
                Console.WriteLine("       1) enter new employee");
                Console.WriteLine("       2) remove employee");
                Console.WriteLine("       x) exit Employee entry mode");
                Console.Write("     ");
                inputKey = Console.ReadKey(true);
                switch (inputKey.KeyChar)
                {
                    case '1':
                        Console.WriteLine(" ");
                        Console.Write("     Employee name: ");
                        name = Console.ReadLine();
                        Console.Write("     Employee title: ");
                        title = Console.ReadLine();
                        Employee tmpEmployee = new Employee(name, title, DateTime.Now);
                        company.AddEmployee(tmpEmployee);
                        break;
                    case '2':
                        Console.WriteLine(" ");
                        Console.Write("     Employee name: ");
                        name = Console.ReadLine();
                        if (company.RemoveEmployee(name)) {
                            Console.WriteLine($"     {name} has been removed from {company.Name}\n");
                        } else
                        {
                            Console.WriteLine($"     {name} not found");
                        }
                        break;
                    case 'x':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            string company;
            Console.WriteLine("     Welcome to Corporate Class");
            Console.WriteLine("     Enter company name:");
            Console.Write("     ");
            company = Console.ReadLine();
            Company company1 = new Company(company, DateTime.Now);
            Console.WriteLine("\n     {0:25}, created at {1:MM/dd/yy H:mm/s/zzz}\n", company1.Name, company1.CreatedOn);
            Console.WriteLine("     Add employees");
            AddEmplooyees(ref company1);
            Console.Write('\n');
            company1.ListEmployees();
            Console.Write('\n');

        }
    }
}
