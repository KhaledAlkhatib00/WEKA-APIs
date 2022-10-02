using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class CommentLikesService : ICommentLikesService
    {
        private readonly ICommentLikesRepository _commentLikesRepository;
        public CommentLikesService(ICommentLikesRepository commentLikesRepository)
        {
            _commentLikesRepository = commentLikesRepository;
        }

        public bool CreateCommentLikes(CommentLikes commentLikes)
        {
           return _commentLikesRepository.CreateCommentLikes(commentLikes); 
        }

        public bool DeleteCommentLikes(int id)
        {
            return _commentLikesRepository.DeleteCommentLikes(id);    
        }

        public List<GetCountOfLikeDTO> GetCommentLike(int id)
        {
            return _commentLikesRepository.GetCommentLike(id);
        }

        public bool UpdateCommentLikes(CommentLikes commentLikes)
        {
            return _commentLikesRepository.UpdateCommentLikes(commentLikes);    
        }
    }
}
