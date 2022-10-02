using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface ICommentLikesRepository
    {
        bool CreateCommentLikes(CommentLikes commentLikes);
        bool UpdateCommentLikes(CommentLikes commentLikes);
        bool DeleteCommentLikes(int id);

        List<GetCountOfLikeDTO> GetCommentLike(int id);
    }
}
