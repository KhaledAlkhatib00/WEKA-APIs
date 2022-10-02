using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IReferencessService
    {
        bool UpdateReferences(Referencess referencess);
        bool CreateReferences(Referencess referencess);
        List<Referencess> GetAllReferences();
        bool DeleteReferences(int id);
    }
}
