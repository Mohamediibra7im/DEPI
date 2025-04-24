using CMS.BLL.DTO;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CMS.BLL.Manager
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepository _studentRepository;
        public StudentManager(IStudentRepository studentRepository)
        { _studentRepository = studentRepository; 

         }
        public void Add(StudentAddDto student)
        {
            var currentYear = DateTime.Now.Year;
            var lastStudent = _studentRepository
              .GetAll()
              .LastOrDefault();

            int nextId = 1;

            if (lastStudent != null)
            {
                var lastNumber = int.Parse(lastStudent.IdNumber.Substring(4)); // last 4 digits
                nextId = lastNumber + 1;
            }

            string newIdNumber = $"{currentYear}{nextId.ToString("D4")}";
            var studentModel = new Students
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                PhoneNumber = student.PhoneNumber,
                Address = student.Address,
                BirthDate = student.BirthDate,
                NationalId = student.NationalId,
                IdNumber =  newIdNumber

            };
            
            _studentRepository.Add(studentModel);
            _studentRepository.Save();
        }

        public IEnumerable<StudentReadDto> GetAll()
        {
            var studentModel = _studentRepository.GetAll();
            var studentDto = studentModel.Select(s=>new StudentReadDto {  FirstName = s.FirstName, LastName = s.LastName, IdNumber = s.IdNumber, Id = s.Id}).ToList();
            return studentDto;
        }

     public StudentReadDto GetById(int id)
        {
            var studentModel = _studentRepository.GetById(id);

            var studentDto = new StudentReadDto
            {
                FirstName = studentModel.FirstName,
                LastName = studentModel.LastName,
                IdNumber = studentModel.IdNumber,
                Id = studentModel.Id,
                GPA = studentModel.GPA

            };
            return studentDto;
        }

        

        public void Update(StudentUpdateDto student)
        {
            var studentModel = _studentRepository.GetById(student.Id);
            
            studentModel.FirstName = student.FirstName;
            studentModel.LastName = student.LastName;
            studentModel.PhoneNumber = student.PhoneNumber;
            studentModel.GPA = student.GPA;
            studentModel.Address = student.Address;
            studentModel.BirthDate = student.BirthDate;
            studentModel.NationalId = student.NationalId;

            _studentRepository.Update(studentModel);
            _studentRepository.Save();

        }

      
    }
    
    
}
