using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.LoadingOfNavigational.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public virtual List<Employee> Employees { get; set; }
    }
}
