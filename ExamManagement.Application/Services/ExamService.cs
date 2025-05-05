using ExamManagement.Application.DTOs.ExamDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class ExamService : CrudManager<Exam, ExamDto, ExamCreateDto, ExamUpdateDto>
    {
    }
}
