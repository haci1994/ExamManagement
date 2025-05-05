
using AutoMapper;
using ExamManagement.Application.DTOs.ExamDtos;
using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Application.DTOs.QuestionDtos;
using ExamManagement.Application.DTOs.StudentAnswerDtos;
using ExamManagement.Application.DTOs.StudentDtos;
using ExamManagement.Application.DTOs.StudentExamDtos;
using ExamManagement.Application.DTOs.TeacherDtos;
using ExamManagement.Application.DTOs.ThemeDtos;
using ExamManagement.Domain.Entities;

namespace ExamManagement.Application.AutoMapping
{
    public class MappingProfile : Profile
    {
        MappingProfile()
        {
            CreateMap<Exam, ExamDto>()
                .ForMember(x => x.TeacherId, opt => opt.MapFrom(src => src.Teacher.Id))
                .ReverseMap();
            CreateMap<Exam, ExamCreateDto>()
                .ForMember(x => x.TeacherId, opt => opt.MapFrom(src=> src.Teacher.Id))
                .ReverseMap();
            CreateMap<Exam, ExamUpdateDto>().ReverseMap();

            CreateMap<ExamQuestion, ExamQuestionDto>()
                .ForMember(x => x.ExamId, opt => opt.MapFrom(src => src.Exam.Id))
                .ForMember(x => x.TeacherName, opt => opt.MapFrom(src => src.Teacher.Name))
                .ForMember(x => x.QuestionTitle, opt => opt.MapFrom(src => src.Question.Title))
                .ReverseMap();
            CreateMap<ExamQuestion, ExamQuestionCreateDto>().ReverseMap();
            CreateMap<ExamQuestion, ExamQuestionUpdateDto>().ReverseMap();

            CreateMap<Question, QuestionDto>()
                .ForMember(x => x.ThemeName, opt => opt.MapFrom(src => src.Theme.Name))
                .ForMember(x => x.TeacherName, opt => opt.MapFrom(src => src.Teacher.Name))
                .ReverseMap();
            CreateMap<Question, QuestionCreateDto>().ReverseMap();
            CreateMap<Question, QuestionUpdateDto>().ReverseMap();

            CreateMap<StudentAnswer, StudentAnswerDto>()
                .ForMember(x => x.StudentName, opt => opt.MapFrom(src => src.StudentExam.Student.Name))
                .ForMember(x => x.StudentExamId, opt => opt.MapFrom(src => src.StudentExam.Id))
                .ForMember(x => x.ExamQuestionTitle, opt => opt.MapFrom(src => src.ExamQuestion.Question.Title))
                .ReverseMap();
            CreateMap<StudentAnswer, StudentAnswerCreateDto>().ReverseMap();
            CreateMap<StudentAnswer, StudentAnswerUpdateDto>().ReverseMap();

            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Student, StudentCreateDto>().ReverseMap();
            CreateMap<Student, StudentUpdateDto>().ReverseMap();

            CreateMap<StudentExam, StudentExamDto>()
                .ForMember(x => x.StudentName, opt => opt.MapFrom(src => src.Student.Name))
                .ForMember(x => x.ExamId, opt => opt.MapFrom(src => src.Exam.Id))
                .ReverseMap();
            CreateMap<StudentExam, StudentExamCreateDto>().ReverseMap();
            CreateMap<StudentExam, StudentExamUpdateDto>().ReverseMap();

            CreateMap<Teacher, TeacherDto>().ReverseMap();
            CreateMap<Teacher, TeacherCreateDto>().ReverseMap();
            CreateMap<Teacher, TeacherUpdateDto>().ReverseMap();

            CreateMap<Theme, ThemeDto>().ReverseMap();
            CreateMap<Theme, ThemeCreateDto>().ReverseMap();
            CreateMap<Theme, ThemeUpdateDto>().ReverseMap();
        }
    }
}
