using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private IStoreBL _storeBL;
        public StoreController(IStoreBL p_storeBL)
        {
            _storeBL = p_storeBL;
        }

        [HttpGet("ViewStoreInventory")]
        public IActionResult ViewStoreInventory([FromQuery] int p_sId)
        {
            return Ok(_storeBL.ViewStoreInventory(p_sId));
        }

    }
}