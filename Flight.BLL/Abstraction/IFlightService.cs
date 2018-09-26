using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.BLL.Abstraction
{
    public interface IFlightService 
    {
        List<FlightSearchResponeDTO> Respones();

        FlightSearchResponeDTO GetRespone(FlightSearchResponeDTO respone);

        FlightSearchResultDTO GetResult(int id);

        FlightSearchResponeDTO SaveRespone(FlightSearchResponeDTO respone);

        bool FindRespone(FlightSearchResponeDTO respone);

        FlightSearchResponeDTO GetApiRespone(FlightSearchResponeDTO respone);

        List<CurrencyModel> GetCurrency();
    }
}
