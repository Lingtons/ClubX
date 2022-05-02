using Clubx.Models;
using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class SessionController : Controller
    {
        private readonly IService<ClubSchedule> _clubScheduleService;
        private readonly IService<LnkClubScheduleUser> _lnkClubScheduleUserService;
        private readonly UserManager<ApplicationUser> _userManager;

        public SessionController(IService<ClubSchedule> clubScheduleService,
            IService<LnkClubScheduleUser> lnkClubScheduleUserService,
            UserManager<ApplicationUser> userManager)
        {
            _clubScheduleService = clubScheduleService;
            _lnkClubScheduleUserService = lnkClubScheduleUserService;
            _userManager = userManager;
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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            return View(await _lnkClubScheduleUserService.GetAll()
                .Include(e => e.ClubSchedule)
                .ThenInclude(e => e.Club)
                .Where(e => e.UserId == userId)
                .AsNoTracking()
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync());
        }
    }
}
