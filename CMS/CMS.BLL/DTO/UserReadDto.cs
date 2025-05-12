using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL.DTO
{
    public class UserReadDto
    {
        public int Id { get; set; }                      
        public string IdNumber { get; set; }
        public string FullName { get; set; }
        
        [NotMapped]
        public string Email => $"{IdNumber}@college.edu.eg".ToLower();

        public decimal GPA { get; set; }
    }
}
