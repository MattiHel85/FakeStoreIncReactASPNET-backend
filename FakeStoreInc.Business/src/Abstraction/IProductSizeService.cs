using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IProductSizeService : IBaseService<ProductSize, ProductSizeReadDTO, ProductSizeCreateDTO, ProductSizeUpdateDTO>
    {
        
    }
}