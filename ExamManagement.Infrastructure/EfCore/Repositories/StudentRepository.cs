using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;

namespace ExamManagement.Infrastructure.EfCore.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudent
    {
        public int GetUser(string username, string password)
        {
            Student loggedUser = new Student { Id = 0, Name = "test", Password = "123", UserName = "123" };

            foreach (var user in _context.Set<Student>().ToList())
            {
                if (user.UserName == username && user.Password == password)
                {
                    loggedUser = user;
                    break;
                }
            }

            return loggedUser.Id;
        }
    }
}
