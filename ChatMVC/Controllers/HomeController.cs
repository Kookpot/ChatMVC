using System.Web.Mvc;

namespace ChatMVC.Controllers
{
    /// <summary>
    /// homecontroller
    /// </summary>
    public class HomeController : Controller
    {
        #region Public Methods

        /// <summary>
        /// default page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        #endregion
    }
}