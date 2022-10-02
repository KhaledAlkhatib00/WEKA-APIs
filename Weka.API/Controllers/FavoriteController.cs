using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class FavoriteController : Controller
    {
        private readonly IFavoriteService favoriteService;
        public FavoriteController(IFavoriteService _favoriteService)
        {
            favoriteService = _favoriteService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Favorite), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateFavorite([FromBody] Favorite favorite)
        {
            return favoriteService.CreateFavorite(favorite);
        }


        [HttpGet]
        [ProducesResponseType(typeof(Favorite), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Favorite> GetAllFavorite()
        {
            return favoriteService.GetAllFavorite();
        }

        [HttpDelete]
        [ProducesResponseType(typeof(Favorite), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("{id}/{uId}")]
        public bool DeleteFavorite(int id, int uid)
        {
            return favoriteService.DeleteFavorite(id, uid);
        }
    }
}
