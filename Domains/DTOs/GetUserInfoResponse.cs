using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.DTOs
{
    public class GetUserInfoResponse
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; } 
    }
}
