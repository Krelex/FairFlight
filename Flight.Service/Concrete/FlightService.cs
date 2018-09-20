using Flight.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight.Model;
using Flight.DAL.Abstraction;
using IO.Swagger.Api;

namespace Flight.Service.Concrete
{
    public class FlightService : IFlightService
    {
        private IFlightRepository _iFlightServiceRepository;
        private IDefaultApi _ApiClient;

        const string apiKey = "9qt9J2AStfgR54huLNS0RRiaffAOtE8D";

        public FlightService(IFlightRepository repo  ,IDefaultApi api )
        {
            _iFlightServiceRepository = repo;
            _ApiClient = api;
        }

        public List<FlightSearchResponeDTO> Respones()
        {
            return _iFlightServiceRepository.Respones();
        }

        public bool SaveRespone(FlightSearchResponeDTO respone)
        {
            if (respone != null) _iFlightServiceRepository.SaveRespone(respone);

            else return false;

            return true;
        }

        public FlightSearchResponeDTO GetRespone(FlightSearchResponeDTO respone)
        {
            var dbRespone = _iFlightServiceRepository.GetRespone(respone);

            return dbRespone;
        }

        public bool FindRespone(FlightSearchResponeDTO respone)
        {
            var db = _iFlightServiceRepository.FindRespone(respone);

            return db;
        }

        public FlightSearchResponeDTO GetApiRespone(FlightSearchResponeDTO respone)
        {

            var apiRespone = _ApiClient.FlightLowFareSearch(apiKey, respone.Origin, respone.Destination, respone.DepartureDate.ToString("yyyy-MM-dd"),
                                                            respone.ReturnDate?.ToString("yyyy-MM-dd"), null, null, respone.Adults, respone.Childs, null, null, null, null,
                                                            null, respone.Currency);

            var resp = AutoMapper.Mapper.Map<FlightSearchResponeDTO>(apiRespone);

            resp.Adults = respone.Adults;
            resp.Childs = respone.Childs;
            resp.Destination = respone.Destination;
            resp.Origin = respone.Origin;
            resp.DepartureDate = respone.DepartureDate;
            resp.ReturnDate = respone.ReturnDate;

            return resp;
        }

        public List<CurrencyModel> GetCurrency()
        {

            return _iFlightServiceRepository.GetCurrency();
        }
    }
}
