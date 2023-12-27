using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IProductColorService : IBaseService<ProductColor, ProductColorReadDTO, ProductColorCreateDTO, ProductColorUpdateDTO>
    {
        
    }
}