using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Admin
    {
        public static object ExtensionMethods { get; internal set; }
        [Key]
        public int adminId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string profilePicture { get; set; }
        public int schoolId { get; set; }
        public string classId { get; set; }
        public int roleId { get; set; }
        public int isActive { get; set; }
        public int isDeleted { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
    }
}
