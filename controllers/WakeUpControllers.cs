using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Minichall2_4Nvc.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WakeUpControllers : ControllerBase
    {
        [HttpGet]
        public string input(string name, string wakeUp){
            return $"{name} woke up at {wakeUp}";
        }
    }
}