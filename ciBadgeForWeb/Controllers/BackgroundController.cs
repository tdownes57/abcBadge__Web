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
    public class BackgroundController : Controller
    {
        /// <summary>
        /// https://theburningmonk.com/2010/02/converting-hex-to-int-in-csharp/
        /// </summary>
        /// <returns></returns>
        /// 
        private static string mod_fileTitle_Current = "";

        public BackgroundController()
        {
            //---May 10--ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            //---May 10--ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (App_Start.DiskFolders.PathToFolderOfPics(true));
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (App_Start.DiskFolders.PathToFolderWithBacks(true));
        }

        //
        //Background Images
        //
        // 5-10-2020 td //public static IList<Models.Background> mod_backgrounds = new List<Models.Background>() {
        //        new Models.Background(){ Index = 0, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(0)  },
        //        new Models.Background(){ Index = 1, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(1) },
        //        new Models.Background(){ Index = 2, FileName = "..", Description ="..", BackgroundImage = BackImageExamples.Item(2)   },
        //        new Models.Background(){ Index = 3, FileName = "..", Description = "..", BackgroundImage = BackImageExamples.Item(3) } };
        public static IList<Models.Background> mod_backgrounds = new List<Models.Background>();

        public static bool SkipRefresh = false;  // Added 11/4/2021 thomas downes

        public static string Get_BackgroundFileTitle(string pstrConfig_Guid6 = "")
        {
            //
            // Added 11/04/2021 tdownes
            //
            return Models.Background.Get_FileTitle(pstrConfig_Guid6);

        }

        public static string Get_BackgroundFullPath(string pstrConfig_Guid6 = "")
        {
            //
            // Added 11/04/2021 tdownes
            //
            return Models.Background.Get_FullPath(pstrConfig_Guid6);

        }


        // GET: Background
        public ActionResult Index()
        {
            //----ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            //---ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
            //____ciPictures_VB.PictureExamples.PathToFolderOfImages = (App_Start.DiskFolders.PathToFolderOfPics(true));
            //____ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (App_Start.DiskFolders.PathToFolderWithBacks(true));
            //____
            //____return View();
            return UploadBack();
        }


        // GET: Background/UploadBack
        public ActionResult UploadBack()
        {
            //----ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            //---ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (App_Start.DiskFolders.PathToFolderOfPics(true));
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (App_Start.DiskFolders.PathToFolderWithBacks(true));

            return View();
        }


        // GET: UploadPic
        public ActionResult UploadPic()
        {
            //Added 5/5/2020 thomas downes
            ciPictures_VB.PictureExamples.PathToFolderOfImages = (App_Start.DiskFolders.PathToFolderOfPics(true));
            ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (App_Start.DiskFolders.PathToFolderWithBacks(true));

            return View();
        }

        // GET: ElementCacheXML
        public ActionResult ElementCacheXML()
        {
            //ciPictures_VB.PictureExamples.PathToFolderOfImages = (HttpRuntime.AppDomainAppPath + "Images\\PictureExamples");
            //ciLayoutPrintLib.BackImageExamples.PathToFolderWithBacks = (HttpRuntime.AppDomainAppPath + "Images\\BackExamples");

            //Added 5/5/2020 thomas downes
            return View();
        }

        // GET: Background
        public ActionResult ShowAll()
        {
            //return View();

            //
            //Refresh the background images, since someone may have just uploaded a new
            //   background image.  -----5/10/2020 thomas downes   
            //
            //====mod_backgrounds = RefreshBackgroundList();
            if (!BackgroundController.SkipRefresh) mod_backgrounds = RefreshBackgroundList();

            return View(mod_backgrounds);

        }

        // GET: Background/Edit/5
        public ActionResult Edit(int id)
        {
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
            return (ViewResult)View(background_by_id_onlyone);

        }


        // GET: Background/ShowCurrent
        public ActionResult ShowCurrent()
        {
            // Added 11/4/2021 td
            int intCurrentIndex = Models.Background.CurrentIndex_RunChecks();
            if (intCurrentIndex == 0)
            {
                // Added 11/4/2021 td
                intCurrentIndex = ciLayoutPrintLib.BackImageExamples.CurrentIndex;
                Models.Background.CurrentlySelectedBackIndex = intCurrentIndex;
            }

            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == intCurrentIndex);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
            return (ViewResult)View(background_by_id_onlyone);

        }


        // GET: Background/Create
        public ActionResult Create()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Background/Select/5
        public ActionResult Select(int id)
        {
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();

            ciLayoutPrintLib.BackImageExamples.CurrentIndex = id;
            Models.Background.CurrentlySelectedBackIndex = id;  //Added 11/2/2021 Thomas Downes 

            //return RedirectToAction("Index", "LayoutText1");
            return RedirectToAction("ShowCurrent", "Background");

        }

        // GET: Background/DeleteTentative/5
        public ActionResult DeleteTentative(int id)
        {
            //
            // Added 11/7/2021 Thomas Downes  
            //
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();

            const bool c_bDeleteWithConfirmation = false; // true;
            if (c_bDeleteWithConfirmation)
            {
                // Added 11/7/2021 Thomas Downes  
                System.IO.File.Delete(background_by_id_onlyone.FullPathToFile);
                mod_backgrounds.Remove(background_by_id_onlyone);
                //System.Threading.Thread.Sleep(1000);
                //return (ViewResult)View("ShowAll");
                return RedirectToAction("ShowAll");

            }
            else
            {
                //
                // Added 11/7/2021 thomas downes
                //
                //return View("Delete");
                return (ViewResult)View(background_by_id_onlyone);
            }


        }





        // GET: Background/DeleteConfirmed/5
        public ActionResult DeleteConfirmed(int id)
        {
            //
            // Added 11/7/2021 Thomas Downes  
            //
            var backgrounds_by_id_list = mod_backgrounds.Where(s => s.Index == id);
            var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
            int intIndexToDelete = background_by_id_onlyone.Index;  // Added 11/7/2021 Thomas  

            const bool c_bDeleteImmediately = true;  // false; // true;
            if (c_bDeleteImmediately)
            {
                // Added 11/7/2021 Thomas Downes  
                System.IO.File.Delete(background_by_id_onlyone.FullPathToFile);
                mod_backgrounds.Remove(background_by_id_onlyone);

                //If the deleted background is also the selected background...
                bool bJustDeletedWasSelected = (Models.Background.IsSelected(intIndexToDelete));
                if (bJustDeletedWasSelected) SetIndexToHighestValue();

                //System.Threading.Thread.Sleep(1000);
                //return (ViewResult)View("ShowAll");
                //return RedirectToAction("ShowAll");
                return (ViewResult)View("DeleteConfirmationMsg");

            }

        }


        // POST: Background/Edit/5
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
                            return Content(ViewBag.Message);
                        }

                        //Added 7/4/2019 thomas downes
                        //
                        //-----System.Drawing.Image myImg = System.Drawing.Image.FromFile(path);
                        //(new ciLayoutPrintLib.BackImageExamples())

                        //Added 11/4/2021 thomas downes
                        //
                        //  A couple of calls to methods that aren't written yet as of 11/4/2021.
                        //  The idea is to go from the UploadBack page to the ShowCurrent page,
                        //  with the just-uploaded Background displayed as the current badge-layout
                        //  background.  ---11/4/2021 td
                        //
                        int intNewIndex = 
                           Controllers.BackgroundController.AddNewBackgroundObject_ByPath(path);
                        Controllers.BackgroundController.SkipRefresh = true;
                        Models.Background.SetCurrentIndex(intNewIndex);

                    }
                }
            }
            
            //return View();
            //----return Redirect("~/LayoutText1/Index");
            //+++return Redirect("~/Background/ShowCurrent");
            return ShowCurrent();

        }


        public static List<Models.Background> RefreshBackgroundList()
        {
            //
            //Added 5/10/2020 thomas downes 
            //
            //  Copied from XmlCacheController, 5/10/2020
            //
            string strPathToFolderBacks = (App_Start.DiskFolders.PathToFolderWithBacks(true));

            //bool boolNotYetDetermined = ("" == mod_fileTitle_Current);
            bool boolExpectedFileType = false; // mod_fileTitleXML_Current.EndsWith(".xml");
            bool boolPossiblyCorrupt = false;  //Added 216/2019 td
            //bool boolMatchesCurrent = false;  //Added 5/10/2020 thomas downes
            var list_output = new List<Models.Background>();

            // Added 11/1/2021 thomas downes
            int intCountingIndex = 0;  // Added 11/1/2021 thomas downes

            //
            // To do: adapt from XML to background images. 
            //
            foreach (FileInfo each_file_Info in (new DirectoryInfo(strPathToFolderBacks)).GetFiles())
            {
                intCountingIndex++;  // Added 11/1/2021 thomas downes

                //Modified 2/16/2019 td
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".jpg");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".jpeg");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".png");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".gif");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".bmp");

                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".JPG");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".JPEG");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".PNG");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".GIF");
                boolExpectedFileType = boolExpectedFileType || each_file_Info.Name.EndsWith(".BMP");

                boolPossiblyCorrupt = (!(boolExpectedFileType));  //Added 2/16/2019 td
                if (boolPossiblyCorrupt) continue;  //Added 2/16/2019 td

                //if (boolGrabThisNextFile)
                //{
                //    obj_nextFileInfo = each_file_Info;
                //    break;
                //}
                //boolMatchesCurrent = (each_file_Info.Name == mod_fileTitle_Current);
                //if (boolMatchesCurrent)
                //{
                //    //mod_fileTitleXML_Current = each_file_Info.Name;
                //    //break;
                //    //-----Prepare for the next interation. 
                //    boolGrabThisNextFile = true;
                //}
                ////If we've come full circle, grab the first XML file.
                //if (boolStartFromBeginningAgain)
                //{
                //    //We've come full circle, so grab the first XML file.
                //    obj_nextFileInfo = each_file_Info;
                //    break;
                //}

                var objNewBack = new Models.Background()
                {
                    Index = intCountingIndex,
                    BackgroundImage = null,
                    Description = "A beautiful background!",
                    FileName = each_file_Info.Name,
                    FullPathToFile = each_file_Info.FullName,
                    UploadDate = each_file_Info.CreationTime
                };

                list_output.Add(objNewBack);

            }

            return list_output;

        }


        public static int GetHighestIndex()
        {
            //
            // Added 11/4/2021 thomas downes
            //
            if (mod_backgrounds.Count == 0)
            {
                mod_backgrounds = RefreshBackgroundList();

                // Double-check that our loading work suceeded as expected. 
                //   ---11/5/2021 td 
                if (mod_backgrounds.Count == 0) 
                    throw new Exception("No background images exist.");
            }
            return mod_backgrounds.OrderByDescending(s => s.Index).FirstOrDefault().Index;

        }


        public static int AddNewBackgroundObject_ByPath(string par_pathToUploadedBack)
        {
            //
            // Added 11/4/2021 thomas downes
            //
            System.IO.FileInfo obj_file_Info = new System.IO.FileInfo(par_pathToUploadedBack);

            var objNewBack = new Models.Background()
            {
                Index = (1 + GetHighestIndex()),
                BackgroundImage = null,
                Description = "A beautiful background!",
                FileName = obj_file_Info.Name,
                FullPathToFile = obj_file_Info.FullName,
                UploadDate = obj_file_Info.CreationTime
            };

            mod_backgrounds.Add(objNewBack);
            return objNewBack.Index;  

        }


        public void SetCurrentIndex(int par_indexToUse)
        {
            //
            // Added 11/7/2021 thomas downes
            //
            Models.Background.CurrentlySelectedBackIndex = par_indexToUse; 

        }


        public void SetIndexToHighestValue()
        {
            //
            // Added 11/7/2021 thomas downes
            //
            int indexToUse = GetHighestIndex();
            Models.Background.CurrentlySelectedBackIndex = indexToUse;

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
