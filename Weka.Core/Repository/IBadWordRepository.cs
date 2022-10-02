using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface IBadWordRepository
    {
        bool CreateBadWord(BadWord badWord);
        bool UpdateBadWord(BadWord badWord);
        List<BadWord> GetAllBadWord();
        bool DeleteBadWord(int id);
    }
}
