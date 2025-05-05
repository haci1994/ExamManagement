using ExamManagement.Application.DTOs.StudentExamDtos;

namespace ExamManagement.Application.DTOs.StudentDtos
{
    public class StudentDto
    {
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }

		//Navigation
		public List<StudentExamDto> StudentExams { get; set; } = new();
	}
}
