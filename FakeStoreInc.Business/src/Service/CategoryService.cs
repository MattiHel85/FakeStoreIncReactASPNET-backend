using AutoMapper;
using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Business.src.DTO;
using FakeStoreInc.Core.src.Abstraction;
using FakeStoreInc.Core.src.Entity;

namespace FakeStoreInc.Business.src.Service
{
    public class CategoryService : BaseService<Category, CategoryReadDTO, CategoryCreateDTO, CategoryUpdateDTO>, ICategoryService
    {
        public CategoryService(ICategoryRepo repo, IMapper mapper) :base(repo, mapper)
        {            
        }
    }
}