using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChitChat.Models;

namespace ChitChat.Views.Shared
{
    public class DirectMessageViewComponent : ViewComponent
    {
        private IMessage repository;

        public DirectMessageViewComponent(IMessage repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["User"];
            return View(repository.User
            .Select(x => x.UserName)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}
