using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;

namespace TechChallenge1.API.Controllers
{

    [ApiController]
    [Route("/api/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

      
        public ContactController(IContactService contactService, IMapper mapper)
        {
            _mapper = mapper;
            _contactService = contactService;
        }


        [HttpGet]
        [AllowAnonymous]
        [Route("list-contact")]
        public async Task<IActionResult> GetAllContacts()
        {
            try
            {
               return Ok(_mapper.Map<IEnumerable<ContactDto>>(await _contactService.GetAll()));
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        [HttpGet]
        [Route("detail-contact/{id:guid}")]
        public async Task<IActionResult> DetailContact([FromRoute] Guid id)
        {
            var contact = _mapper.Map<ContactDto>(await _contactService.GetById(id));

            if (contact is null)
            {
                return NotFound();
            }
            return Ok(contact);
        }


        [Route("register-contact")]
        [HttpPost]
        public async Task<IActionResult> AddContact([FromBody] ContactDto contactRequest)
        {

            //TODO: fluent validion
            try
            {
                await _contactService.Create(_mapper.Map<Contact>(contactRequest));

                return Ok(contactRequest);
            }
            catch (Exception e)
            {
                return (BadRequest(new { Message = e.Message }));
            }

        }

        [HttpDelete]
        [Route("delete-contact/{id:guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await _contactService.GetById(id);

            if (contact is null)
            {
                return NotFound();
            }

            await _contactService.Delete(id);

            return Ok();
        }

        [HttpPost]
        [Route("update-contact/{id:guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id, [FromBody] ContactDto contactUpdateRequest)
        {
            //TODO: fluent validion
            var contact = await _contactService.GetById(id);

            if (contact is null)
            {
                return NotFound();
            }
            try
            {
                await _contactService.Update(id,_mapper.Map<Contact>(contactUpdateRequest));

            }
            catch (Exception e)
            {
                return (BadRequest(new { Message = e.Message }));
            }

            return Ok(contactUpdateRequest);
        }
    }
}
