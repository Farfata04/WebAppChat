using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppChat.Models;

namespace WebAppChat.ViewComponents
{
    public class RoomViewComponent:ViewComponent
    {
        private ApplicationDbContext _ctx;

        public RoomViewComponent(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke()
        {
            var chats = _ctx.Chats.ToList();
            return View(chats);

        }
    }
}
