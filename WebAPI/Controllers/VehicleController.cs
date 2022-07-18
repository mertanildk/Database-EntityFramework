using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }
        [HttpPost("Add")]
        public IActionResult Add(Vehicle vehicle)
        {
            var result = _vehicleService.Add(vehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Delete")]
        public IActionResult Delete(Vehicle vehicle)
        {
            var result = _vehicleService.Delete(vehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Vehicle vehicle)
        {
            var result = _vehicleService.Update(vehicle);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _vehicleService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("Get")]
        public IActionResult Get(int id )
        {
            var result = _vehicleService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByUnitPrice")]
        public IActionResult GetByUnitPrice(decimal min, decimal max)
        {
            var result = _vehicleService.GetByUnitPrice(min,max);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetAllByColorId")]
        public IActionResult GetAllByColorId(int id)
        {
            var result = _vehicleService.GetAllByColorId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetByVehicleId(")]
        public IActionResult GetByVehicleId(int id)
        {
            var result = _vehicleService.GetByVehicleId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}

      
        
        
        