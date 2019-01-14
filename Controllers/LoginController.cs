using System.Linq;
using System.Web.Mvc;
using TrelloConnectionWeb.Models;

namespace TrelloConnectionWeb.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("Index")]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult IndexPost()
        {
            string login = Request.Form.Get("login");
            string password = Request.Form.Get("password");
            Entities db = new Entities();

            Usuario usuarioDB = db.Usuario.Where(u => u.Login.Equals(login)).Where(u => u.Password.Equals(password)).FirstOrDefault();

            if (usuarioDB != null)
            {
                Session["ObjUsuario"] = usuarioDB;
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Credenciais inválidas");
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();

            return RedirectToAction("Index");
        }
    }
}