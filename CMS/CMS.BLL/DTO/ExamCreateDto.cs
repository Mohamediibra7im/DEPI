using CMS.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CMS.BLL.DTO
{
    public class ExamCreateDto
    {
        [Required]
        public string Examtype { get; set; }

        [Required]
        public int DurationMinutes { get; set; }

        [Required]
        public DateTime ExamDate { get; set; }

        [Required]
        public int TotalMarks { get; set; }

        [Required]
        public int CourseId { get; set; }

        public List<ExamQuestionCreateDto>? Questions { get; set; }
    }


}
