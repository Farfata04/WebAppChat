using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppChat.Data;
using WebAppChat.Models;

namespace WebAppChat.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _ctx;

        public HomeController(ApplicationDbContext ctx) => _ctx = ctx;
        
        public IActionResult Index() => View();
        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            _ctx.Chats.Add(new Chat
            {
                Name=name,
                Type=ChatType.Room
            });
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
