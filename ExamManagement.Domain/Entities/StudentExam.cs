namespace ExamManagement.Domain.Entities
{
    public class StudentExam : BaseEntity
    {
        public required int StudentId { get; set; }
        public required int ExamId { get; set; }
        public int Score { get; set; }

        //Navigation
        public Student? Student { get; set; }
        public Exam? Exam { get; set; }
        public List<StudentAnswer> StudentAnswers { get; set; } = new();

    }
}
