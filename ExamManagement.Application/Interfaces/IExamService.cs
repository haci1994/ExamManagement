using ExamManagement.Application.DTOs.ExamDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IExamService : ICrudManager<Exam, ExamDto, ExamCreateDto, ExamUpdateDto>
    {
    }
}
