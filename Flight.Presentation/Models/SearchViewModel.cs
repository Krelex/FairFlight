using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Flight.Presentation.Models
{
    public class SearchViewModel
    {
        [Required(ErrorMessage = "Datum polaska je obavezan!")]
        public DateTime DepartureDate { get; set; }

        public DateTime? ReturnDate { get; set; }


        private string _origin;

        [Required(ErrorMessage = "IATA sifra je obavezna!")]
        [StringLength(3, ErrorMessage = "IATA sifra se sastoji od 3 znaka!" , MinimumLength = 3)]
        public string Origin
        {   get { return _origin; }

            set { if(value != null) _origin = value.ToUpper(); }
        }

        private string _destination;

        [Required(ErrorMessage = "IATA sifra je obavezna!")]
        [StringLength(3, ErrorMessage = "IATA sifra se sastoji od 3 znaka!", MinimumLength = 3)]
        public string Destination
        {
            get { return _destination ; }
            set { if(value != null)_destination = value.ToUpper(); }
        }

        [Required(ErrorMessage = "Odrasla osoba je obavezna!")]
        [Range(1 , 9 , ErrorMessage = "Dozvoljen je unos od 1 do 9 odraslih osoba!")]
        public int Adults { get; set; }

        [Range(0, 9, ErrorMessage = "Dozvoljen je unos od 0 do 9 djece!")]
        public int Childs { get; set; }

        public string Currency { get; set; }

    }
}