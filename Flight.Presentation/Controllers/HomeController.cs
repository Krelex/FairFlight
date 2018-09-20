using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Flight.Presentation.Models;
using Flight.Service.Abstraction;
using Flight.Model;

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
        public ActionResult Index(SearchViewModel search)
        {
            ViewBag.Currency =_service.GetCurrency();


            if (!ModelState.IsValid)
            {
                return View();
            }

            FlightSearchResponeDTO respone = SearchViewModelToSearchResponeModel(search);

            if (_service.FindRespone(respone))
            {
                 respone = _service.GetRespone(respone);
            }
            else
            {
                respone = _service.GetApiRespone(respone);

                if (!_service.SaveRespone(respone)) throw new Exception("Saving to DB failed!");       
            }

            return View("List", respone);
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