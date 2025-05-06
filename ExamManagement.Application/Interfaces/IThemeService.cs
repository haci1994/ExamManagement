using ExamManagement.Application.DTOs.ThemeDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Interfaces
{
    public interface IThemeService : ICrudManager<Theme, ThemeDto, ThemeCreateDto, ThemeUpdateDto>
    {       
    }
}
