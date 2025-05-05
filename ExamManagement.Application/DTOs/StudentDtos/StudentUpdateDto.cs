namespace ExamManagement.Application.DTOs.StudentDtos
{
    public class StudentUpdateDto
	{
		public required string Id { get; set; }
		public string? Name { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
	}
}
