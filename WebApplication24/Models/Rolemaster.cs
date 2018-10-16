using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Rolemaster
    {
        [Key]
        public int roleId { get; set; }
        public string roleName { get; set; }
        public int roleIsActive { get; set; }
        public int roleIsDeleted { get; set; }
        public string roleCreatedAt { get; set; }
        public string roleUpdatedAt { get; set; }
    }
}
