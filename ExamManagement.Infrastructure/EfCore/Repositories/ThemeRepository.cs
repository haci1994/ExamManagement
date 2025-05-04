using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;

namespace ExamManagement.Infrastructure.EfCore.Repositories
{
    public class ThemeRepository : GenericRepository<Theme>, ITheme
    {
    }
}
