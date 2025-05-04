namespace ExamManagement.Domain.Entities
{
    public class BaseEntity
    {
        public required int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
