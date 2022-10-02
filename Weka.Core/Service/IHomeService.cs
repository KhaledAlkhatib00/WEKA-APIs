using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;

namespace Weka.Core.Service
{
    public interface IHomeService
    {
        bool CreateHome(Home home);
        List<Home> GetAllHome();
        bool UpdateHome(Home home);
        bool DeleteHome(int id);
    }
}
