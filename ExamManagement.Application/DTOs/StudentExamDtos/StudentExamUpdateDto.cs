namespace ExamManagement.Application.DTOs.StudentExamDtos
{
    public class StudentExamUpdateDto
	{
		public int Id { get; set; }
		public int? StudentId { get; set; }
		public int? ExamId { get; set; }
		public int? Score { get; set; }

	}
}
