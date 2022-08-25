using Microsoft.AspNetCore.Mvc;
using Car.Api.Entity;
using System.Collections.Generic;

namespace Car.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CarController:ControllerBase
    {
        public List<Entity.Car> Cars { get; set; } = new List<Entity.Car>();
        public CarController()
        {
            Cars.Add(new Entity.Car()
            {
                Id = 1,
                Brand = "Jaguar",
                year = 2022
            }); ;
        }
        [HttpGet]
        public List<Entity.Car>GetAll()
        {
            return Cars;
        }

    }
}
