using ExamManagement.Application.DTOs.QuestionDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IQuestionService : ICrudManager<Question, QuestionDto, QuestionCreateDto, QuestionUpdateDto>
    {
    }
}
