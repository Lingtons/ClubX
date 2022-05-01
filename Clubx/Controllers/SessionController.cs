using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class SessionController : Controller
    {
        private readonly IService<ClubSchedule> _clubScheduleService;
     
        public SessionController(IService<ClubSchedule> clubScheduleService)
        {
            _clubScheduleService = clubScheduleService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clubScheduleService.GetAll()
                .Include(e => e.Club)
                .Include(e => e.LnkClubScheduleUsers)
                .Where(e => e.ExpirationDate.AddDays(1) >= DateTime.Now)
                .ToListAsync());
        }

        [Authorize()]
        public async Task<IActionResult> MySessions()
        {
            return View(await _clubScheduleService.GetAll()
                .Include(e => e.Club)
                .Include(e => e.LnkClubScheduleUsers)
                .Where(e => e.ExpirationDate.AddDays(1) >= DateTime.Now)
                .ToListAsync());
        }
    }
}
