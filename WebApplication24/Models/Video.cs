using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Video
    {
        [Key]
        public int videoId { get; set; }
        public string video { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public int section_id { get; set; }
    }
}
