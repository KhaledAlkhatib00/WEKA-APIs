using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Weka.Core.Data;
using Weka.Core.Service;
namespace Weka.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : Controller
    {

        private readonly IContactUsService contactUsService;
        public ContactUsController(IContactUsService _contactUsService)
        {
            contactUsService = _contactUsService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        public List<ContactUs> GetAllContactUs()
        {
            return contactUsService.GetAllContactUs();
        }
        [HttpPost]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateContactUs([FromBody] ContactUs contactUs)
        {
            return contactUsService.CreateContactUs(contactUs);
        }

        [HttpPut]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateContactUs([FromBody] ContactUs contactUs)
        {
            return contactUsService.UpdateContactUs(contactUs);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteContactUs(int id)
        {
            return contactUsService.DeleteContactUs(id);
        }
    }  
}
