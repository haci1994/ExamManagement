using ExamManagement.Application.DTOs.StudentDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IStudentService : ICrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>
    {
        public int Login(string username, string password);
    }
}
