using Demo.LoadingOfNavigational.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.LoadingOfNavigational.Configurations
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);

            builder.Property(D => D.Name)
                   .HasColumnName("DeptName")
                   .HasColumnType("varchar")
                   .HasMaxLength(50);


        }
    }
}
