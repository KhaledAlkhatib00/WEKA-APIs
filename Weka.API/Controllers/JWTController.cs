using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using Weka.Core.DTO;
using Weka.Core.Service;

namespace Weka.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class JWTController : Controller
    {
        private readonly IJWTService jwtServise;
        public JWTController(IJWTService jwtService)
        {
            this.jwtServise = jwtService;
        }

        [HttpPost]
        public IActionResult Authen([FromBody] LoginDTO login)
        {
            var token = jwtServise.Auth(login);
            if (token == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(token);
            }
        }




        [HttpPost]
        public bool SendEmail([FromBody] EmailDTO email)
        {
            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Weka.", "Wekatahaluf@outlook.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress("User", "" + email.to + "");
            message.To.Add(to);
            message.Subject = email.subject;
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = email.body;
            message.Body = bodyBuilder.ToMessageBody();
            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp.outlook.com", 587, false);
                clinte.Authenticate("Wekatahaluf@outlook.com", "Test123Test123");
                clinte.Send(message);
                clinte.Disconnect(true);
            }
            return true;
        }



    }
}
