using System.Web.Mvc;
using InternetShop.BLL.Interfaces;
using AutoMapper;
using InternetShop.BLL.DTO;
using InternetShop.WEB.Models;
using System.Collections;
using System.Collections.Generic;
using InternetShop.DAL.Repositories;
using InternetShop.DAL.Entities;

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
            var products = Mapper.Map<IEnumerable<ProductDTO>, IList<ProductViewModel>>
                                    (productService.GetProducts());

            return View(products);
        }

        public ActionResult Details(int id) {
            var product = Mapper.Map<ProductDTO, ProductViewModel>
                                    (productService.GetProductById(id));

            return View(product);
        }
    }
}