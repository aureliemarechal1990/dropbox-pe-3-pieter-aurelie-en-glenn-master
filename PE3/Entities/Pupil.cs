using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PE3.Entities
{
    public class Pupil
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Geef jouw voornaam in.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Geef jouw familienaam in.")]
        public string LastName { get; set; }
        public int CurrentLevel { get; set; }
        public DateTime Birthdate { get; set; }
        
        public ICollection<Results> Results { get; set;}
    }
}
