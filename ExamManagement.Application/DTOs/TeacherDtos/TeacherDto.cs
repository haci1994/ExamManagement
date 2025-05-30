﻿using ExamManagement.Application.DTOs.ExamQuestionDtos;
using ExamManagement.Application.DTOs.QuestionDtos;

namespace ExamManagement.Application.DTOs.TeacherDtos
{
	public class TeacherDto
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }

		//Navigation
		public List<ExamQuestionDto> ExamQuestions { get; set; } = new();
		public List<QuestionDto> Questions { get; set; } = new();
	}
}
