using Microsoft.AspNetCore.Mvc;
using ToDos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDos.Controllers
{
  public class ItemsController : Controller
  {
    private readonly ToDosContext _db;

    public ItemsController(ToDosContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Item> model = _db.Items.ToList();
      return View(model);
    }

    public ActionResult Create()
{
    return View();
}

[HttpPost]
public ActionResult Create(Item item)
{
    _db.Items.Add(item);
    _db.SaveChanges();
    return RedirectToAction("Index");
}
  }
}