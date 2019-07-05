using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

//
//Added 6/28/2019 Thomas Downes   
//
// https://theburningmonk.com/2010/02/converting-hex-to-int-in-csharp/
//

namespace ciBadgeForWeb.Controllers
{
    public class UploadBackController : Controller
    {
        /// <summary>
        /// https://theburningmonk.com/2010/02/converting-hex-to-int-in-csharp/
        /// </summary>
        /// <returns></returns>
        // GET: UploadBack
        public ActionResult Index()
        {
            return View();
        }

        //
        //https://www.dotnettricks.com/learn/mvc/how-to-upload-a-file-in-mvc4
        //

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file == null)
                {
                    ModelState.AddModelError("File", "Please Upload Your file");
                }
                else if (file.ContentLength > 0)
                {
                    int MaxContentLength = 1024 * 1024 * 3; //3 MB
                    string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };

                    if (!AllowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
                    {
                        ModelState.AddModelError("File", "Please file of type: " + string.Join(", ", AllowedFileExtensions));
                    }

                    else if (file.ContentLength > MaxContentLength)
                    {
                        ModelState.AddModelError("File", "Your file is too large, maximum allowed size is: " + MaxContentLength + " MB");
                    }
                    else
                    {
                        //TO:DO
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(Server.MapPath("~/Content/Upload"), fileName);
                        file.SaveAs(path); 
                        ModelState.Clear();
                        ViewBag.Message = "File uploaded successfully";

                        //Added 7/4/2019 thomas downes
                        //
                        System.Drawing.Image myImg = System.Drawing.Image.FromFile(path);
                        //(new ciLayoutPrintLib.BackImageExamples())

                    }
                }
            }
            //return View();
            return Redirect("~/LayoutText1");
        }


    }
}
