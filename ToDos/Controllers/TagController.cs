using Microsoft.AspNetCore.Mvc;
using ToDos.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDos.Controllers
{
  public class TagsController : Controller
  {
    private readonly ToDosContext _db;
    
    public TagsController(ToDosContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Tags.ToList());
    }

    public ActionResult Details(int id)
    {
      Tag thisTag = _db.Tags
          .Include(tag => tag.JoinEntities)
          .ThenInclude(join => join.Item)
          .FirstOrDefault(tag => tag.TagId == id);
      return View(thisTag);
    }

    public ActionRe
  }
}