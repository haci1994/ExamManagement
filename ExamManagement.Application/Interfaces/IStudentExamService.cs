using ExamManagement.Application.DTOs.StudentExamDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IStudentExamService : ICrudManager<StudentExam, StudentExamDto, StudentExamCreateDto, StudentExamUpdateDto>
    {
    }
}
