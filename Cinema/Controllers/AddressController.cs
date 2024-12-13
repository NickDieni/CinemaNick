using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Models.DTO.Sub_Address;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Repositories.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IMapper mapper;
        private readonly IAddressRepository addressRepository;

        //Dependency injection
        public AddressController(IMapper mapper, IAddressRepository addressRepository)
        {
            this.mapper = mapper;
            this.addressRepository = addressRepository;
        }
        // CREATE User
        // POST: /api/users
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddAddressRequestDto addAddressRequestDto)
        {
            // Map DTO to Domain Model
            var addressDomainModel = mapper.Map<Address>(addAddressRequestDto);

            await addressRepository.CreateAsync(addressDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<AddressDto>(addressDomainModel));
        }

        // GET User
        // GET: /api/users

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var addressDomainModel = await addressRepository.GetAllAsync();

            // Map Domain Model to DTO
            return Ok(mapper.Map<List<AddressDto>>(addressDomainModel));
        }

        // Get User By Id
        // GET; /api/users/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var addressDomainModel = await addressRepository.GetByIdAsync(id);

            if (addressDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<AddressDto>(addressDomainModel));
        }

        // Update User By Id
        // PUT: /api/users/{id}
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAddressRequestDto updateAddressRequestDto)
        {
            // Map DTO to Domain Model
            var addressDomainModel = mapper.Map<Address>(updateAddressRequestDto);

            addressDomainModel = await addressRepository.UpdateAsync(id, addressDomainModel);

            if (addressDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO

            return Ok(mapper.Map<AddressDto>(addressDomainModel));
        }

        // Delete User By Id
        // DELETE: /api/users/{id}
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedAddressDomainModel = await addressRepository.DeleteAsync(id);
            if (deletedAddressDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<AddressDto>(deletedAddressDomainModel));

            // Map Domain Model to DTO

        }
    }
}
