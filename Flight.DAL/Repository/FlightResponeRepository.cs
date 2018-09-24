using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flight.Model;
using System.Threading.Tasks;
using Flight.DAL.Abstraction;

namespace Flight.DAL.Repository
{
    public class FlightResponeRepository : IFlightRepository
    {
        private FlightContex _contex = new FlightContex();

        public FlightSearchResponeDTO GetRespone(FlightSearchResponeDTO respone)
        {
            FlightSearchResponeDTO db =  (FlightSearchResponeDTO)_contex.Respone.Where(data => data.Adults == respone.Adults && data.Childs == respone.Childs &&
                                          data.Currency == respone.Currency && data.Origin == respone.Origin &&
                                          data.ReturnDate == respone.ReturnDate && data.DepartureDate == respone.DepartureDate &&
                                          data.Destination == respone.Destination).Single();
            return db;
        }

        public FlightSearchResultDTO GetResult(int id)
        {
            FlightSearchResultDTO db = _contex.Result.Where(data => data.SearchResultId == id).Single();

            return db;
        } 

        public FlightSearchResponeDTO SaveRespone(FlightSearchResponeDTO respone)
        {
            if (respone == null) throw new Exception("");

            var saveReturn = _contex.Respone.Add(respone);
            _contex.SaveChanges();

            return saveReturn;
        }

        public List<FlightSearchResponeDTO> Respones()
        {
            return _contex.Respone.ToList();
        }

        public bool FindRespone(FlightSearchResponeDTO respone)
        {
            var db = _contex.Respone.Any(data => data.Adults == respone.Adults && data.Childs == respone.Childs &&
                                          data.Currency == respone.Currency && data.Origin == respone.Origin &&
                                          data.ReturnDate == respone.ReturnDate && data.DepartureDate == respone.DepartureDate &&
                                          data.Destination == respone.Destination);

            return db;
        }

        public List<CurrencyModel> GetCurrency()
        {

            var db = _contex.Currency.ToList();

            //Ovaj dio nam sluzi kako bi kod prvog pokretanja i kreiranja db-a tablica Currency bila popunjena , nije nuzno mozemo i samostalno popuniti tablicu Currency ukoliko je potrebno
            if(db.Count != 0)
            {
                return db;
            }
            else
            {
                var mock1 = new CurrencyModel()
                {
                    Name = "EUR"
                };
                var mock2 = new CurrencyModel()
                {
                    Name = "USD"
                };
                _contex.Currency.Add(mock1);
                _contex.Currency.Add(mock2);
                _contex.SaveChanges();

                return _contex.Currency.ToList();
            }
        }
    }
}
