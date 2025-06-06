﻿using CMS.Models;

namespace CMS.BLL
{
    public interface IUserService
    {
        Task<bool> UserExists(string email);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(Guid id);
        Task<User> GetUserByRefreshToken(string refreshToken);
        Task CreateUser(User user);
        Task UpdateUser(User user);

        Task<string> GetRoleByUserId(Guid id);
    }
}
