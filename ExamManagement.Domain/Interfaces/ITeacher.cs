using ExamManagement.Domain.Entities;

namespace ExamManagement.Domain.Interfaces
{
    public interface ITeacher : IGenericInterface<Teacher>
    {
        public int GetUser(string username,string password);
    }
}
