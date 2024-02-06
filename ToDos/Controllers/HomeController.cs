using Microsoft.AspNetCore.Mvc;
using ToDos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDos.Controllers
{
    public class HomeController : Controller
    {
      private readonly ToDosContext _db;

      public HomeController(ToDosContext db)
      {
        _db = db;
      }

     [HttpGet("/")]
      public ActionResult Index()
      {
        Category[] cats = _db.Categories.ToArray();
        Item[] items = _db.Items.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("categories", cats);
        model.Add("items", items);
        return View(model);
      }

      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
       return View();
      }

    }
}