using MVCandUnityDI.Repository.Interface;
using MVCandUnityDI.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCandUnityDI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}
        
        readonly IProductRepository repository;

        public ProductController()
        {
            
        }

        //inject dependency
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();
            return View(data);
        }
        //Other Code
    }
}