using System.Web.Mvc;
using TDMWeb.Lib;

namespace TrelloConnectionWeb.Controllers
{
    [UsuarioLogado]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}