using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Minichall2_4Nvc.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddControllers : ControllerBase
    {
        [HttpGet]
        public string Add(int x, int y){
            return $"the sum of {x} + {y} is: {x + y}";
        }
    }
}