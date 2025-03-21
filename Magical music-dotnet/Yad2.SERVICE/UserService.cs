using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using MagicalMusic.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.SERVICE
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;


        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllAsync() => await _userRepository.GetAllAsync();
        public async Task<User> GetByIdAsync(int id) => await _userRepository.GetByIdAsync(id);
        public async Task<User> AddAsync(UserDTO user)
        {
            var userMap = _mapper.Map<User>(user);
            return await _userRepository.AddAsync(userMap);
        }
        public async Task<User> UpdateAsync(int id, UserDTO user)
        {
            var userMap = _mapper.Map<User>(user);
            return await _userRepository.UpdateAsync(id, userMap);
        }
        public async Task DeleteAsync(int id) => await _userRepository.DeleteAsync(id);
        public User Authenticate(string userName, string userPassword)
        {
            // אם שם המשתמש והסיסמה הם ruty → המשתמש מנהל
            if (userName == "ruty" && userPassword == "rha1828!")
            {
                return new User
                {
                    Name = userName,
                    Password = userPassword,
                    Role = "manager"
                };
            }

            // בדיקה אם המשתמש קיים במאגר הנתונים
            var user = _userRepository.GetUserByCredentials(userName, userPassword);
            if (user != null)
            {
                user.Role = "user"; // משתמש רגיל
                return user;
            }

            // אם המשתמש לא נמצא במערכת → הוא "צופה"
            return new User
            {
                Name = userName,
                Password = userPassword,
                Role = "viewer" // תפקיד "צופה"
            };
        }

    }
}
