using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Repository
{
    public interface ICommenttRepository
    {
        bool UpdateComments(Commentt commentt);
        bool CreateComments(Commentt commentt);
        List<Commentt> GetAllComments();
        bool DeleteComments(int id);
        List<GetCountOfCommenttDTO> GetCountOfComment();
        List<GetCountOfCommenttDTO> GetCountOfFavorite();
    }
}
