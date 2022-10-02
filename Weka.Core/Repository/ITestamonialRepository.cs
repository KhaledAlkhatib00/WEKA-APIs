using System;
using System.Collections.Generic;
using System.Text;
using Weka.Core.Data;
using Weka.Core.DTO;

namespace Weka.Core.IRepository
{
    public interface ITestamonialRepository
    {
        bool CreateTestamonial(Testamoniall testamonial);
        List<TestimonialDTO> GetAllTestamonial();
        bool UpdateTestamonial(Testamoniall testamonial);
        bool DeleteTestamonial(int id);
        bool ShowTestimonial(int id);
        bool HideTestimonial(int id);
        List<homeTestimonial> GetTestimonialForm();
    }
}
