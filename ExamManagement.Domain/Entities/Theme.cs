namespace ExamManagement.Domain.Entities
{
    public class Theme : BaseEntity
    {
        public required string Name { get; set; }

        //Navigation
        public List<Question> Questions { get; set; } = new();
    }
}
