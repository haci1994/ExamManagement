namespace ExamManagement.Application.DTOs.TeacherDtos
{
    public class TeacherUpdateDto
	{
		public int Id { get; set; }
		public required string Name { get; set; }
		public required string UserName { get; set; }
		public required string Password { get; set; }
	}
}
