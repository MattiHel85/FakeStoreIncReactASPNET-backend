using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class ProductSizeController : BaseController<ProductSize, ProductSizeReadDTO, ProductSizeCreateDTO, ProductSizeUpdateDTO>
    {
        public ProductSizeController(IProductSizeService service) : base(service)
        {
        }
    }
}