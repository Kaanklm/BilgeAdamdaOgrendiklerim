using LSP_Validate.Entity;
using LSP_Validate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.FirstName = "İrem";
            manager.LastName = "Pınar";
            manager.CalculatePerHourPrice(5);

            Employee employee = new Employee();
            employee.FirstName = "Abdulkadir";
            employee.LastName = "Gül";
            employee.CalculatePerHourPrice(2);
            employee.AssignManager(manager);

            Console.WriteLine($"{employee.FirstName} {employee.LastName} Maaş: {employee.Salary}USD/saat Müdür: {employee.Manager.FirstName}");

            BaseEmployee ceo = new President();
            ceo.FirstName = "İbrahim";
            ceo.LastName = "Kaçar";
            ceo.CalculatePerHourPrice(2);


            Console.Read();
        }
    }
}
