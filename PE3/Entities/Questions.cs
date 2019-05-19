using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class Questions
    {
        [Key]
        public long QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Level { get; set; }
        public long ClassRoomId { get; set; }


        public ClassRoom ClassRoom { get; set; }
        public ICollection<Results> Results { get; set; }
    }
}
