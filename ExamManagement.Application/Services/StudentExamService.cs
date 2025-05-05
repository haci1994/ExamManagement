using ExamManagement.Application.DTOs.StudentExamDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class StudentExamService : CrudManager<StudentExam, StudentExamDto, StudentExamCreateDto, StudentExamUpdateDto>
    {
    }

}
