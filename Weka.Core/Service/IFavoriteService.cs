using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IFavoriteService
    {
        List<Favorite> GetAllFavorite();
        bool CreateFavorite(Favorite favorite);
        bool DeleteFavorite(int id, int uid);
    }
}
