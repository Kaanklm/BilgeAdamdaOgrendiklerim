using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Opposite
{
    class Program
    {

        //Nesneler ya da metotlar genişlemeye açık ancak değişikliğe kapalı olmalıdır. Projede önceden yazılan kodları değiştirerek değil, var olan kodlar üzerinde eklemeler yaparak sorunları çözmeliyiz.
       

        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User{FirstName="Nancy",LastName="Davoilo",Title=EmployeeTitle.Represant},
                new User{FirstName="Andrew",LastName="Fuller",Title=EmployeeTitle.Manager}
            };

            List<Employee> employees = new List<Employee>();

            GenerateAccount generateAccount = new GenerateAccount();
            foreach (User user in users)
            {

                employees.Add(generateAccount.AddEmployee(user));
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Ad: {employee.FirstName} Soyad: {employee.LastName} Email: {employee.Email} Müdür: {employee.IsManager} Temsilci: {employee.IsRepresant} Koordinator: {employee.IsCoordinator}");
            }

            Console.ReadLine();
        }
    }
}
