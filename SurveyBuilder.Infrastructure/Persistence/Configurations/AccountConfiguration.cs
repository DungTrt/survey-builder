using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SurveyBuilder.Infrastructure.Persistence.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.Property(x => x.BusinessName).HasMaxLength(500);
            builder.Property(x => x.Name).HasMaxLength(500);
            builder.Property(x => x.FirstName).HasMaxLength(255);
            builder.Property(x => x.Function).HasMaxLength(255);
            builder.Property(x => x.Service).HasMaxLength(255);           
            builder.Property(x => x.Email).HasMaxLength(255).IsUnicode(false);
            builder.Property(x=>x.Password).HasMaxLength(500).IsUnicode(false);
            builder.Property(x=>x.Such).HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.CompanyCustomerCode).HasMaxLength(255);
            builder.Property(x => x.IndividualCustomer).HasMaxLength(255);           
            builder.Property(x => x.AuthorizeEmailContact).HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.AuthorizeContactTel).HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.LockEnabled).HasDefaultValue(0);
            builder.Property(x => x.AccessFailedCount).HasDefaultValue(0);
            builder.Property(x => x.Search).IsUnicode(false);
            builder.HasOne(x => x.AccountType)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_AccountType");

            builder.HasOne(x => x.AccountStatus)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.AccountStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_AccountStatus");
            builder.HasOne(x => x.AccountCategory)
                .WithMany(x => x.Accounts)
                .HasForeignKey(x => x.AccountCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_AccountCategory");
        }
    }
}
