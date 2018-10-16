using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Class
    {
        [Key]
        public int id { get; set; }
        public int school_id { get; set; }
        public string createdTime { get; set; }
        public string updatedTime { get; set; }
    }
}
 