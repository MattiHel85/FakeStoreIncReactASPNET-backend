using FakeStoreInc.Business.src.DTO.FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Abstraction
{
    public interface IProductService : IBaseService<Product, ProductReadDTO, ProductCreateDTO, ProductUpdateDTO>
    {
        
    }
}