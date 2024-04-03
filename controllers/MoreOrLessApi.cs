using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Minichall2_4Nvc.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoreOrLessApi : ControllerBase
    {
        [HttpGet]
        public string equal(int x, int y){
    if (x == y){
    return x + " is equal to " + y;
   }else if (x>y){
    return x + " is greater than " + y;
   }else{
    return x + " is less than " + y;
   }
        }
    }
}