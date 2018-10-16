using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Section
    {
        [Key]
        public int id { get; set; }
        public string section { get; set; }
        public int class_id { get; set; }
        public string createdTime { get; set; }
        public string updatedTime { get; set; }
    }
}
