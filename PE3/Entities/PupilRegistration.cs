using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class PupilRegistration
    {
        [Key]
        public long Id { get; set; }
        public long PupilId { get; set; }
        public long ClassRoomId { get; set; }
        public DateTime SignedUpDate { get; set; }


        public Pupil Pupil { get; set; }
        public ClassRoom ClassRoom { get; set; }


    }
}
