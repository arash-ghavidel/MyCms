using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace MyCms.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        MyCmsContext db = new MyCmsContext();
        PageGroupRepository pageGroupRepository;
        PageRepository pageRepository;
        public NewsController()
        {
            pageGroupRepository = new PageGroupRepository(db);
            pageRepository = new PageRepository(db);
        }
        public ActionResult ShowGroups()
        {
            return PartialView(pageGroupRepository.GetGroupsForView());
        }

        public ActionResult ShowGroupsInMenu()
        {
            return PartialView(pageGroupRepository.GetAllGroups());
        }
        public ActionResult TopNews()
        {
            return PartialView(pageRepository.TopNews());
        }
        public ActionResult LastNews()
        {
            return PartialView(pageRepository.LastNews());
        }
        [Route("Archive")]
        public ActionResult ArchivedNews()
        {
            return View(pageRepository.GetAllPage());
        }
        [Route("Group/{id}/{title}")]
        public ActionResult ShowNewsByGroupId(int id, string title)
        {
            ViewBag.name = title;
            return View(pageRepository.ShowPageByGroupId(id));
        }
    }
}