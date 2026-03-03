using DatabaseMastery.TransportMongoDb.Dtos.OfferDtos;
using DatabaseMastery.TransportMongoDb.Services.OfferServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportMongoDb.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService OfferService)
        {
            _offerService = OfferService;
        }

        public IActionResult OfferList()
        {
            var values = _offerService.GetAllOfferAsync().Result;
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateOffer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateOffer(CreateOfferDto createOfferDto)
        {
            _offerService.CreateOfferAsync(createOfferDto);
            return RedirectToAction("OfferList");
        }
        public async Task<IActionResult> DeleteOffer(string id)
        {
            await _offerService.DeleteOfferAsync(id);
            return RedirectToAction("OfferList");
        }
        [HttpGet]
        public IActionResult UpdateOffer(string id)
        {
            var value = _offerService.GetOfferByIdAsync(id).Result;
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateOffer(UpdateOfferDto updateOfferDto)
        {
            _offerService.UpdateOfferAsync(updateOfferDto);
            return RedirectToAction("OfferList");
        }
    }
}
