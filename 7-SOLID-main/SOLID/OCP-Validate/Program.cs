using OCP_Validate.Abstract;
using OCP_Validate.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEntity> persons = new List<IEntity>
            {
                new Person{FirstName="Abdulkadir",LastName="Gül"},
                new Manager{FirstName="İrem",LastName="Pınar"},
                new Employee{FirstName="İbrahim",LastName="Kaçar"},
                new Represant{FirstName="Ali",LastName="Kardaş"}
            };

            List<Employee> employees = new List<Employee>();

            foreach (var person in persons)
            {
                employees.Add(person.GenerateAccount.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"Ad: {employee.FirstName} Soyad: {employee.LastName} Email: {employee.Email} Müdür: {employee.IsManager} Temsilci :{employee.IsRepresant}");
            }
            Console.ReadLine();

        }
    }
}
