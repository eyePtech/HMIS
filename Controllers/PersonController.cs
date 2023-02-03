using HMIS.DTO.PersonServiceDTO;
using HMIS.DTO.Registration;
using HMIS.Services;
using Microsoft.AspNetCore.Mvc;

namespace HMIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
    private readonly IPersonService personRepository;
    private readonly IPersonServiceCenter _servicecenter;

    public MainController(IPersonService personRepository,IPersonServiceCenter serviceCenter)
    {
        this.personRepository = personRepository;
        _servicecenter = serviceCenter;

    }

    [HttpPost("AddPerson")]
    public async Task<ActionResult<AddPersonDTO>> AddPerson(AddPersonDTO person)
    {
       try
        {
            if (person == null)
                return BadRequest();

            var createdPerson =  personRepository.Add(person);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }

    [HttpPut("UpdatePerson")]
    public async Task<ActionResult<UpdatePersonDTO>> UpdatePerson(UpdatePersonDTO person)
    {
       try
        {
            if (person == null)
                return BadRequest();
            var createdPerson =  personRepository.Update(person);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }

        [HttpPost("AddServiceCenter")]
    public async Task<ActionResult<AddServiceCenterDTO>> AddServiceCenter(AddServiceCenterDTO person)
    {
       try
        {
            if (person == null)
                return BadRequest();

            var createdPerson =  _servicecenter.Add(person);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }
    [HttpPut("UpdateServiceCenter")]
    public async Task<ActionResult<UpdateServiceCenterDTO>> UpdateServiceCenter(UpdateServiceCenterDTO person)
    {
       try
        {
            if (person == null)
                return BadRequest();
                
            var createdPerson =  _servicecenter.Update(person);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }

    [HttpGet("Search")]
    public async Task<IEnumerable<ServiceCenter>> search(string? name, string? desc, int? code)
    {
      return await _servicecenter.search(name,desc,code);
    }

    [HttpPost("register")]
    public async Task<ActionResult<AddSecurityUserMaster>> register(AddSecurityUserMaster user)
    {
       try
        {
            if (user == null)
                return BadRequest();

            var createdPerson =  _servicecenter.Ragistor(user);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> login(AddSecurityUserMaster user)
    {
       try
        {
            if (user == null)
                return BadRequest();

            var createdPerson =  _servicecenter.Login(user);
            return Ok(createdPerson);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
        }
    }
    

    }
}