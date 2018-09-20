using Flight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Service.Abstraction
{
    public interface IFlightService 
    {
        List<FlightSearchResponeDTO> Respones();

        FlightSearchResponeDTO GetRespone(FlightSearchResponeDTO respone);

        bool SaveRespone(FlightSearchResponeDTO respone);

        bool FindRespone(FlightSearchResponeDTO respone);

        FlightSearchResponeDTO GetApiRespone(FlightSearchResponeDTO respone);

        List<CurrencyModel> GetCurrency();
    }
}
