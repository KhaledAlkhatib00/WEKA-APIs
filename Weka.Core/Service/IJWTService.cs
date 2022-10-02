using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.Service
{
    public interface IJWTService
    {
        String Auth(LoginDTO loginDTO);

    }
}
