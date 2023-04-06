using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using reposatywithuow.Contracts;
using reposatywithuow.Entities.Context;
using reposatywithuow.Entities.Models;
using reposatywithuow.Repository;

namespace reposatywithuow.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _productrepo;

        public ProductController(IProduct productrepo)
        {
            _productrepo = productrepo;
        }

        [HttpGet]
        public GenericResponse<List<Product>> GetAllProducts()
        {   
           var Porducts =  _productrepo.GetAllProduct();
            return Porducts;
        }
    }
}
