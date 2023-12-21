using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO.FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Business.src.Service;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class ProductController : BaseController<Product, ProductReadDTO, ProductCreateDTO, ProductUpdateDTO>
    {
        public ProductController(IProductService service) : base(service)
        {
        }
    }
}