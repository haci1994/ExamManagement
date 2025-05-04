namespace ExamManagement.Domain.Entities
{
    public class ExamQuestion : BaseEntity
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }

        //Navigation
        public Exam? Exam { get; set; }
        public Question? Question { get; set; }
    }
}
