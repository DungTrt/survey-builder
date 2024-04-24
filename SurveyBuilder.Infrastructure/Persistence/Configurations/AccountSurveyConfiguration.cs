using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SurveyBuilder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyBuilder.Infrastructure.Persistence.Configurations
{
    public class AccountSurveyConfiguration : IEntityTypeConfiguration<AccountSurvey>
    {
        public void Configure(EntityTypeBuilder<AccountSurvey> builder)
        {
            builder.ToTable("AccountSurvey");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.HasOne(x => x.Account)
                .WithMany(x => x.AccountSurveys)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(x => x.AccountId)
                .HasConstraintName("FK_AccountSurvey_Account");
            builder.HasOne(x => x.Survey)
                .WithMany(x => x.AccountSurveys)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(x => x.SurveyId)
                .HasConstraintName("FK_AccountSurvey_Role");
        }
    }
}
