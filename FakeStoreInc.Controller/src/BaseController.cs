using FakeStoreInc.Business.src.Abstraction;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace FakeStoreInc.Controller.src
{
    [ApiController]
    [Route("/api/v1/[controller]s")]
    public class BaseController<T, TReadDto, TCreateDto, TUpdateDto> : ControllerBase where T:BaseEntity
    {
        private readonly IBaseService<T, TReadDto, TCreateDto, TUpdateDto> _service;
        public BaseController(IBaseService<T, TReadDto, TCreateDto, TUpdateDto> service)
        {
            _service = service;
        }
        [HttpPost()]
        public virtual async Task<ActionResult<TReadDto>> CreateOneAsync([FromBody]TCreateDto createObject)
        {
            return CreatedAtAction(nameof(CreateOneAsync),await _service.CreateOneAsync(createObject));
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:guid}")]
        public virtual async Task<ActionResult<bool>> DeleteOneAsync([FromRoute]Guid id)
        {
            return Ok(await _service.DeleteOneAsync(id));
        }
        [HttpGet()]
        public virtual async Task<ActionResult<IEnumerable<TReadDto>>> GetAllAsync([FromQuery]GetAllOptions getAllOptions)
        {
            return Ok(await _service.GetAllAsync(getAllOptions));
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("{id:guid}")]
        public virtual async Task<ActionResult<TReadDto>> GetByIdAsync([FromRoute]Guid id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
        
        // [Authorize(Policy = "CheckUser")] 
        [Authorize(Roles = "Admin")]
        [HttpPatch("{id:guid}")]
        public virtual async Task<ActionResult<bool>> UpdateOneAsync([FromRoute]Guid id, [FromBody]TUpdateDto updateObject)
        {
            return Ok(await _service.UpdateOneAsync(id, updateObject));
        }
    }
}