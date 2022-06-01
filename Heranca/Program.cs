using Heranca.Entities;
using System.Globalization;
namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of employees: ");
            int n  = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter with employee #{i} data: ");
                Console.Write("Outsourced, (y/n)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double addch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hour, value, addch));
                }
                else
                {
                    list.Add(new Employee(name, hour, value));
                }
              
            }
            Console.WriteLine();
            Console.WriteLine("Payment:");
            foreach (Employee e in list)
            {
                Console.WriteLine(e.Name + " - $" + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}