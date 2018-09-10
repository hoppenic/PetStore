using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetStore.Models;

namespace PetStore.Controllers
{
    public class ProductController : Controller
    {

        private List<Product> _products;

        public ProductController()
        {
            //use list to mock up data for now

            _products = new List<Product>();
            _products.Add(new Product
            {
                ID = 1,
                Name = "Golden Retriever",
                Description = "Friendly and fluffy Golden Retreiver",
                Image="",
                Price=999


            });

            _products.Add(new Product
            {
                ID=2,
                Name="Kitten",
                Description="Big fluffy cat who likes to sleep",
                Image="",
                Price=55



            });

            _products.Add(new Product
            {
                ID = 3,
                Name = "Sugar Glider",
                Description = "Flying rat/squirrel thing",
                Image = "",
                Price = 484
            });

        }

        public IActionResult Details(int? id)
        {
            if (id.HasValue)
            {
                Product p = _products.Single(x => x.ID == id.Value);
                return View(p);
            }

            return NotFound();
            
        }

        


        public IActionResult Index()
        {

            //by passing a parameter to my view method I'm passing it to the CSHMTL soit can be bound up to the view
            return View(_products);
        }
    }
}