using ExamManagement.Application.DTOs.StudentDtos;
using ExamManagement.Domain.Entities;
using ExamManagement.Infrastructure.EfCore.Repositories;

namespace ExamManagement.Application.Services
{
    public class StudentService : CrudManager<Student, StudentDto, StudentCreateDto, StudentUpdateDto>
    {
        public int Login(string username, string password)
        {
            var loginService = new StudentRepository();

            int loggedInUser = loginService.GetUser(username, password);
            return loggedInUser;
        }
    }

}
