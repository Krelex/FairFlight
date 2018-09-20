using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class FlightItinearyDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ItinearyId { get; set; }

        public virtual FlightBoundDTO Outbound { get; set; }

        public virtual FlightBoundDTO Inbound { get; set; }

    }
}
