using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class MessageController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("SenderId,RecipientId")] string SenderId, string RecipientId)
        {
            ViewBag.sender_id = SenderId;
            ViewBag.recipient_id = RecipientId;
            return View();
        }
    }
}
