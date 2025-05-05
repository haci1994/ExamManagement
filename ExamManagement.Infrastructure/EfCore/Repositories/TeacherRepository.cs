using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;
using ExamManagement.Infrastructure.EfCore.DataContext;

namespace ExamManagement.Infrastructure.EfCore.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacher
    {
        
        public int GetUser(string username, string password)
        {
            Teacher loggedUser = new Teacher { Id = 0, Name = "test", Password = "123", UserName = "123" };           

            foreach (var user in _context.Set<Teacher>().ToList())
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
