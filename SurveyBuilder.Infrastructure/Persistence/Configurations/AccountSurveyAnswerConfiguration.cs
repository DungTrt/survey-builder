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
    public class AccountSurveyAnswerConfiguration : IEntityTypeConfiguration<AccountSurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<AccountSurveyAnswer> builder)
        {
            builder.ToTable("AccountSurveyAnswer");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.HasOne(x => x.AccountSurvey)
                .WithMany(x => x.AccountSurveyAnswers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(x => x.AccountSurveyId)
                .HasConstraintName("FK_AccountSurveyAnswer_AccountSurvey");
            builder.HasOne(x => x.Answer)
                .WithMany(x => x.AccountSurveyAnswers)
                .OnDelete(DeleteBehavior.SetNull)
                .HasForeignKey(x => x.AnswerId)
                .HasConstraintName("FK_AccountSurveyAnswer_Answer");
        }
    }
}
