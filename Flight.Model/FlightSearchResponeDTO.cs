using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class FlightSearchResponeDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ResponeId { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        [Required]
        [StringLength(3)]
        public string Origin { get; set; }

        [Required]
        [StringLength(3)]
        public string Destination { get; set; }

        [Required]
        public int Adults { get; set; }

        public int Childs { get; set; }

        [Required]
        public string Currency { get; set; }

        [Required]
        public virtual List<FlightSearchResultDTO> Results { get; set; }

        public double PassangerNumber()
        {
            return this.Adults + this.Childs;
        }

    }
}
