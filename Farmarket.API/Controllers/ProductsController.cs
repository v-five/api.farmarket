using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Farmarket.API.Controllers
{
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetProducts(string category=null)
        {
            return Json(new {merge = "merge", category= category});
        }


    }
}
