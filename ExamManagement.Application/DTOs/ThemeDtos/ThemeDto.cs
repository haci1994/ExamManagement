using ExamManagement.Application.DTOs.QuestionDtos;

namespace ExamManagement.Application.DTOs.ThemeDtos
{
	public class ThemeDto
	{
		public int Id { get; set; }
		public string? Name { get; set; }

		//Navigation
		public List<QuestionDto> Questions { get; set; } = new();
	}

	public class ThemeCreateDto
	{
		public required string Name { get; set; }

	}

	public class ThemeUpdateDto
	{
		public int Id { get; set; }
		public required string Name { get; set; }

	}
}
