using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Opposite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hoşgeldin
            //Lütfen çalışan adı giriniz.
            //Fatih
            //Lütfen çalışan soyadı giriniz.
            //Günalp
            //Çalışan oluşturuldu. Ad: Fatih Soyad: Günalp

            //Single Responsibility Principle

            //Her nesnenin ya da metodun sadece 1 sorumluluğu olmalıdır, sadece o işi yapmalı ve o işten sorumlu olmalıdır. Böylece bir değişiklik yapıldığında sadece bir nedene dayandırılır.


            //Message/Greeting
            Console.WriteLine("Hoşgeldiniz!");

            //Add Method
            Employee employee = new Employee();

            //Validation
            Console.WriteLine("Lütfen çalışan adı giriniz");
            employee.FirstName = Console.ReadLine();

            if (string.IsNullOrEmpty(employee.FirstName))
            {
                Console.WriteLine("Çalışan adı boş geçilemez!");
                Console.ReadLine();
                return;
            }



            Console.WriteLine("Lütfen çalışan soyadını giriniz");
            employee.LastName = Console.ReadLine();

            if (string.IsNullOrEmpty(employee.LastName))
            {
                Console.WriteLine("Çalışan soyadı boş geçilemez!");
                Console.ReadLine();
                return;
            }

            //employee generator
            Console.WriteLine("Ad :" + employee.FirstName + " Soyad: " + employee.LastName);
            Console.Read();
        }
    }
}
