using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class CurrencyModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Name { get; set; }
    }
}
