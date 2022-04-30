using Clubx.Models;
using DataAccess.IServices;
using DataAccess.Models;
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
        private readonly IService<Clubs> _clubService;
        private readonly IService<LnkClubUser> _lnkClubUserService;
        public HomeController(ILogger<HomeController> logger, IService<Clubs> clubService, IService<LnkClubUser> lnkClubUserService)
        {
            _logger = logger;
            _clubService = clubService;
            _lnkClubUserService = lnkClubUserService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clubService.GetAll().ToListAsync());
        }

        public IActionResult ViewClub(Guid id)
        {
            return View(_clubService.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enrol([Bind("UserId,ClubId")] LnkClubUser clubUser)
        {
            if (ModelState.IsValid)
            {
                if (!_lnkClubUserService.GetAll().Any(e => e.ClubId == clubUser.ClubId && e.UserId == clubUser.UserId))
                {
                    _lnkClubUserService.Create(clubUser);
                }
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
