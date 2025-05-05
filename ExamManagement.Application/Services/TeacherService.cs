using ExamManagement.Application.DTOs.TeacherDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class TeacherService : CrudManager<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>
    {
    }

}
