using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TALMS.Domain.Entities;

namespace Infrastructure.Persistence.Configurations
{
    public class FeedBackQuestionConfiguration : IEntityTypeConfiguration<FeedBackQuestion>
    {
        public void Configure(EntityTypeBuilder<FeedBackQuestion> entity)
        {
            entity.ToTable("FeedBack_Question");

            entity.HasIndex(e => e.FeedBackId)
                .HasName("IDX_FeedBack-Question_FeedBackID");

            entity.HasIndex(e => e.QuestionsId)
                .HasName("IDX_FeedBack-Question_QuestionID");

            entity.Property(e => e.FeedBackQuestionId).HasColumnName("FeedBack_QuestionID");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.FeedBackId).HasColumnName("FeedBackID");

            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_name())");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.QuestionsId).HasColumnName("QuestionsID");

            entity.HasOne(d => d.Questions)
                .WithMany(p => p.FeedBackQuestion)
                .HasForeignKey(d => d.QuestionsId)
                .HasConstraintName("FK__FeedBack_QuestionsID");
        }
    }
}