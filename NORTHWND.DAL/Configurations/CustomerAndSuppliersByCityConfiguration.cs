﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NORTHWND.Core.Entities;

namespace NORTHWND.DAL.Configurations
{
    internal class CustomerAndSuppliersByCityConfiguration : IEntityTypeConfiguration<CustomerAndSuppliersByCity>
    {
        public void Configure(EntityTypeBuilder<CustomerAndSuppliersByCity> entity)
        {
            entity.HasNoKey();

            entity.ToView("Customer and Suppliers by City");

            entity.Property(e => e.City).HasMaxLength(15);

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.ContactName).HasMaxLength(30);

            entity.Property(e => e.Relationship)
                .IsRequired()
                .HasMaxLength(9)
                .IsUnicode(false);
        }

    }
}
