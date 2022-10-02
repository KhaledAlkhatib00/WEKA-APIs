using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class LikeArticleService : ILikeArticleService
    {
        private readonly ILikeArticleRepository _likeArticleRepository;
        public LikeArticleService(ILikeArticleRepository likeArticleRepository)
        {
            _likeArticleRepository = likeArticleRepository;
        }

        public bool BlockArticle(int id)
        {
            return _likeArticleRepository.BlockArticle(id);
        }

        public bool CreateLike(LikeArticle likeArticle)
        {
            return _likeArticleRepository.CreateLike(likeArticle);
        }

        public bool DeleteLike(int id)
        {
            return _likeArticleRepository.DeleteLike(id);  
        }
        public List<LikeArticle> GetAllLikes()
        {
            return _likeArticleRepository.GetAllLikes();
        }

        public List<GetTheProfetDTO> GetTheProfet()
        {
            return _likeArticleRepository.GetTheProfet();
        }
        public List<GetTheLossesDTO> GetTheLosses()
        {
            return _likeArticleRepository.GetTheLosses();
        }



        public bool PublishTheArticle(int id)
        {
            return _likeArticleRepository.PublishTheArticle(id);
        }

        public bool UnBlockArticle(int id)
        {
            return _likeArticleRepository.UnBlockArticle(id);
        }

     
    }
}
