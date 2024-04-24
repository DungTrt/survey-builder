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
    public class UploadAnswerHistoryConfiguration : IEntityTypeConfiguration<UploadAnswerHistory>
    {
        public void Configure(EntityTypeBuilder<UploadAnswerHistory> builder)
        {
            builder.ToTable("UploadAnswerHistory");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.Property(x => x.FileName).HasMaxLength(500);
            builder.Property(x => x.Path).HasMaxLength(1000);
            builder.HasOne(x => x.Account)
                .WithMany(x => x.UploadAnswerHistories)
                .HasForeignKey(x => x.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UploadAnswerHistory_Account");
        }
    }
}
