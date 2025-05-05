using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Application.DTOs.StudentExamDtos;

namespace ExamManagement.Application.DTOs.ExamDtos
{
    public class ExamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public List<StudentExamDto> StudentExams { get; set; } = new();
        public List<ExamQuestionDto> ExamQuestions { get; set; } = new();
    }
}
