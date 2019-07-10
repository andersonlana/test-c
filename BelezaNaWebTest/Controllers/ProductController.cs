using BelezaNaWebTest.DLL.Services;
using BelezaNaWebTest.Models;
using System.Web.Http;

namespace BelezaNaWebTest.API.Controllers
{
    public class ProductController : ApiController
    {
        [HttpPost]
        public void Create(Product product)
        {
            ProductService.Create(product);
        }

        [HttpPost]
        public void Edit(Product product)
        {
            ProductService.Edit(product);
        }

        [HttpGet]
        public Product Get(int sku)
        {
            return ProductService.Get(sku);
        }

        [HttpGet]
        public void Delete(int sku)
        {
            ProductService.Delete(sku);
        }
    }
}
