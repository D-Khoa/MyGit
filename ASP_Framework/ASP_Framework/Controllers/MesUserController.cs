using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ASP_Framework.Models;

namespace ASP_Framework.Controllers
{
    public class MesUserController : Controller
    {
        // GET: MesUser
        [HttpGet]
        public ActionResult Index()
        {
            IEnumerable<m_mes_user> users = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44323/Api/");
                var getTask = client.GetAsync("MesUser");
                getTask.Wait();
                var result = getTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<m_mes_user>>();
                    readTask.Wait();
                    users = readTask.Result;
                }
                else
                {
                    users = Enumerable.Empty<m_mes_user>();
                    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                }
            }
            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(m_mes_user inUser)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44323/Api/MesUser");
                var postTask = client.PostAsJsonAsync<m_mes_user>("MesUser", inUser);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode) return RedirectToAction("Index");
            }
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            return View(inUser);
        }
    }
}