using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Interfaces;

namespace TechChallenge1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : Controller
    {
        private readonly IStateService _stateService;
        private readonly IMapper _mapper;

        public StateController(IStateService stateService, IMapper mapper)
        {
            _stateService = stateService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllStates()
        {
            try
            {
                return Ok(_stateService.GetAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("{ddd:int}")]
        public async Task<ActionResult<StateDto>> GetStateByDDD(int ddd)
        {
            var state = await _stateService.GetByDDD(ddd);

            if (state is null)
            {
                return NotFound();
            }

            var stateDto = _mapper.Map<StateDto>(state);

            return Ok(stateDto);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetStateById(Guid id)
        {
            var state = _stateService.GetById(id);

            if (state is null)
            {
                return NotFound();
            }

            return Ok(state);
        }
    }
}
