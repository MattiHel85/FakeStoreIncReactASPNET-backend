using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Business.src.DTO.FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Service
{
    public class ProductColorService : BaseService<ProductColor, ProductColorReadDTO, ProductColorCreateDTO, ProductColorUpdateDTO>, IProductColorService
    {
        public ProductColorService(IProductColorRepo repo, IMapper mapper) :base(repo, mapper)
        {
            
        }
    }
}