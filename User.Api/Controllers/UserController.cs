using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using User.Api.Entity;

namespace User.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
       public List<Entity.User> Users { get; set; } = new List<Entity.User>();
        
       public UserController()
        {
            Users.Add(new Entity.User()
            {
                Id = 1,
                Age = 21,
                Name = "emre"
            });
        }
        [HttpGet]
        public List<Entity.User> GetAll()
        {
           
            return Users;
        }
    }
}
