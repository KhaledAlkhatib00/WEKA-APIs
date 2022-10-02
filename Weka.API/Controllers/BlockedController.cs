using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockedController : Controller
    {
        private readonly IBlockedService blockedService;
        public BlockedController(IBlockedService _blockedService)
        {
            blockedService = _blockedService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Blocked), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateBlocked([FromBody] Blocked blocked)
        {
            return blockedService.CreateBlocked(blocked);
        }


        [HttpPut]
        [ProducesResponseType(typeof(Blocked), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateBlocked([FromBody] Blocked blocked)
        {
            return blockedService.UpdateBlocked(blocked);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Blocked), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("delete/{id}")]
        public bool DeleteBlocked(int id)
        {
            return blockedService.DeleteBlocked(id);
        }
    }
}
