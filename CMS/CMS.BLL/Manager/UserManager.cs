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
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;

        }
        public void Add(UserAddDto user)
        {
            var currentYear = DateTime.Now.Year;
            var lastUser = _userRepository
              .GetAll()
              .LastOrDefault();

            int nextId = 1;

            if (lastUser != null)
            {
                var lastNumber = int.Parse(lastUser.IdNumber.Substring(4)); // last 4 digits
                nextId = lastNumber + 1;
            }

            string newIdNumber = $"{currentYear}{nextId.ToString("D4")}";
            var userModel = new User
            {
                FullName = user.FullName,
                
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                BirthDate = user.BirthDate,
                NationalId = user.NationalId,
                IdNumber = newIdNumber

            };

            _userRepository.Add(userModel);
            _userRepository.Save();
        }

        public IEnumerable<UserReadDto> GetAll()
        {
            var userModel = _userRepository.GetAll();
            var userDto = userModel.Select(s => new UserReadDto { FullName = s.FullName,IdNumber = s.IdNumber, Id = s.Id }).ToList();
            return userDto;
        }

        public UserReadDto GetById(int id)
        {
            var userModel = _userRepository.GetSingle(u => u.Id == id, null);

            var userDto = new UserReadDto
            {
               
                FullName = userModel.FullName,
                IdNumber = userModel.IdNumber,
                Id = userModel.Id,
                GPA = userModel.GPA

            };
            return userDto;
        }



        public void Update(UserUpdateDto user)
        {
            var UserModel = _userRepository.GetSingle(u=> u.Id == user.Id);


            UserModel.FullName = user.FullName;
            UserModel.PhoneNumber = user.PhoneNumber;
            UserModel.GPA = user.GPA;
            UserModel.Address = user.Address;
            UserModel.BirthDate = user.BirthDate;
            UserModel.NationalId = user.NationalId;

            _userRepository.Update(UserModel);
            _userRepository.Save();

        }


    }


}
