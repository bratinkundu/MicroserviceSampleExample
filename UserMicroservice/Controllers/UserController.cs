using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserMicroservice.Models;

namespace UserMicroservice.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            List<Users> users = UsersDummyData();
            return Ok(users);
        }

        public List<Users> UsersDummyData()
        {
            IList<Users> Users = new List<Users>()
            {
                new Users()
                {
                     Id = 1,
                     Name ="User 1",
                     Email = "user1@g.co"
                },
                new Users()
                {
                    Id = 2,
                    Name = "User 2",
                    Email = "user2@g.co"
                },
                new Users()
                {
                    Id = 3,
                    Name = "User 3",
                    Email = "user3@g.co"
                }
            };

            return Users.ToList();
        }
    }
}