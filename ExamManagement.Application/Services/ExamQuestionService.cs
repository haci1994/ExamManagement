using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class ExamQuestionService : CrudManager<ExamQuestion, ExamQuestionDto, ExamQuestionCreateDto, ExamQuestionUpdateDto>
    {
    }
}
