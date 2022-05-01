using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class EnrolmentController : Controller
    {
        private readonly IService<LnkClubScheduleUser> _lnkClubScheduleUserService;

        public EnrolmentController(IService<LnkClubScheduleUser> lnkClubScheduleUserService)
        {
            _lnkClubScheduleUserService = lnkClubScheduleUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Enrol([Bind("UserId,ClubScheduleId")] LnkClubScheduleUser lnk)
        {

                LnkClubScheduleUser lnkClubScheduleUser = _lnkClubScheduleUserService.GetAll().FirstOrDefault(e => e.ClubScheduleId == lnk.ClubScheduleId && e.UserId == lnk.UserId);
                if (lnkClubScheduleUser == null)
                {
                    try
                    {
                        _lnkClubScheduleUserService.Create(lnk);
                    
                        return RedirectToAction(nameof(EnrolSuccess));
                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction(nameof(EnrolFail));
                    }

                }
            
            return Redirect(HttpContext.Request.Headers["Referer"]);
        }

        public IActionResult EnrolSuccess()
        {
            return View();
        }

        public IActionResult EnrolFail()
        {
            return View();
        }
    }
}
