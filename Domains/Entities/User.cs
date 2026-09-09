using Domains.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Entities
{
    public class User: BaseEntity
    {
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public UserTypeEnum UserType { get; set; }

    }
}