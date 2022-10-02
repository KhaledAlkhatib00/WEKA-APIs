using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.Repository;
using Weka.Core.Service;

namespace Weka.Infra.Service
{
    public class BlockedService : IBlockedService
    {
        private readonly IBlockedRepository _blockedRepository;
        public BlockedService(IBlockedRepository blockedRepository)
        {
            _blockedRepository = blockedRepository;
        }

        public bool CreateBlocked(Blocked blocked)
        {
            return _blockedRepository.CreateBlocked(blocked);   
        }

        public bool DeleteBlocked(int id)
        {
            return _blockedRepository.DeleteBlocked(id);    
        }

        public bool UpdateBlocked(Blocked blocked)
        {
            return (_blockedRepository.UpdateBlocked(blocked)); 
        }
    }
}
