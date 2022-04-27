using CNNCStorageDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNCStorageDB.Configurations
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Budget).IsRequired().HasDefaultValue(0);
            builder.Property(p => p.StartTime).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(p => p.EndTime).IsRequired().HasDefaultValue(DateTime.Now.AddHours(1));
            builder.Property(p => p.FinalPrice).IsRequired().HasDefaultValue(0);
        }
    }
}
