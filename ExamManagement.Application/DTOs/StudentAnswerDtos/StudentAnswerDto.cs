using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Application.DTOs.StudentExamDtos;

namespace ExamManagement.Application.DTOs.StudentAnswerDtos
{
    public class StudentAnswerDto
    {
		public int Id { get; set; }
		public string? StudentName { get; set; }
		public int? StudentExamId { get; set; }
		public string? ExamQuestionTitle { get; set; }
		public string? Answer { get; set; }
		public bool? IsCorrect { get; set; }
		public int? Point { get; set; }

		//Navigation
		public StudentExamDto? StudentExam { get; set; }
		public ExamQuestionDto? ExamQuestion { get; set; }
	}
}
