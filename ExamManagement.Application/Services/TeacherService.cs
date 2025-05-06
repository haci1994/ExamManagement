using ExamManagement.Application.DTOs.TeacherDtos;
using ExamManagement.Application.Interfaces;
using ExamManagement.Application.Services;
using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;
using ExamManagement.Infrastructure.EfCore.Repositories;

namespace ExamManagement.Application.Services
{
    public class TeacherService : CrudManager<Teacher, TeacherDto, TeacherCreateDto, TeacherUpdateDto>, ITeacherService
    {
        public int Login(string username, string password)
        {
            var loginService = new TeacherRepository();

            int loggedInUser = loginService.GetUser(username, password);
            return loggedInUser;
        }
    }
}