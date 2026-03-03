using DatabaseMastery.TransportMongoDb.Dtos.BrandDtos;
using DatabaseMastery.TransportMongoDb.Services.BrandServices;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseMastery.TransportMongoDb.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService BrandService)
        {
            _brandService = BrandService;
        }

        public IActionResult BrandList()
        {
            var values = _brandService.GetAllBrandAsync().Result;
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(CreateBrandDto createBrandDto)
        {
            _brandService.CreateBrandAsync(createBrandDto);
            return RedirectToAction("BrandList");
        }
        public async Task<IActionResult> DeleteBrand(string id)
        {
            await _brandService.DeleteBrandAsync(id);
            return RedirectToAction("BrandList");
        }
        [HttpGet]
        public IActionResult UpdateBrand(string id)
        {
            var value = _brandService.GetBrandByIdAsync(id).Result;
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            _brandService.UpdateBrandAsync(updateBrandDto);
            return RedirectToAction("BrandList");
        }


    }
}
