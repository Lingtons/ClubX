using Clubx.Models;
using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<Club> _clubService;
        private readonly IService<LnkClubUser> _lnkClubUserService;
        private readonly IService<ClubSchedule> _clubScheduleService;
        private readonly IService<ClubPayment> _clubPaymentService;

        public HomeController(ILogger<HomeController> logger, 
            IService<Club> clubService, 
            IService<LnkClubUser> lnkClubUserService, 
            IService<ClubSchedule> clubScheduleService,
            IService<ClubPayment> clubPaymentService)
        {
            _logger = logger;
            _clubService = clubService;
            _lnkClubUserService = lnkClubUserService;
            _clubScheduleService = clubScheduleService;
            _clubPaymentService = clubPaymentService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clubScheduleService.GetAll()
                .Include(e => e.Club)
                .Include(e => e.LnkClubScheduleUsers)
                .Where(e => e.ExpirationDate.AddDays(1) >= DateTime.Now)
                .ToListAsync());
        }

        public async Task<IActionResult> ViewClub(Guid id)
        {
            ViewBag.club_members = await _lnkClubUserService.GetAll()
                .Include(d => d.User)
                .Where(d => d.ClubId == id).ToListAsync();

            ViewBag.club_sessions = await _clubScheduleService.GetAll()
                .Where(e => e.ClubId == id).ToListAsync();

            return View(_clubService.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enrol([Bind("UserId,ClubId,HasMembershipFee")] Guid clubId, string userId, int HasMembershipFee)
        {
            if (ModelState.IsValid)
            {
                if (!_lnkClubUserService.GetAll().Any(e => e.ClubId == clubId && e.UserId == userId))
                {
                    if (HasMembershipFee == 1)
                    {
                        //record payment
                        Club club = _clubService.Get(clubId);
                        if (club != null)
                        {
                            ClubPayment payment = new ClubPayment {ClubId = clubId, Amount = club.Amount.Value, Description = "Membership Payment", PaymentExpiration = DateTime.Now.AddYears(1), PaymentMethod = 57, PaymentType = 58, UserId = userId  };
                            _clubPaymentService.Create(payment);                            
                        }
                    }
                    LnkClubUser lnk = new LnkClubUser { ClubId = clubId, UserId = userId};
                    _lnkClubUserService.Create(lnk);
                }
            }
            return Redirect(HttpContext.Request.Headers["Referer"]);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LinkClubAdmin([Bind("UserId,ClubId")] LnkClubUser clubUser)
        {
            if (ModelState.IsValid)
            {
                LnkClubUser lnkClubUser = _lnkClubUserService.GetAll().FirstOrDefault(e => e.ClubId == clubUser.ClubId && e.UserId == clubUser.UserId);
                if (lnkClubUser != null)
                {
                    lnkClubUser.HasClubAdminRole = true;
                    _lnkClubUserService.Update(lnkClubUser);
                }
            }
            return Redirect(HttpContext.Request.Headers["Referer"]);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMeeting(ClubSchedule meeting)
        {
            try
            {
                _clubScheduleService.Create(meeting);
            }
            catch (Exception ex)
            {

                _logger.LogInformation(ex.Message);
            }

            return Redirect(HttpContext.Request.Headers["Referer"]);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
