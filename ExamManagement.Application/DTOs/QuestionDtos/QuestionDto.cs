using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Application.DTOs.TeacherDtos;
using ExamManagement.Application.DTOs.ThemeDtos;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace ExamManagement.Application.DTOs.QuestionDtos
{
	public class QuestionDto
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? TeacherName { get; set; }
		public string? ThemeName { get; set; }
		public int? Point { get; set; }


		//Navigation
		public ThemeDto? Theme { get; set; }
		public TeacherDto? Teacher { get; set; }
		public List<ExamQuestionDto>? ExamQuestions { get; set; } = new();

		public List<string>? Options { get; set; } = new();
	}

	public class QuestionCreateDto
	{
		public required string Title { get; set; }
		public required int TeacherId { get; set; }
		public required int ThemeId { get; set; }
		public required int Point { get; set; }
		public required string OptionsJson { get; set; }

		//Navigation

		public List<ExamQuestionDto>? ExamQuestions { get; set; } = new();

	}

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
