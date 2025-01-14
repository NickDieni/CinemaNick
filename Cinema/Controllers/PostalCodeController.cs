using Microsoft.AspNetCore.Mvc;
using CinemaDataModels.Data;
using AutoMapper;
using CinemaDataModels.Models.DTO;
using CinemaDataModels.Repositories.IRepository;
using CinemaDataModels.Models.DTO.Sub_Genre;
using CinemaDataModels.Models.Entities;
using CinemaDataModels.Models.DTO.Sub_PostalCode;

namespace CinemaBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostalCodesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IPostalCodeRepository postalCodeRepository;

        public PostalCodesController(IMapper mapper, IPostalCodeRepository postalCodeRepository)
        {
            this.mapper = mapper;
            this.postalCodeRepository = postalCodeRepository;
        }

        // GET PostalCode
        // GET: /api/PostalCode

        [HttpGet]
        public async Task<ActionResult<List<PostalCodeDto>>> GetAll()
        {
            var postalCodesDomainModel = await postalCodeRepository.GetAllAsync();

            // Map Domain Model to DTO
             return Ok(mapper.Map<List<PostalCodeDto>>(postalCodesDomainModel));
        }

        // Get PostalCode By Id
        // GET; /api/PostalCodes/{id}
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var postalCodeDomainModel = await postalCodeRepository.GetByIdAsync(id);

            if (postalCodeDomainModel == null)
            {
                return NotFound();
            }
            // Map Domain Model to DTO
            return Ok(mapper.Map<PostalCodeDto>(postalCodeDomainModel));
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddPostCodeRequestDto addPostCodeRequestDto)
        {
            // Map DTO to Domain Model
            var postalCodeDomainModel = mapper.Map<PostalCode>(addPostCodeRequestDto);

            await postalCodeRepository.CreateAsync(postalCodeDomainModel);

            // Map Domain model to DTO
            return Ok(mapper.Map<PostalCodeDto>(postalCodeDomainModel));
        }
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deletedPostalCodeDomainModel = await postalCodeRepository.DeleteAsync(id);
            if (deletedPostalCodeDomainModel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<PostalCodeDto>(deletedPostalCodeDomainModel));

            // Map Domain Model to DTO

        }
    }
}
