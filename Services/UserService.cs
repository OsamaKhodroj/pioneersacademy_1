using Domains.DTOs;
using Domains.Entities;
using Domains.Interfaces;
using Infrastactures;
using Mapster;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService : IUser
    {
        private string _senderPhoneNumber = string.Empty;


        private List<User> _users;

        public UserService()
        {
            if (_users == null)
            {
                _users = new List<User>();
            }
        }

        public void Add(AddUserRequest request)
        {
            var userData = request.Adapt<User>();

            userData.CreatedDate = DateTime.Now;
            userData.UserType = Domains.Enums.UserTypeEnum.User;
            userData.IsDelete = false;
            userData.Password = EncryptionHelper.Encryption(userData.Password);


            string userName = "Osama Ali"; 
            Console.WriteLine(userName.GetStringCount());





            _users.Add(userData);
        }

        public bool Login(string emailAddress, string password)
        {
            var user = _users.Where(q => q.EmailAddress == emailAddress)
                .FirstOrDefault();

            if (user != null)
            {
                var isCorrectPassword = EncryptionHelper.Verify(password, user.Password);
                if (isCorrectPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public GetUserInfoResponse GetUserInfo(Guid id)
        {
            GetUserInfoResponse? result = _users.Where(q => q.Id == id)
                .Select(q => new GetUserInfoResponse()
                {
                    UserId = q.Id,
                    FullName = q.FullName

                })
                .FirstOrDefault();
             
            return result;
        }

        public Tuple<int, string> GetUserInfo()
        {
            return Tuple.Create(10, "Osama");
        }
    }
}
