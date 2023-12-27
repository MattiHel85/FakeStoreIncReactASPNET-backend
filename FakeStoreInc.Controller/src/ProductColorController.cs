using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Controller.src
{
    public class ProductColorController : BaseController<ProductColor, ProductColorReadDTO, ProductColorCreateDTO, ProductColorUpdateDTO>
    {
        public ProductColorController(IProductColorService service) : base(service)
        {
        }
    }
}