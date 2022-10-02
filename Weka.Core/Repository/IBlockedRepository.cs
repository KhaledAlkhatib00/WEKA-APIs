using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Repository
{
    public interface IBlockedRepository
    {
        bool CreateBlocked(Blocked blocked);
        bool UpdateBlocked(Blocked blocked);
        bool DeleteBlocked(int id);
    }
}
