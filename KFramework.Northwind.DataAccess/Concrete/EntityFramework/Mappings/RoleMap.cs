﻿using KFramework.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap : EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {
            ToTable(@"Roles", @"dbo");
            HasKey(m => m.Id);

            Property(x => x.Name).HasColumnName("CategoryID");
        }
    }
}
