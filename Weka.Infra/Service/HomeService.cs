using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.IRepository;
using Weka.Core.Service;
namespace Weka.Infra.Service
{
    public class HomeService:IHomeService
    {
        private readonly IHomeRepository HomeRepository;
        public HomeService(IHomeRepository _homeRepository)
        {
            HomeRepository = _homeRepository;

        }

        public bool CreateHome(Home home)
        {
            return HomeRepository.CreateHome(home);
        }

        public bool DeleteHome(int id)
        {
            return HomeRepository.DeleteHome(id);
        }

        public List<Home> GetAllHome()
        {
            return HomeRepository.GetAllHome();
        }

        public bool UpdateHome(Home home)
        {
            return HomeRepository.UpdateHome(home);
        }
    }
}
