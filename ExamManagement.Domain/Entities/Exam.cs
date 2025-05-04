namespace ExamManagement.Domain.Entities
{
    public class Exam : BaseEntity
    {
        
        //Navigation
        public List<StudentExam> StudentExams { get; set; } = new();
        public List<ExamQuestion> ExamQuestions { get; set; } = new();
    }
}
