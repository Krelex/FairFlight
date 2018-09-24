using Flight.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight.Model;
using Flight.DAL.Abstraction;
using IO.Swagger.Api;
using System.Configuration;

namespace Flight.Service.Concrete
{
    public class FlightService : IFlightService
    {
        private IFlightRepository _iFlightServiceRepository;
        private IDefaultApi _ApiClient;

        //Here place your api key.
        string apiKey = ConfigurationManager.AppSettings["apiKey"];


        public FlightService(IFlightRepository repo  ,IDefaultApi api )
        {
            _iFlightServiceRepository = repo;
            _ApiClient = api;
        }

        public List<FlightSearchResponeDTO> Respones()
        {
            return _iFlightServiceRepository.Respones();
        }

        public FlightSearchResponeDTO SaveRespone(FlightSearchResponeDTO respone)
        {
            if (respone == null) throw new Exception("Error happened while saving to database.");

            return _iFlightServiceRepository.SaveRespone(respone);

        }

        public FlightSearchResultDTO GetResult(int id)
        {
            return _iFlightServiceRepository.GetResult(id);
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

        public FlightSearchResponeDTO GetApiRespone(FlightSearchResponeDTO viewRespone)
        {

            var apiRespone = _ApiClient.FlightLowFareSearch(apiKey, viewRespone.Origin, viewRespone.Destination, viewRespone.DepartureDate.ToString("yyyy-MM-dd"),
                                                            viewRespone.ReturnDate?.ToString("yyyy-MM-dd"), null, null, viewRespone.Adults, viewRespone.Childs, null, null, null, null,
                                                            null, viewRespone.Currency);

            var dbRespone = AutoMapper.Mapper.Map<FlightSearchResponeDTO>(apiRespone);

            dbRespone = ViewToDbModelMapping(viewRespone, dbRespone);

            return dbRespone;
        }

        public List<CurrencyModel> GetCurrency()
        {

            return _iFlightServiceRepository.GetCurrency();
        }

        private static FlightSearchResponeDTO ViewToDbModelMapping(FlightSearchResponeDTO ViewRespone , FlightSearchResponeDTO DatabaseRespone )
        {

            DatabaseRespone.Adults = ViewRespone.Adults;
            DatabaseRespone.Childs = ViewRespone.Childs;
            DatabaseRespone.Destination = ViewRespone.Destination;
            DatabaseRespone.Origin = ViewRespone.Origin;
            DatabaseRespone.DepartureDate = ViewRespone.DepartureDate;
            DatabaseRespone.ReturnDate = ViewRespone.ReturnDate;

            return DatabaseRespone;
        }
    }
}
