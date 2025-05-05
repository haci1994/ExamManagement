using ExamManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamManagement.Infrastructure.EfCore.DataContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAnswer> StudentAnswers { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Theme> Themes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ExamManagement;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamQuestion>()
	.HasOne(eq => eq.Teacher)
	.WithMany(t => t.ExamQuestions)
	.HasForeignKey(eq => eq.TeacherId)
	.OnDelete(DeleteBehavior.Restrict); // <-- bunu əlavə et

			modelBuilder.Entity<ExamQuestion>()
				.HasOne(eq => eq.Question)
				.WithMany(q => q.ExamQuestions)
				.HasForeignKey(eq => eq.QuestionId)
				.OnDelete(DeleteBehavior.Restrict);
			base.OnModelCreating(modelBuilder);
        }
    }
}
