namespace ExamManagement.Domain.Entities
{
    public class Student : BaseEntity
    {
        public required string Name { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

        //Navigation
        public List<StudentExam> StudentExams { get; set; } = new();
    }
}
