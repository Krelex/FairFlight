using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class PriceSegmentDTO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int PriceSegmentId { get; set; }

        public double TotalPrice { get; set; }

        public double PricePerAdult { get; set; }

        public double PricePerChild { get; set; }

    }
}
