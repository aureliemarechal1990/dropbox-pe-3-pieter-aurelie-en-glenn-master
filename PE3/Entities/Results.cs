using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class Results
    {
        [Key]
        public long Id { get; set; }
        public long PupilId { get; set; }
        public long QuestionId { get; set; }
        public string PupilAnswer { get; set; }

        

    }
}
