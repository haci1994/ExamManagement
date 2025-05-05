using ExamManagement.Domain.Entities;

namespace ExamManagement.Domain.Interfaces
{
    public interface ITeacher : IGenericInterface<Teacher>
    {
        public Teacher GetUser(string username,string password);
    }
}
