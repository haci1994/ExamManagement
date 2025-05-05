using ExamManagement.Application.DTOs.StudentDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class StudentService : CrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>
    {
    }

}
