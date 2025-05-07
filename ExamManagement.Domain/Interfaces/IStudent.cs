using ExamManagement.Domain.Entities;

namespace ExamManagement.Domain.Interfaces
{
    public interface IStudent : IGenericInterface<Student>
    {
        public int GetUser(string username, string password);
    }
}
