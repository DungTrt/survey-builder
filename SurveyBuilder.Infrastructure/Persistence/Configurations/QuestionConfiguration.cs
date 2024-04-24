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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1001, 1);
            builder.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            builder.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())");
            builder.Property(e => e.Description).HasMaxLength(500);
            builder.Property(e => e.Name)
                .HasMaxLength(255);
            builder.Property(x => x.Search).IsUnicode(false);
            builder.HasOne(x=>x.QuestionType)
                .WithMany(x=>x.Questions)
                .HasForeignKey(x=>x.QuestionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_QuestionType");
            builder.HasOne(x=>x.Survey)
                .WithMany(x=>x.Questions)
                .HasForeignKey(x=>x.SurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Question_Survey");

        }
    }
}
