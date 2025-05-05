namespace ExamManagement.Application.DTOs.ExamDtos
{
    public class ExamCreateDto
	{
		public required string Name { get; set; }
		public int TeacherId { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
    }
}
