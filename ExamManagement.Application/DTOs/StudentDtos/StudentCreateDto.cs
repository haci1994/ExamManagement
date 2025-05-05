namespace ExamManagement.Application.DTOs.StudentDtos
{
    public class StudentCreateDto
	{
		public required string Name { get; set; }
		public required string UserName { get; set; }
		public required string Password { get; set; }
	}
}
