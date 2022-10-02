using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;
using Weka.Core.IRepository;
using Weka.Core.Service;
namespace Weka.Infra.Service
{
    public class TestamonialService: ITestamonialService
    {
        private readonly ITestamonialRepository TestamonialRepository;
        public TestamonialService(ITestamonialRepository _testamonialRepository)
        {
            TestamonialRepository = _testamonialRepository;

        }

        public bool CreateTestamonial(Testamoniall testamonial)
        {
            return TestamonialRepository.CreateTestamonial(testamonial);
        }

        public bool DeleteTestamonial(int id)
        {
            return TestamonialRepository.DeleteTestamonial(id);
        }

        public List<TestimonialDTO> GetAllTestamonial()
        {
            return TestamonialRepository.GetAllTestamonial();
        }

        public bool HideTestimonial(int id)
        {
            return TestamonialRepository.HideTestimonial(id);
        }

        public bool ShowTestimonial(int id)
        {
            return TestamonialRepository.ShowTestimonial(id);
        }

        public bool UpdateTestamonial(Testamoniall testamonial)
        {
            return TestamonialRepository.UpdateTestamonial(testamonial);
        }
        public List<homeTestimonial> GetTestimonialForm()
        {
            return TestamonialRepository.GetTestimonialForm();
        }

    }
}
