using ExamManagement.Application.DTOs.TeacherDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface ITeacherService : ICrudManager<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>
    {
        public int Login(string username, string password);
    }
}
