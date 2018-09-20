using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flight.Model
{
    public class FlightBoundDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int FlightBoundId { get; set; }

        [Required]
        public virtual List<FlightSegmentDTO> Flights { get; set; }

        [Required]
        public string Duration { get; set; }

        public string DestinationIATA()
        {
           return this.Flights.Last().Destination.ToString();
        }

        public string OriginIATA()
        {
            return this.Flights.First().Origin.ToString();
        }
    }
}
