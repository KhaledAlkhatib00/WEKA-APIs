using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class BadWordService : IBadWordService
    {
        private readonly IBadWordRepository badWordRepository;
        public BadWordService(IBadWordRepository _badWordRepository)
        {
            badWordRepository = _badWordRepository;
        }

        public bool CreateBadWord(BadWord badWord)
        {
            return badWordRepository.CreateBadWord(badWord);
        }

        public bool DeleteBadWord(int id)
        {
            return badWordRepository.DeleteBadWord(id);
        }

        public List<BadWord> GetAllBadWord()
        {
            return badWordRepository.GetAllBadWord();
        }

        public bool UpdateBadWord(BadWord badWord)
        {
            return badWordRepository.UpdateBadWord(badWord);
        }
    }
}
