using DataAccess.IServices;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clubx.Controllers
{
    public class ClubController : Controller
    {
        private readonly IService<Club> _clubService;

        public ClubController(IService<Club> clubService)
        {
            _clubService = clubService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clubService.GetAll()
                .ToListAsync());
        }
    }
}
