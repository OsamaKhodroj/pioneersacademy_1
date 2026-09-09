using Domains.DTOs;
using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Interfaces
{
    public interface IUser
    {
        void Add(AddUserRequest request);
        bool Login(string emailAddress, string password);
    }
}
