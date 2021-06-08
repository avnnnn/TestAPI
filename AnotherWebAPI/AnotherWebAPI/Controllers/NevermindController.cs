using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnotherWebAPI.Models;
using AnotherWebAPI.Data;

namespace AnotherWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NevermindController : ControllerBase
    {
        [HttpGet]
        public JsonResult getNevermind()
        {
            return new JsonResult(NevermindStorage.neverminds);
        }
        [HttpPost]
        public JsonResult createNevermind(Nevermind nevermind)
        {
            nevermind.id = NevermindStorage.neverminds.Max(x=>x.id)+1;
            NevermindStorage.neverminds.Add(nevermind);
            return new JsonResult("Succesfully created");
        }
        [HttpPut]
        public JsonResult updateNevermine(Nevermind nevermind)
        {
            NevermindStorage.neverminds[nevermind.id] = nevermind;
            return new JsonResult("Succesfullt Updated");

        }
        [HttpDelete("{id}")]
        public JsonResult deleteNevermind(int id) 
        {
            var result = NevermindStorage.neverminds.SingleOrDefault(x => x.id == id);
            NevermindStorage.neverminds.Remove(result);
            return new JsonResult("Succesfully Deleted");
        }
    }
}
