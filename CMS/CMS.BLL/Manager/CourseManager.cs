using CMS.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using CMS.DataAccess.Repository.IRepository;
using CMS.Models;
using CMS.BLL.DTO;
using CMS.DataAccess.Repository;

namespace CMS.BLL.Manager
{
    public class CourseManager(ICourseRepository courseRepository, IExamRepository examRepository) : ICourseManager
    {
        public IEnumerable<GetCourseDTO> GetAllCourses()
        {
            var CourseModel = courseRepository.GetAll();
            var CourseDto = CourseModel.Select(s =>
            new GetCourseDTO
            {
                CourseCode = s.CourseCode,
                CourseName = s.CourseName,
                Credits = s.Credits,
                CourseId = s.CourseId
            })
                .ToList();
            return CourseDto;
        }

        public GetCourseDTO GetCourseById(int id)
        {
            var CourseModel = courseRepository.GetSingle(x => x.CourseId == id, null);
            var CourseDto = new GetCourseDTO
            {
                CourseCode = CourseModel.CourseCode,
                CourseName = CourseModel.CourseName,
                Credits = CourseModel.Credits,
                CourseId = CourseModel.CourseId
            };
            return CourseDto;
        }

        public void CreateCourse(CourseDTO courseDto)
        {

            var existingCourse = courseRepository.GetAll()
                .FirstOrDefault(c => c.CourseCode == courseDto.CourseCode);

            if (existingCourse != null)
            {
                throw new InvalidOperationException($"A course with code '{courseDto.CourseCode}' already exists.");
            }

            else
            {
                var course = new Courses
                {
                    CourseName = courseDto.CourseName,
                    CourseCode = courseDto.CourseCode,
                    Credits = courseDto.Credits
                };

                courseRepository.Add(course);
                courseRepository.Save();
            }
        }

        public IEnumerable<Exams> GetExamsForCourse(int courseId)
        {
            return examRepository.GetAll(
                e => e.CourseId == courseId,
                e => e.Course,
                e => e.ExamQuestions

            );
        }


        //public void UpdateCourse(CourseDTO courseDto)
        //{
        //    var courseModel = _courseRepository.GetById(courseDto.CourseId);

        //    courseModel.CourseId = courseDto.CourseId;
        //    courseModel.CourseName = courseDto.CourseName;
        //    courseModel.CourseCode = courseDto.CourseCode;
        //    courseModel.Credits = courseDto.Credits;


        //    _courseRepository.Update(courseModel);
        //    _courseRepository.Save();

        //}

        //public IEnumerable<Exams> GetCourseExams(int courseId)
        //{
        //    throw new NotImplementedException();
        //}


        //public async Task<Courses> UpdateCourseAsync(int id, CourseDTO courseDto)
        //{
        //    var course = await _courseRepository.GetByIdAsync(id);
        //    if (course == null)
        //        return null;

        //    course.CourseName = courseDto.CourseName;
        //    course.Credits = courseDto.Credits;

        //    await _courseRepository.UpdateAsync(course);
        //    await _courseRepository.SaveChangesAsync();
        //    return course;
        //}

        //public async Task<bool> DeleteCourseAsync(int id)
        //{
        //    var course = await _courseRepository.GetByIdAsync(id);
        //    if (course == null)
        //        return false;

        //    await _courseRepository.DeleteAsync(course);
        //    await _courseRepository.SaveChangesAsync();
        //    return true;
        //}

        //public async Task<IEnumerable<Courses>> GetCoursesByDepartmentAsync(int departmentId)
        //{
        //    return await _courseRepository.FindAsync(c => 
        //        c.Departments.Any(d => d.DepartmentID == departmentId));
        //}

        //public async Task<bool> AssignDepartmentToCourseAsync(int courseId, int departmentId)
        //{
        //    var course = await _courseRepository.GetByIdAsync(courseId);
        //    var department = await _departmentRepository.GetByIdAsync(departmentId);

        //    if (course == null || department == null)
        //        return false;

        //    if (!course.Departments.Contains(department))
        //    {
        //        course.Departments.Add(department);
        //        await _courseRepository.SaveChangesAsync();
        //    }

        //    return true;
        //}

        //public async Task<bool> RemoveDepartmentFromCourseAsync(int courseId, int departmentId)
        //{
        //    var course = await _courseRepository.GetByIdAsync(courseId);
        //    var department = await _departmentRepository.GetByIdAsync(departmentId);

        //    if (course == null || department == null)
        //        return false;

        //    if (course.Departments.Contains(department))
        //    {
        //        course.Departments.Remove(department);
        //        await _courseRepository.SaveChangesAsync();
        //    }

        //    return true;
        //}

        //public async Task<IEnumerable<Exams>> GetCourseExamsAsync(int courseId)
        //{
        //    return await _examRepository.FindAsync(e => e.CourseId == courseId);
        //}

        //public CourseDTO GetCourseById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void CreateCourse(CourseDTO courseAddDto)
        //{
        //    throw new NotImplementedException();
        //}

        //public void UpdateCourse(CourseDTO courseAddDto)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Exams> GetCourseExams(int courseId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}