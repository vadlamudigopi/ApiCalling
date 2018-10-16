using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class School
    {
        [Key]
        public int id { get; set; }
        public string school { get; set; }
        public string school_email { get; set; }
        public int school_phone { get; set; }
        public string school_image { get; set; }
        public string school_address { get; set; }
        public int school_is_active { get; set; }
        public int school_is_deleted { get; set; }
        public string createdTime { get; set; }
        public string updatedTime { get; set; }
    }
}
