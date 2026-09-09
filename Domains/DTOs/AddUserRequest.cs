using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.DTOs
{
    public class AddUserRequest
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
