using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ciLayoutPrintLib; // Added 7/7/2019 thomas downes

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
        /// 

        public UploadBackController()
        {
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
        }

        //
        //Background Images
        //
        public static IList<Models.Background> mod_backgrounds = new List<Models.Background>() {
                    new Models.Background(){ Index = 0, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(0)  },
                    new Models.Background(){ Index = 1, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(1) },
                    new Models.Background(){ Index = 2, FileName = "..", Description ="..", BackgroundImage = BackImageExamples.Item(2)   },
                    new Models.Background(){ Index = 3, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(3) } };

        // GET: UploadBack
        public ActionResult Index()
        {
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            return View();
        }

        // GET: UploadBack
        public ActionResult ShowAll()
        {
            //return View();

            return View(mod_backgrounds);

        }

        // GET: Recipient/Edit/5
        public ActionResult Edit(int id)
        {
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id );
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
            return (ViewResult)View(background_by_id_onlyone);

        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Recipient/Select/5
        public ActionResult Select(int id)
        {
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();

            ciLayoutPrintLib.BackImageExamples.CurrentIndex = id;

            return RedirectToAction("Index", "LayoutText1");

        }

        // GET: Recipient/Delete/5
        public ActionResult Delete(int id)
        {
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
            mod_backgrounds.Remove(background_by_id_onlyone);

            //System.Threading.Thread.Sleep(1000);

            //return (ViewResult)View("ShowAll");
            return RedirectToAction("ShowAll");

        }

        // POST: Recipient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // Added 7/7/2019 thomas downes
                //
                var edited_back = mod_backgrounds.Where(s => s.Index == id).FirstOrDefault();

                UpdateModel(edited_back, collection);

                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("ShowAll");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            }
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

                    // 10-7-2019 td //string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };
                    string[] AllowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".JPG", ".GIF", ".PNG" };

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
                        //Save #1 of 2.  System.IO.Path.Combine !!
                        //
                        string fileName = Path.GetFileName(file.FileName);

                        // 10/8/2019 td''string path = Path.Combine(Server.MapPath("~/Content/Upload"), fileName);
                        // 10/8/2019 td''file.SaveAs(path);

                        //Save #2 of 2.  System.IO.Path.Combine !!
                        //
                        //path = Path.Combine("C:\\CI Solutions\\CI Badge Web\\ciPictures_VB\\BackExamples", fileName);

                        //System.Web.HttpException: 'The SaveAs method is configured to require a rooted path, and the path '~/Images/BackExamples\1958.png' is not rooted.'
                        //#1 10/7/2019 td//path = Path.Combine("~/Images/BackExamples", fileName);
                        // #2 10/7/2019 td//path = Path.Combine("C:\\Users\\tdown\\source\\repos\\ciLayout\\ciLayoutPrintLib\\BackExamples", fileName);
                        // #3 10/7/2019 td//path = Path.Combine(Server.MapPath("~/Images/BackExamples"), fileName);

                        string path = Path.Combine(ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks, fileName);

                        try
                        {
                            file.SaveAs(path);
                            ModelState.Clear();
                            ViewBag.Message = "File uploaded successfully";
                        }
                        catch (Exception ex_up)
                        {
                            ViewBag.Message = "File upload error, " + ex_up.Message;
                        }

                        //Added 7/4/2019 thomas downes
                        //
                        System.Drawing.Image myImg = System.Drawing.Image.FromFile(path);
                        //(new ciLayoutPrintLib.BackImageExamples())

                    }
                }
            }
            //return View();
            return Redirect("~/LayoutText1/Index");
        }

        //        <body>
        //
        //    <h1>Super Upload Page</h1>
        //
        //    <p>Things to upload: </p>
        //
        //    <ol>
        //        <li>Background Images for Badges</li>
        //        <li>Portrait Images</li>
        //        <li>Zipped collection of Images</li>
        //        <li>XML files with Personality Configuration / Elements Cache</li>
        //        <li>MDB files, especially CIBData83.mdb, for storage of data</li>
        //        <li>Signature Image from the Topaz Signature Pad</li>
        //        <li>Driver's License Data</li>
        //    </ol>
        //
        // </body>
        // </html>

    }
}
