using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class FavoriteService: IFavoriteService
    {
        private readonly IFavoriteRepository _favoriteRepository;
        public FavoriteService(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        public bool CreateFavorite(Favorite favorite)
        {
           return _favoriteRepository.CreateFavorite(favorite);
        }

        public bool DeleteFavorite(int id, int uid)

        {
            return _favoriteRepository.DeleteFavorite(id, uid);
        }

        public List<Favorite> GetAllFavorite()
        {
            return _favoriteRepository.GetAllFavorite();
        }
    }
}
