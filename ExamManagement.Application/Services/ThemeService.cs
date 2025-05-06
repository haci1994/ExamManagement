using ExamManagement.Application.DTOs.ThemeDtos;
using ExamManagement.Application.Interfaces;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.Services
{
    public class ThemeService : CrudManager<Theme, ThemeDto, ThemeCreateDto, ThemeUpdateDto>, IThemeService
    {
    }

}
