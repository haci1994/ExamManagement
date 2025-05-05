namespace ExamManagement.Application.DTOs.QuestionDtos
{
    public class QuestionUpdateDto
	{
		public int Id { get; set; }
		public required string Title { get; set; }
		public required int TeacherId { get; set; }
		public required int ThemeId { get; set; }
		public required int Point { get; set; }
		public required string OptionsJson { get; set; }

	}
}
