using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LandonApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class RootController : ControllerBase
    {
       
        [HttpGet(Name =nameof(GetRoot))]        
        public IActionResult GetRoot() 
        {
            var response = new
            {
                href = Url.Link(nameof(GetRoot), null),
                rooms = Url.Link(nameof(RoomsController.GetRooms),null)
            };

            return Ok(response);
        }
    }
}