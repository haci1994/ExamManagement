namespace ExamManagement.Application.DTOs.StudentExamDtos
{
    public class StudentExamCreateDto
	{
		public required int StudentId { get; set; }
		public required int ExamId { get; set; }
		public int? Score { get; set; }
		
	}
}
