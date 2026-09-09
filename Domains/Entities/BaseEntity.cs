using System;
using System.Collections.Generic;
using System.Text;

namespace Domains.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
