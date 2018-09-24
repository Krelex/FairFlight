using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flight.Presentation.Models;
using Flight.Service.Abstraction;
using Flight.Model;
using System.Configuration;
using log4net;
using System.Reflection;

[assembly: log4net.Config.XmlConfigurator]

namespace Flight.Presentation.Controllers
{
    public class HomeController : Controller
    {

        private readonly IFlightService _service;


        public HomeController(IFlightService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            
            ViewBag.Currency = _service.GetCurrency();

            return View();
        }

        [HttpPost]
        public ActionResult List(SearchViewModel search)
        {
            ViewBag.Currency =_service.GetCurrency();

            if (!ModelState.IsValid)
            {
                return View();
            }

            var responeSearchParamters = SearchViewModelToSearchResponeModel(search);
            FlightSearchResponeDTO respone;

            if (_service.FindRespone(responeSearchParamters))
            {
                respone = _service.GetRespone(responeSearchParamters);
            }
            else
            {
                var ApiRespone = _service.GetApiRespone(responeSearchParamters);
                respone = _service.SaveRespone(ApiRespone);      
            }

            return View("List", respone);
        }

        public ActionResult Details(int ResultId, string Currency)
        {
            var result = _service.GetResult(ResultId);
            ViewBag.Currency = Currency;

            return View(result);
        }

        [NonAction]
        private FlightSearchResponeDTO SearchViewModelToSearchResponeModel(SearchViewModel model)
        {
            var SeacrhModel = new FlightSearchResponeDTO()
            {
                Destination = model.Destination,
                Origin = model.Origin,
                Currency = model.Currency,
                DepartureDate = model.DepartureDate,
                ReturnDate = model.ReturnDate,
                Adults = model.Adults,
                Childs = model.Childs
            };

            return SeacrhModel;
        }


    }
}