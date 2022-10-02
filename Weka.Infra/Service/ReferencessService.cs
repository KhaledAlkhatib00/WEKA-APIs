using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class ReferencessService : IReferencessService
    {
        private readonly IReferencessRepository referencessRepository;
        public ReferencessService(IReferencessRepository _referencessRepository)
        {
            referencessRepository = _referencessRepository ;
        }

        public bool CreateReferences(Referencess referencess)
        {
            return referencessRepository.CreateReferences(referencess);
        }

        public bool DeleteReferences(int id)
        {
            return referencessRepository.DeleteReferences(id);
        }

        public List<Referencess> GetAllReferences()
        {
            return referencessRepository.GetAllReferences();
        }

        public bool UpdateReferences(Referencess referencess)
        {
            return referencessRepository.UpdateReferences(referencess);
        }
    }
}
