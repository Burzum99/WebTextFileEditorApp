using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using WebFileEditor.Models;

namespace WebFileEditor.Controllers
{
    public class UploadController : Controller
    {
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase fileUpload)
        {

            string result = new StreamReader(fileUpload.InputStream).ReadToEnd();

            var model = new TextEditorViewModel
            {
                DisplayText = result
            };


            return View("~/Views/Home/Index.cshtml", model);
        }
    }
}