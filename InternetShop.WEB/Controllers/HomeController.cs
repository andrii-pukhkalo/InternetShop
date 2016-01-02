using System.Web.Mvc;
using InternetShop.BLL.Interfaces;
using AutoMapper;
using InternetShop.BLL.DTO;
using InternetShop.WEB.Models;
using System.Collections;
using System.Collections.Generic;

namespace InternetShop.WEB.Controllers
{
    public class HomeController : Controller
    {
        // initialize varialbe productService;
        IProductService productService;

        public HomeController(IProductService service) {
            this.productService = service;
        }

        public ActionResult Index()
        {
            Mapper.CreateMap<ProductDTO, ProductViewModel>();

            //IEnumerable<ProductDTO> prd = productService.GetProducts();
            var products = Mapper.Map<IEnumerable<ProductDTO>, IList<ProductViewModel>>(productService.GetProducts());

            return View(products);
            //return View();
        }

    }
}