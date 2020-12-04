using IceCreamParlorApi.Data;
using IceCreamParlorApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IceCreamParlorApi.Controllers
{
    [ApiController]
    [Route("api/icecreams")]
    public class IceCreamController : ControllerBase
    {
        private readonly IParlorRepo _repository;
        public IceCreamController(IParlorRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockSeedDataRepo _repository = new MockSeedDataRepo();
        [HttpGet]
        public ActionResult<IEnumerable<IceCream>> GetAllItems()
        {
            var icecreams = _repository.GetAllItems();
            return Ok(icecreams);
        }
    }
}
