using ExamManagement.Application.DTOs.ExamDtos;
using ExamManagement.Application.DTOs.StudentAnswerDtos;
using ExamManagement.Application.DTOs.StudentDtos;

namespace ExamManagement.Application.DTOs.StudentExamDtos
{
	public class StudentExamDto
	{

		public string? StudentName { get; set; }
		public required int ExamId { get; set; }
		public int? Score { get; set; }

		//Navigation
		public StudentDto? Student { get; set; }
		public ExamDto? Exam { get; set; }
		public List<StudentAnswerDto> StudentAnswers { get; set; } = new();
	}
}
