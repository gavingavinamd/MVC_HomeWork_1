using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MapleStory2.Models;

namespace MapleStory2.Controllers
{
    public class MonsterController : Controller
    {
        // GET: MonsterController
        private static List<Monster> _monsters = new List<Monster>()
        {
            new Monster(){Id = 1, Name = "菇菇寶貝", Atk = 8, Hp = 10},
            new Monster(){Id = 2, Name = "超級綠水靈", Atk = 80, Hp = 3000},
        };


        public ActionResult Index()
        {
            return View(_monsters);
        }

        // GET: MonsterController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonsterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonsterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Monster model)
        {
            try
            {
                _monsters.Add(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonsterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonsterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonsterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonsterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
