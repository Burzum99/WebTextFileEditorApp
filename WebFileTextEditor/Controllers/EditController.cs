using System.Text;
using System.Web;
using System.Web.Mvc;
using WebFileEditor.Models;

namespace WebFileEditor.Controllers
{
    public class EditController : Controller
    {
        [HttpPost]
        public ActionResult Edit(string comment)
        {
            return File(Encoding.UTF8.GetBytes(comment),
                         "text/plain", "Output.txt");
        }
    }
}