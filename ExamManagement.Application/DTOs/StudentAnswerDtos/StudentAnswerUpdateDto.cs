namespace ExamManagement.Application.DTOs.StudentAnswerDtos
{
    public class StudentAnswerUpdateDto
	{
		public int Id {get; set; }
		public required int StudentId { get; set; }
		public required int StudentExamId { get; set; }
		public required int ExamQuestionId { get; set; }
		public required string Answer { get; set; }
		public bool? IsCorrect { get; set; }
		public required int Point { get; set; }
	}
}
