using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flight.Model
{
    public class FlightSearchResultDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int SearchResultId { get; set; }

        [Required]
        public virtual List<FlightItinearyDTO> Itineraries { get; set; }

        [Required]
        public virtual PriceSegmentDTO Fare { get; set; }

        public int FlightNumbersOutbound()
        {
            return Itineraries.First().Outbound.Flights.Count -1;
        }

        public int FlightNumbersInbound()
        {
            return Itineraries.First().Inbound.Flights.Count -1;
        }

        public string OutboundDestinationIATA()
        {
            return this.Itineraries.First().Outbound.DestinationIATA();
        }

        public string OutboundOriginIATA()
        {
            return this.Itineraries.First().Outbound.OriginIATA();
        }
    }
}
