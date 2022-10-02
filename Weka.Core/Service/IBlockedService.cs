using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IBlockedService
    {
        bool CreateBlocked(Blocked blocked);
        bool UpdateBlocked(Blocked blocked);
        bool DeleteBlocked(int id);
    }
}
