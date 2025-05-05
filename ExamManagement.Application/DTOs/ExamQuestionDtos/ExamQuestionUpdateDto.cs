namespace ExamManagement.Application.DTOs.ExamQuestionDtos
{
    public class ExamQuestionUpdateDto
    {
        public int Id { get; set; }
        public int? ExamId { get; set; }
        public int? TeacherId { get; set; }
        public int? QuestionId { get; set; }

    }
}
