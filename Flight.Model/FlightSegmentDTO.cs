using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class FlightSegmentDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FlightSagmentId { get; set; }

        [Required]
        public DateTime DepartsAt { get; set; }

        [Required]
        public DateTime ArrivesAt { get; set; }

        [Required]
        [StringLength(3)]
        public string Origin { get; set; }

        [Required]
        [StringLength(3)]
        public string Destination { get; set; }

        [Required]
        public double FlightNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Aircraft { get; set; }
    }
}
