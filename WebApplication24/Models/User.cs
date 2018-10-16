using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string userID { get; set; }
        public string userName { get; set; }
        public int section_id { get; set; }
        public string createdTime { get; set; }
        public string updatedTime { get; set; }
    }
}
