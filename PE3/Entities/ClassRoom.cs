using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class ClassRoom
    {
        [Key]
        public long Id { get; set; }
        public long TeacherId { get; set; }
        public int AmountOfPupils { get; set; }
        

        public Teacher Teacher { get; set; }
        public ICollection<Pupil> Pupils { get; set; }
    }
}
