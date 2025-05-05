namespace ExamManagement.Application.DTOs.QuestionDtos
{
    public class QuestionCreateDto
	{
		public required string Title { get; set; }
		public required int TeacherId { get; set; }
		public required int ThemeId { get; set; }
		public required int Point { get; set; }
		public required string OptionsJson { get; set; }
		
	}
}
