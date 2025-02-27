﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Infrastructure.Persistence.Configurations
{
    public class AccountStatusConfiguration : IEntityTypeConfiguration<AccountStatus>
    {
        public void Configure(EntityTypeBuilder<AccountStatus> builder)
        {
            builder.ToTable("AccountStatus");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.Color).HasMaxLength(20);
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.Name)
                .HasMaxLength(255);
        }
    }
}
