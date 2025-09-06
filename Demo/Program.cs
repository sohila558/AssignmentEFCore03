using Demo.LoadingOfNavigational.Contexts;
using Demo.LoadingOfNavigational.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Example
            // 3 Ways To Genereate Scheme
            // 1. TPC  : Table Per Class
            // 2. TPH  : Table Per Hierarchy
            // 3. TPCC : Table Per Concrete Class

            //using AppDbContext context = new AppDbContext();

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

            //var Result = context.Employees.OfType<FullTimeEmployee>();

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region Loading Navigational Property
            //using AppDbContext context = new AppDbContext();

            ////var department = new List<Department>()
            ////{
            ////    new Department() {Name = "HR"},
            ////    new Department() {Name = "PR"},
            ////    new Department() {Name = "IT"}
            ////};

            ////var employees = new List<Employee>()
            ////{
            ////    new Employee(){Name = "Ahmed Ali", Address = "Cairo", Age = 29, Salary = 12000, DeptId = 100},
            ////    new Employee(){Name = "Omar Ali", Address = "Giza", Age = 32, Salary = 15000, DeptId = 100},
            ////    new Employee(){Name = "Mona Ali", Address = "Cairo", Age = 25, Salary = 13000, DeptId = 100},
            ////    new Employee(){Name = "Ahmed Khaled", Address = "Namsr City", Age = 30, Salary = 17000, DeptId = 200},
            ////    new Employee(){Name = "Mariam Ahmed", Address = "Alex", Age = 24, Salary = 10000, DeptId = 200},
            ////    new Employee(){Name = "Mohamed Ali", Address = "Alex", Age = 25, Salary = 14000, DeptId = 300},
            ////    new Employee(){Name = "Maha Ahmed", Address = "Cairo", Age = 33, Salary = 18000, DeptId = 100}
            ////};

            ////context.Departments.AddRange(department);

            ////context.Employees.AddRange(employees);

            ////context.SaveChanges();

            ////var Employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(Employee?.Id);
            ////Console.WriteLine(Employee?.Name ?? "NA");
            ////Console.WriteLine(Employee?.Salary ?? 0.0f);
            ////Console.WriteLine(Employee?.Age);
            ////Console.WriteLine(Employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(Employee?.DeptId ?? 0);
            ////Console.WriteLine(Employee?.WorkFor?.Name ?? "NA");

            //// NOTE : EF Core Don't Loading Any Navigational Property

            //// EF Core Loading Navigational Property
            //// 1. Explicit Loading
            //// 2. Eager Loading
            //// 3. Lazy Loading


            //#region Explicit Loading
            //// 1. Explicit Loading

            ////var Employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////context.Entry(Employee).Reference("WorkFor").Load(); // Explicit Loading 
            ////context.Entry(Employee).Reference(nameof(Employee.WorkFor)).Load();
            ////context.Entry(Employee).Reference(E => E.WorkFor).Load();

            ////Console.WriteLine(Employee?.Id);
            ////Console.WriteLine(Employee?.Name ?? "NA");
            ////Console.WriteLine(Employee?.Salary ?? 0.0f);
            ////Console.WriteLine(Employee?.Age);
            ////Console.WriteLine(Employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(Employee?.DeptId ?? 0);
            ////Console.WriteLine(Employee?.WorkFor?.Name ?? "NA");

            ////var Department = context.Departments.FirstOrDefault(D => D.Id == 100);

            ////context.Entry(Department).Collection(D => D.Employees).Load(); // Explicit Loading

            ////Console.WriteLine(Department.Name);

            ////foreach (var item in Department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion

            //#region Eager Loading
            //// 2. Eager Loading

            ////var Employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(Employee?.Id);
            ////Console.WriteLine(Employee?.Name ?? "NA");
            ////Console.WriteLine(Employee?.Salary ?? 0.0f);
            ////Console.WriteLine(Employee?.Age);
            ////Console.WriteLine(Employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(Employee?.DeptId ?? 0);
            ////Console.WriteLine(Employee?.WorkFor?.Name ?? "NA");

            ////var Department = context.Departments.Include(D => D.Employees).FirstOrDefault(D => D.Id == 100);


            ////Console.WriteLine(Department.Name);

            ////foreach (var item in Department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion

            //#region Lazy Loading

            //// 3. Lazy Loading
            //// 3.1. Install Package Proxies
            //// 3.2. Updata OnConfiguring(), Use UseLazyLoadingProxies()
            //// 3.3. Make All Entities Public
            //// 3.4. Make All Navigational Property Virtual

            ////var Employee = context.Employees.FirstOrDefault(E => E.Id == 10);

            ////Console.WriteLine(Employee?.Id);
            ////Console.WriteLine(Employee?.Name ?? "NA");
            ////Console.WriteLine(Employee?.Salary ?? 0.0f);
            ////Console.WriteLine(Employee?.Age);
            ////Console.WriteLine(Employee?.HiringDate ?? DateTime.Now);
            ////Console.WriteLine(Employee?.DeptId ?? 0);
            ////Console.WriteLine(Employee?.WorkFor?.Name ?? "NA");

            ////var Department = context.Departments.FirstOrDefault(D => D.Id == 100);


            ////Console.WriteLine(Department.Name);

            ////foreach (var item in Department.Employees)
            ////{
            ////    Console.WriteLine(item.Name);
            ////} 
            //#endregion 
            #endregion




        }
    }
}
