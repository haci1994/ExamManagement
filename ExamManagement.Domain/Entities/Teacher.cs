namespace ExamManagement.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        //Navigation
        public List<ExamQuestion> ExamQuestions { get; set; } = new();
        public List<Question> Questions { get; set; } = new();
        public List<Exam> Exams { get; set; } = new();
    }
}
