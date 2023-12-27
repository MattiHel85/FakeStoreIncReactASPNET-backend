using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Service
{
    public class ProductSizeService : BaseService<ProductSize, ProductSizeReadDTO, ProductSizeCreateDTO, ProductSizeUpdateDTO>, IProductSizeService
    {
        public ProductSizeService(IProductSizeRepo repo, IMapper mapper) :base(repo, mapper)
        {
            
        }
    }
}