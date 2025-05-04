namespace ExamManagement.Domain.Entities
{
    public class StudentAnswer : BaseEntity
    {
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
        public required string Answer { get; set; }
        public required bool IsCorrect { get; set; }
        public int Point { get; set; }

        //Navigation
        public Student? Student { get; set; }
        public Question? Question { get; set; }
    }
}
