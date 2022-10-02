using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.IRepository
{
    public interface IHomeRepository
    {
        bool CreateHome(Home home);
        List<Home> GetAllHome();
        bool UpdateHome(Home home);
        bool DeleteHome(int id);
    }
}
