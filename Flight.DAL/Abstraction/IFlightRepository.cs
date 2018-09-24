using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DAL.Abstraction
{
    public interface IFlightRepository
    {
        List<FlightSearchResponeDTO> Respones();

        FlightSearchResponeDTO GetRespone(FlightSearchResponeDTO respone);

        FlightSearchResultDTO GetResult(int id);

        FlightSearchResponeDTO SaveRespone(FlightSearchResponeDTO respone);

        bool FindRespone(FlightSearchResponeDTO respone);

        List<CurrencyModel> GetCurrency();
    }
}
