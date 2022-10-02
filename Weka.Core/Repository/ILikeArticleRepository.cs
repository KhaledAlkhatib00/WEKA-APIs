using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface ILikeArticleRepository
    {
        bool CreateLike(LikeArticle likeArticle);
        bool DeleteLike(int id);
        List<LikeArticle> GetAllLikes();
        bool PublishTheArticle(int id);
        List<GetTheProfetDTO> GetTheProfet();
        List<GetTheLossesDTO> GetTheLosses();
        bool BlockArticle(int id);
        bool UnBlockArticle(int id);
    }
}
