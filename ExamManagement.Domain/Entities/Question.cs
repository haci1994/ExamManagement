using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace ExamManagement.Domain.Entities
{
    public class Question : BaseEntity
    {
        public required string Title { get; set; }
        public required int TeacherId { get; set; }
        public required int ThemeId { get; set; }
        public int Point { get; set; }
        public required string OptionsJson { get; set; }

        //Navigation
        public required Theme Theme { get; set; }
        public required Teacher Teacher { get; set; }
        public List<ExamQuestion> ExamQuestions { get; set; } = new();
        public List<StudentAnswer> StudentAnswers { get; set; } = new();
        [NotMapped]
        public List<string> Options
        {
            get
            {
                return JsonSerializer.Deserialize<List<string>>(OptionsJson)?? throw new InvalidOperationException("Unfortunately the list is null."); ;
            }
            set
            {
                OptionsJson = JsonSerializer.Serialize(value);
            }
        }


    }
}
