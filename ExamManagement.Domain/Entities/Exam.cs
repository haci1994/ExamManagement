namespace ExamManagement.Domain.Entities
{
    public class Exam : BaseEntity
    {
        public required string Name { get; set; }
        public required int TeacherId { get; set; }
        public required bool Done { get; set; } = false;
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        //Navigation
        public Teacher Teacher { get; set; }
        public List<StudentExam> StudentExams { get; set; } = new();
        public List<ExamQuestion> ExamQuestions { get; set; } = new();
    }
}
