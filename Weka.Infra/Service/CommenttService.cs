using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class CommenttService : ICommenttService
    {
        private readonly ICommenttRepository commenttRopository;
        public CommenttService(ICommenttRepository _commenttRepository)
        {
            commenttRopository = _commenttRepository;
        }

        public bool CreateComments(Commentt commentt)
        {
            return commenttRopository.CreateComments(commentt);
        }

        public bool DeleteComments(int id)
        {
            return commenttRopository.DeleteComments(id);
        }

        public List<Commentt> GetAllComments()
        {
            return commenttRopository.GetAllComments();
        }

        public List<GetCountOfCommenttDTO> GetCountOfComment()
        {
            return commenttRopository.GetCountOfComment();
        }

        public List<GetCountOfCommenttDTO> GetCountOfFavorite()
        {
            return commenttRopository.GetCountOfFavorite();
        }

        public bool UpdateComments(Commentt commentt)
        {
            return commenttRopository.UpdateComments(commentt);
        }
    }
}
