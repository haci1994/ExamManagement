using ExamManagement.Application.DTOs.ExamDtos;
using ExamManagement.Application.DTOs.QuestionDtos;
using ExamManagement.Application.DTOs.StudentAnswerDtos;
using ExamManagement.Application.DTOs.TeacherDtos;

namespace ExamManagement.Application.DTOs.ExamQuestionDtos
{
    public class ExamQuestionDto
    {
        public int Id { get; set; }
        public int? ExamId { get; set; }
        public string? TeacherName { get; set; }
        public int? QuestionTitle { get; set; }

        //Navigation
        public ExamDto? Exam { get; set; }
        public TeacherDto? Teacher { get; set; }
        public QuestionDto? Question { get; set; }
        List<StudentAnswerDto>? StudentAnswers { get; set; } = new();
    }
}
