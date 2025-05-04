namespace ExamManagement.Domain.Entities
{
    public class StudentAnswer : BaseEntity
    {
        public int StudentId { get; set; }
        public int StudentExamId { get; set; }
        public int ExamQuestionId { get; set; }
        public required string Answer { get; set; }
        public required bool IsCorrect { get; set; }
        public int Point { get; set; }

        //Navigation
        public StudentExam? StudentExam { get; set; }
        public ExamQuestion? ExamQuestion { get; set; }
    }
}
