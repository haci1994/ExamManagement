namespace ExamManagement.Domain.Entities
{
    public class Exam : BaseEntity
    {
        public required int TeacherId { get; set; }

        //Navigation
        public Teacher? Teacher { get; set; }
        public List<StudentExam> StudentExams { get; set; } = new();
        public List<ExamQuestion> ExamQuestions { get; set; } = new();
    }
}
