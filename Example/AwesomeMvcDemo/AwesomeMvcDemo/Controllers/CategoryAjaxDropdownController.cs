using System.Linq;
using System.Web.Mvc;
using AwesomeMvcDemo.Models;
using Omu.AwesomeMvc;

namespace AwesomeMvcDemo.Controllers
{
    /*begin*/
    public class CategoryAjaxDropdownController : Controller
    {
        public ActionResult GetItems(int? v)
        {
            return Json(Db.Categories.Select(o => new SelectableItem(o.Id, o.Name, v == o.Id)));// value, text, selected
        }
    }/*end*/
}