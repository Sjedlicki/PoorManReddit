using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoorManReddit.Services;

namespace PoorManReddit.Controllers
{
    public class RedditController : Controller
    {
        private readonly IRedditService _service;

        public RedditController(IRedditService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _service.GetAll();

            return View(model);
        }
    }
}
