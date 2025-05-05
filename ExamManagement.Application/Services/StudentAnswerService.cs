using ExamManagement.Application.DTOs.StudentAnswerDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class StudentAnswerService : CrudManager<StudentAnswer, StudentAnswerDto, StudentAnswerCreateDto, StudentAnswerUpdateDto>
    {
    }
}
