using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    public class Emotion
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public string emotion { get; set; }
        public string timeframe { get; set; }
        public string createdTime { get; set; }
        public string updatedTime { get; set; }
        public string gender { get; set; }
        public decimal surprise { get; set; }
        public decimal happy { get; set; }
        public decimal sad { get; set; }
        public decimal fear { get; set; }
        public decimal neutral { get; set; }
        public decimal disgust { get; set; }
        public decimal angry { get; set; }
        public float frame_millitime { get; set; }
        public int video_id { get; set; }

    }
}
