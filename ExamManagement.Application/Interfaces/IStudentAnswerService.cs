using ExamManagement.Application.DTOs.StudentAnswerDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IStudentAnswerService : ICrudManager<StudentAnswer, StudentAnswerDto, StudentAnswerCreateDto, StudentAnswerUpdateDto>
    {
    }
}
