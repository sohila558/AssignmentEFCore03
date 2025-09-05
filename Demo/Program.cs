using Demo.Contexts;
using Demo.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 Ways To Genereate Scheme
            // 1. TPC  : Table Per Class
            // 2. TPH  : Table Per Hierarchy
            // 3. TPCC : Table Per Concrete Class

            AppDbContext context = new AppDbContext();

            //FullTimeEmployee fullTime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    Salary = 12000
            //};

            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    Salary = 15000
            //};

            //FullTimeEmployee fullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Mariam Khaled",
            //    Address = "Giza",
            //    Email = "MariamKhaled@gmail.com",
            //    Salary = 15000
            //};

            //PartTimeEmployee partTime01 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    HourRate = 300,
            //    NumberOfHours = 120
            //};

            //PartTimeEmployee partTime02 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    HourRate = 200,
            //    NumberOfHours = 200
            //};

            //PartTimeEmployee partTime03 = new PartTimeEmployee()
            //{
            //    Name = "Mariam Khaled",
            //    Address = "Giza",
            //    Email = "MariamKhaled@gmail.com",
            //    HourRate = 300,
            //    NumberOfHours = 250
            //};

            //context.FullTimeEmployees.Add(partTime01);

            //context.SaveChanges();

            var Result = context.Employees.OfType<FullTimeEmployee>();

            foreach (var item in Result)
            {
                Console.WriteLine(item.Name);
            }



        }
    }
}
