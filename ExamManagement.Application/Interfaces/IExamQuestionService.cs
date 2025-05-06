using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IExamQuestionService : ICrudManager<ExamQuestion, ExamQuestionDto, ExamQuestionCreateDto, ExamQuestionUpdateDto>
    {
    }
}
