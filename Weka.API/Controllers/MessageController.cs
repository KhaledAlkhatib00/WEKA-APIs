using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Weka.Core.Data;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }


        [HttpPost]
        public bool CreateMessage([FromBody] Message message)
        {
            return messageService.CreateMessage(message);
        }


        [HttpGet]
        public List<Message> GetAllMessage()
        {
           return messageService.GetAllMessage();
        }



        [HttpDelete]
        [Route("{id}")]
        public bool DeleteMessage(int id)
        {
            return messageService.DeleteMessage(id);
        }
    }
}
