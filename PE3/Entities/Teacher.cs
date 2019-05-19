using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class Teacher
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Gelieve uw voornaam in te voeren.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Gelieve uw familienaam in te voeren.")]
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ClassRoom ClassRoom { get; set; }
        public ICollection<Pupil> Pupils { get; set; }


    }
}
