using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;
using ExamManagement.Infrastructure.EfCore.DataContext;

namespace ExamManagement.Infrastructure.EfCore.Repositories
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacher
    {
        private readonly AppDbContext _dataContext;
        private readonly List<Teacher> _teacherTable;
        TeacherRepository()
        {
            _dataContext = new AppDbContext();
            _teacherTable = _dataContext.Set<Teacher>().ToList();
        }
        public int GetUser(string username, string password)
        {
            Teacher loggedUser = new Teacher { Id = 0, Name = "test", Password = "123", UserName = "123" };           

            foreach (var user in _teacherTable)
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
