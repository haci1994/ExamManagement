using ExamManagement.Application.DTOs.QuestionDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class QuestionService : CrudManager<Question, QuestionDto, QuestionCreateDto, QuestionUpdateDto>
    {
    }
}
