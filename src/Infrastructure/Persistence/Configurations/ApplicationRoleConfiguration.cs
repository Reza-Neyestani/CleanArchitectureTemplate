﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name).IsRequired().HasMaxLength(50);
            builder.Property(r => r.NormalizedName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.ConcurrencyStamp).IsRequired().HasMaxLength(50);

            builder.Property(r => r.CreatedBy).IsRequired().HasMaxLength(10);
            builder.Property(r => r.Created).IsRequired();
            builder.Property(r => r.LastModifiedBy).IsRequired(false).HasMaxLength(10);
            builder.Property(r => r.LastModified).IsRequired(false);
            builder.Property(r => r.IsDeleted).IsRequired();
        }
    }
}