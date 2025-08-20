using System.Diagnostics;
using Application.Microservices.Web.Models;
using Application.Microservices.Web.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Application.Microservices.Web.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            List<ProductDto> productList = new();
            ResponseDto? response = await _productService.GetAllProductsAsync();
            if (response != null && response.IsSuccess)
            {
                productList = JsonConvert.DeserializeObject<List<ProductDto>>(Convert.ToString(response.Result));

            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(productList);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ProductDetails(int ProductID)
        {
            ProductDto product = new();
            ResponseDto? response = await _productService.GetProductByIdAsync(ProductID);
            if (response != null && response.IsSuccess)
            {
                product = JsonConvert.DeserializeObject<ProductDto>(Convert.ToString(response.Result));

            }
            else
            {
                TempData["error"] = response?.Message;
            }
            return View(product);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
