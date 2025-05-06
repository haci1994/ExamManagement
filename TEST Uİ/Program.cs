using ExamManagement.Application.DTOs.ThemeDtos;
using ExamManagement.Application.Interfaces;
using ExamManagement.Application.Services;

namespace TEST_Uİ
{
    public class Program
    {

        static void Main(string[] args)
        {
            IThemeService themeServices = new ThemeService();

            var newTheme = new ThemeCreateDto { Name="Test"};

            themeServices.Add(newTheme);
        }
    }
}
