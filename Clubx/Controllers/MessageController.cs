using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    [Authorize()]
    public class MessageController : Controller
    {
        private readonly IService<Message> _messageService; 
        public MessageController(IService<Message> messageService)
        {
            _messageService = messageService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("SenderId,RecipientId","MessageBody")] Message message)
        {
            ViewBag.sender_id = message.SenderId;
            ViewBag.recipient_id = message.RecipientId;

            if (message.MessageBody != null)
            {
                try
                {
                    _messageService.Create(message);
                }
                catch (Exception ex)
                {
                    throw;
                }
             
            }
            return View(await _messageService.GetAll().Where(e => (e.RecipientId == message.RecipientId && e.SenderId == message.SenderId) || (e.RecipientId == message.SenderId && e.SenderId == message.RecipientId)).Include(e => e.Recipient).OrderByDescending(e => e.CreatedAt).ToListAsync());
        }
    }
}
