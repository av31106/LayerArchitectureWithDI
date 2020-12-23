using LayerArchitecture.Entity;
using LayerArchitecture.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LayerArchitecture.Api.Controllers
{
    public class HomeController : ApiBaseController
    {
        IDemo _demo;
        public HomeController(IDemo demo)
        {
            _demo = demo;
        }
        [HttpGet]
        public IHttpActionResult Data()
        {
            List<Product> products = new List<Product>() {
            new Product(){ Id=1,Code="A001",Name="Pipe"},
            new Product(){ Id=2,Code="A002",Name="Nut"},
            new Product(){ Id=3,Code="A003",Name="Coile"},
            new Product(){ Id=4,Code="A004",Name="jake"}
            };
            return Ok(new { Result = products });
        }

        [HttpGet]
        public async Task<IHttpActionResult> DataAsync()
        {
            List<Product> products = await Task.Run(() =>
            {
                return new List<Product>() {
                    new Product(){ Id=1,Code="A001",Name="Async Pipe"},
                    new Product(){ Id=2,Code="A002",Name="Async Nut"},
                    new Product(){ Id=3,Code="A003",Name="Async Coile"},
                    new Product(){ Id=4,Code="A004",Name=" Async jake"}
                };
            });

            return Ok(new { Result = products });
        }
    }
}
