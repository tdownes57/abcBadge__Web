using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  // Added 3/21/2020 Thomas Downes 
using ciBadgeElements;  // Added 4/6/2020 Thomas Downes   
using System.Drawing;   // Added 4/22/2020 thomas downes  
//
//     // See also, the CIBadgeElements Project, for JSON- & DIVs- related code. 
//     //   ---Actually, I wasn't able to find it, so maybe I didn't do it.
//     //   ---  So, see Models/ElementDivs.cs.  -----4/2/2020 thomas d. 
//

namespace ciBadgeForWeb.Controllers
{
    public class JsonFileController : Controller
    {
        //
        //     // See also, the CIBadgeElements Project, for JSON- & DIVs- related code. 
        //     //   ---Actually, I wasn't able to find it, so maybe I didn't do it.
        //     //   ---  So, see Models/ElementDivs.cs.  -----4/2/2020 thomas d. 
        //
        //Added 3/21/2020 Thomas Downes
        public static JsonFile JsonFile_MoveableDivs = new JsonFile();
        //Added 4/16/2020 Thomas Downes
        public static MoveableDivImage MoveableDivs;  //--- = new JsonFile();

        //Added 4/22/2020 thomas downes 
        //---public static Point OffsetPoint = new Point(100, 100);
        //--- 5/2/2020 td ---//public static Point OffsetPoint = new Point(200, 100);
        public static Point OffsetPoint = new Point(300, 200);
        public static Point LayoutSize = new Point(650, 410);

        public static MoveableDivImage GetMoveableDivs()
        {
            //
            // Added 4/22/2020 td 
            //
            MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            if (JsonFileController.MoveableDivs == null)
            {
                // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
                objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
                JsonFileController.MoveableDivs = objectMoveableDivs;
            }
            return objectMoveableDivs;
        }

    // GET: JsonFile
    public ActionResult Index()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //

            //JsonFile objectJsonFile = new JsonFile();
            // 5/2/2020 thomas downes //---var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;

            //return View(objectJsonFile);
            //return IndexGroupWidth();

            //---   4/13/2020  ---//return View(objectJsonFile);
            //---   4/16/2020  ---//var objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);

            //Added 4/16/2020 thomas downes 
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs; 
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //return View(objectMoveableDivs);

            //Added 5/2/2020 thomas downes  
            ViewBag.LayoutWidthPixels = ClassElementsCache_Deprecated.Singleton.BadgeLayout.Width_Pixels;
            ViewBag.LayoutHeightPixels = ClassElementsCache_Deprecated.Singleton.BadgeLayout.Height_Pixels;
            ViewBag.OffsetLeftPixels = OffsetPoint.X;
            ViewBag.OffsetTopPixels = OffsetPoint.Y;

            //Modified 4/22/2020 td
            return View(GetMoveableDivs());

        }

       // GET:
        public ActionResult TableEdit()
        {
            //
            // Added 4/18/2020 Thomas Downes  
            //
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //return View(objectMoveableDivs);

            //Modified 4/22/2020 td
            return View(GetMoveableDivs());

        }

        // GET:
        public ActionResult TableDivsLeft()
        {
            //
            // Added 4/18/2020 Thomas Downes  
            //
            //Added 4/16/2020 thomas downes 
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_Left objectMoveLeft = JsonFileController.MoveableDivs.MoveLeft;
            Moveable_Left objectMoveLeft = JsonFileController.GetMoveableDivs().MoveLeft;
            return View(objectMoveLeft);

        }

        // GET:
        public ActionResult TableDivsTop()
        {
            //
            // Added 4/18/2020  Thomas Downes  
            //
            //Added 4/16/2020 thomas downes 

            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_Top objectMoveTop = JsonFileController.MoveableDivs.MoveTop;
            //return View(objectMoveTop);
            Moveable_Top objectMoveTop = JsonFileController.GetMoveableDivs().MoveTop;
            return View(objectMoveTop);

        }

        // GET:
        public ActionResult TableDivsWidth()
        {
            //
            // Added 4/18/2020  Thomas Downes  
            //

            ////Added 4/16/2020 thomas downes 
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_Width objectMoveWidth = JsonFileController.MoveableDivs.MoveWidth;

            Moveable_Width objectMoveWidth = JsonFileController.GetMoveableDivs().MoveWidth;
            return View(objectMoveWidth);

        }

        // GET:
        public ActionResult TableDivsHeight()
        {
            //
            // Added 4/18/2020  Thomas Downes  
            //

            //Added 4/16/2020 thomas downes 
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            Moveable_Height objectMoveHeight = JsonFileController.GetMoveableDivs().MoveHeight;
            return View(objectMoveHeight);

        }


        // GET:
        public ActionResult TableDivsDisplayed()
        {
            //
            // Added 4/20/2020  Thomas Downes  
            //
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_Displayed objectMoveDisplayed = JsonFileController.MoveableDivs.MoveDisplayed;
            Moveable_Displayed objectMoveDisplayed = JsonFileController.GetMoveableDivs().MoveDisplayed;
            return View(objectMoveDisplayed);

        }

        // GET:
        public ActionResult TableDivsHasField()
        {
            //
            // Added 4/20/2020  Thomas Downes  
            //
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_HasField objectMoveHasField = JsonFileController.MoveableDivs.MoveHasField;
            Moveable_HasField objectMoveHasField = JsonFileController.GetMoveableDivs().MoveHasField;
            return View(objectMoveHasField);

        }

        // GET:
        public ActionResult TableDivsFieldName()
        {
            // Added 4/20/2020  Thomas Downes  
            //MoveableDivImage objectMoveableDivs = JsonFileController.MoveableDivs;
            //if (JsonFileController.MoveableDivs == null)
            //{
            //    // 4-22-2020 td //objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            //    objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, OffsetPoint);
            //    JsonFileController.MoveableDivs = objectMoveableDivs;
            //}
            //Moveable_FieldNm objectMoveFieldNm = JsonFileController.MoveableDivs.MoveFieldName;
            Moveable_FieldNm objectMoveFieldNm = JsonFileController.GetMoveableDivs().MoveFieldName;
            return View(objectMoveFieldNm);

        }


        // GET: JsonFile
        public ActionResult IndexGroupWidth()
        {
            //
            // Added 3/21/2020 Thomas Downes  
            //
            //JsonFile objectJsonFile = new JsonFile();
            var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;

            return View(objectJsonFile);

        }

        // GET: JsonFile
        public ActionResult MoveableDivImage()
        {
            //
            // Added 4/06/2020 Thomas Downes  
            //
            //----4-22-2020 td //var objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton);
            var objectMoveableDivs = new MoveableDivImage(ClassElementsCache_Deprecated.Singleton, 
                Controllers.JsonFileController.OffsetPoint);

            return View(objectMoveableDivs);

        }





        // GET: JsonFile
        public ActionResult LayoutOfElements()
        {
            //
            // Added 4/02/2020 Thomas Downes  
            //
            var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
            var objectJSON = new JsonFile();


            return View(objectJsonFile);

        }


        //// GET: JsonFile
        //public ActionResult Index()
        //{
        //    //
        //    // Added 3/21/2020 Thomas Downes  
        //    //
        //    //JsonFile objectJsonFile = new JsonFile();
        //    var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
        //
        //    return View(objectJsonFile);
        //
        //}

        // GET: JsonFile
        public ActionResult TestModeSwitching()
        {
            //
            // Added 3/25/2020 Thomas Downes 
            //
            //   I want to test the mode-switching look & feel (& features,
            //   such as alignment left-edge, top-edge, etc.)
            //
            return View();
        }

        // GET: JsonFile
        public ActionResult TestExportFromModule()
        {
            //
            // Added 3/25/2020 Thomas Downes 
            //
            //  https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Statements/export
            //
            //  https://stackoverflow.com/questions/15760462/why-does-typescript-use-the-keyword-export-to-make-classes-and-interfaces-publ
            //
            return View();
        }

        // POST: JsonFile/Index/5
        [HttpPost]
        public ActionResult Index(FormCollection collection) //  int id, FormCollection collection)
        {
            try
            {
                // Save the JSON string with the Left & Top positions of the elements. 

                //Added 3/21/2020 thomas downes
                // 3/24/2020 td//JsonFile_MoveableDivs.JsonTextContent = collection["JsonTextContent"];

                //Added 4/16/2020 thomas downes 
                const bool c_boolJsonFileObject = false;
                const bool c_boolMoveableDivs = true;

                const bool c_boolHasOffsets = true; //Added 4-22-2020 thomas downes  

                if (c_boolMoveableDivs)
                {
                    //
                    //Added 4/16/2020 thomas downes
                    //
                    var objectMoveableDivs = JsonFileController.MoveableDivs;
                    //4-22-2020//objectMoveableDivs.SavePositions_Left(collection["JsonTextContent_Left"]);
                    //4-22-2020//objectMoveableDivs.SavePositions_Top(collection["JsonTextContent_Top"]);
                    
                    objectMoveableDivs.SavePositions_Left(collection["JsonTextContent_Left"], c_boolHasOffsets);
                    objectMoveableDivs.SavePositions_Top(collection["JsonTextContent_Top"], c_boolHasOffsets);
                    
                    objectMoveableDivs.SavePositions_Width(collection["JsonTextContent_Width"]);
                    objectMoveableDivs.SavePositions_Height(collection["JsonTextContent_Height"]);

                    //Added 4/16/2020 td
                    //
                    //  Transfer the positions to the element-fields stored in the cache. 
                    //
                    objectMoveableDivs.SavePositions_ToCache();

                    //Added 4/16/2020 td
                    //  We need to refresh the four(4) JSON-string properties. 
                    if (c_boolHasOffsets)
                    {
                        //Updathe the offset strings.   ---4/20/2020 thomas d. 
                        objectMoveableDivs.JSON_Offset_Left = collection["JsonTextContent_Left"];
                        objectMoveableDivs.JSON_Offset_Top = collection["JsonTextContent_Top"];
                    }
                    else
                    {
                        objectMoveableDivs.JSON_Left = collection["JsonTextContent_Left"];
                        objectMoveableDivs.JSON_Top = collection["JsonTextContent_Top"];
                    }

                    objectMoveableDivs.JSON_Width = collection["JsonTextContent_Width"];
                    objectMoveableDivs.JSON_Height = collection["JsonTextContent_Height"];

                    return View(objectMoveableDivs);

                }

                if (c_boolJsonFileObject)
                {
                    //Conditioned 4/16/2020 thomas downes 
                    if (c_boolHasOffsets)
                    {
                        //Updathe the offset strings.   ---4/20/2020 thomas d. 
                        JsonFile_MoveableDivs.JsonTextContent_Left = collection["JsonTextContent_Left"];
                        JsonFile_MoveableDivs.JsonTextContent_Top = collection["JsonTextContent_Top"];
                    }
                    else
                    {
                        JsonFile_MoveableDivs.JsonTextContent_Left = collection["JsonTextContent_Left"];
                        JsonFile_MoveableDivs.JsonTextContent_Top = collection["JsonTextContent_Top"];
                    }
                    //Added 3/30/2020 thomas downes
                    JsonFile_MoveableDivs.JsonTextContent_Width = collection["JsonTextContent_Width"];
                    JsonFile_MoveableDivs.JsonTextContent_Height = collection["JsonTextContent_Height"];

                    //
                    // Important.... save to disk. 
                    //
                    //----**---Not sure if this is needed right now.---- 3/22/2020 thomas d. 
                    //----*--
                    JsonFile_MoveableDivs.Save();

                    //return RedirectToAction("Index");
                    var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
                    return View(objectJsonFile);
                }

            }
            catch (Exception ex_Index)
            {
                //return View();
                var objContent = new ContentResult(); // "Unfortunately, the save failed." + ex_Index.Message);

                //Added 4/16/2020 thomas downes 
                objContent.Content = ("Unfortunately, the save failed." + ex_Index.Message);
                return objContent; 
            }
        }


        // POST: JsonFile/TableEdit/5
        [HttpPost]
        public ActionResult TableEdit(FormCollection collection) // Added 4/18/2020 thomas downes
        {
            try
            {
                // Save the JSON string with the Left & Top positions of the elements. 

                const bool c_boolJsonFileObject = false;
                const bool c_boolMoveableDivs = true;

                if (c_boolMoveableDivs)
                {
                    //
                    //Added 4/16/2020 thomas downes
                    //
                    var objectMoveableDivs = JsonFileController.MoveableDivs;

                    const bool c_bHasOffsets = true;  //Added 4/24/2020 thomas downes

                    objectMoveableDivs.SavePositions_Left(collection["JsonTextContent_Left"], c_bHasOffsets);
                    objectMoveableDivs.SavePositions_Top(collection["JsonTextContent_Top"], c_bHasOffsets);
                    objectMoveableDivs.SavePositions_Width(collection["JsonTextContent_Width"]);  //, c_bHasOffsets);
                    objectMoveableDivs.SavePositions_Height(collection["JsonTextContent_Height"]);  // , c_bHasOffsets);

                    //Added 4/16/2020 td
                    //
                    //  Transfer the positions to the element-fields stored in the cache. 
                    //
                    objectMoveableDivs.SavePositions_ToCache();

                    //Added 4/16/2020 td
                    //  We need to refresh the four(4) JSON-string properties. 
                    objectMoveableDivs.JSON_Left = collection["JsonTextContent_Left"];
                    objectMoveableDivs.JSON_Top = collection["JsonTextContent_Top"];
                    objectMoveableDivs.JSON_Width = collection["JsonTextContent_Width"];
                    objectMoveableDivs.JSON_Height = collection["JsonTextContent_Height"];

                    return View(objectMoveableDivs);

                }

                if (c_boolJsonFileObject)
                {
                    //Conditioned 4/16/2020 thomas downes 
                    JsonFile_MoveableDivs.JsonTextContent_Left = collection["JsonTextContent_Left"];
                    JsonFile_MoveableDivs.JsonTextContent_Top = collection["JsonTextContent_Top"];

                    //Added 3/30/2020 thomas downes
                    JsonFile_MoveableDivs.JsonTextContent_Width = collection["JsonTextContent_Width"];
                    JsonFile_MoveableDivs.JsonTextContent_Height = collection["JsonTextContent_Height"];

                    JsonFile_MoveableDivs.Save();

                    var objectJsonFile = JsonFileController.JsonFile_MoveableDivs;
                    return View(objectJsonFile);
                }

            }
            catch (Exception ex_Index)
            {
                //return View();
                var objContent = new ContentResult(); // "Unfortunately, the save failed." + ex_Index.Message);

                //Added 4/16/2020 thomas downes 
                objContent.Content = ("Unfortunately, the save failed." + ex_Index.Message);
                return objContent;
            }
        }


        // POST: JsonFile/TableDivsLeft/5
        [HttpPost]
        public ActionResult TableDivsLeft(FormCollection collection) // Added 4/19/2020 thomas downes
        {
            //
            //Added 4/16/2020 thomas downes
            //
            var objectMoveableDivs = JsonFileController.MoveableDivs;

            objectMoveableDivs.MoveLeft.EL1_Left =  collection["EL1_Left"];
            objectMoveableDivs.MoveLeft.EL2_Left =  collection["EL2_Left"];
            objectMoveableDivs.MoveLeft.EL3_Left =  collection["EL3_Left"];
            objectMoveableDivs.MoveLeft.EL4_Left =  collection["EL4_Left"];
            objectMoveableDivs.MoveLeft.EL5_Left =  collection["EL5_Left"];
            objectMoveableDivs.MoveLeft.EL6_Left =  collection["EL6_Left"];
            objectMoveableDivs.MoveLeft.EL7_Left =  collection["EL7_Left"];
            objectMoveableDivs.MoveLeft.EL8_Left =  collection["EL8_Left"];
            objectMoveableDivs.MoveLeft.EL9_Left =  collection["EL9_Left"];
            objectMoveableDivs.MoveLeft.EL10_Left = collection["EL10_Left"];
            objectMoveableDivs.MoveLeft.EL11_Left = collection["EL11_Left"];
            objectMoveableDivs.MoveLeft.EL12_Left = collection["EL12_Left"];

            //Added 4/16/2020 td
            //
            //  Transfer the positions to the element-fields stored in the cache. 
            //
            objectMoveableDivs.SavePositions_ToCache();

            //Added 4/22/2020 td
            objectMoveableDivs.JSON_Left = objectMoveableDivs.GetJSON_Left();

            //Added 4/16/2020 td
            //  We need to refresh the four(4) JSON-string properties. 
            //objectMoveableDivs.JSON_Left = collection["JsonTextContent_Left"];

            return View(objectMoveableDivs.MoveLeft);

        }


        // POST: JsonFile/TableDivsTop/5
        [HttpPost]
        public ActionResult TableDivsTop(FormCollection collection) // Added 4/19/2020 thomas downes
        {
            //
            //Added 4/16/2020 thomas downes
            //
            var objectMoveableDivs = JsonFileController.MoveableDivs;

            objectMoveableDivs.MoveTop.EL1_Top = collection["EL1_Top"];
            objectMoveableDivs.MoveTop.EL2_Top = collection["EL2_Top"];
            objectMoveableDivs.MoveTop.EL3_Top = collection["EL3_Top"];
            objectMoveableDivs.MoveTop.EL4_Top = collection["EL4_Top"];
            objectMoveableDivs.MoveTop.EL5_Top = collection["EL5_Top"];
            objectMoveableDivs.MoveTop.EL6_Top = collection["EL6_Top"];
            objectMoveableDivs.MoveTop.EL7_Top = collection["EL7_Top"];
            objectMoveableDivs.MoveTop.EL8_Top = collection["EL8_Top"];
            objectMoveableDivs.MoveTop.EL9_Top = collection["EL9_Top"];
            objectMoveableDivs.MoveTop.EL10_Top = collection["EL10_Top"];
            objectMoveableDivs.MoveTop.EL11_Top = collection["EL11_Top"];
            objectMoveableDivs.MoveTop.EL12_Top = collection["EL12_Top"];

            //Added 4/16/2020 td
            //
            //  Transfer the positions to the element-fields stored in the cache. 
            //
            objectMoveableDivs.SavePositions_ToCache();

            //Added 4/22/2020 td
            objectMoveableDivs.JSON_Top = objectMoveableDivs.GetJSON_Top();

            //Added 4/16/2020 td
            //  We need to refresh the four(4) JSON-string properties. 
            //objectMoveableDivs.JSON_Top = collection["JsonTextContent_Left"];

            return View(objectMoveableDivs.MoveTop);

        }


        // POST: JsonFile/TableDivsWidth/5
        [HttpPost]
        public ActionResult TableDivsWidth(FormCollection collection) // Added 8/22/2020 thomas downes
        {
            //
            //Added 8/22/2020 thomas downes
            //
            var objectMoveableDivs = JsonFileController.MoveableDivs;

            objectMoveableDivs.MoveWidth.EL1_Width = int.Parse(collection["EL1_Width"]);
            objectMoveableDivs.MoveWidth.EL2_Width = int.Parse(collection["EL2_Width"]);
            objectMoveableDivs.MoveWidth.EL3_Width = int.Parse(collection["EL3_Width"]);
            objectMoveableDivs.MoveWidth.EL4_Width = int.Parse(collection["EL4_Width"]);
            objectMoveableDivs.MoveWidth.EL5_Width = int.Parse(collection["EL5_Width"]);
            objectMoveableDivs.MoveWidth.EL6_Width = int.Parse(collection["EL6_Width"]);
            objectMoveableDivs.MoveWidth.EL7_Width = int.Parse(collection["EL7_Width"]);
            objectMoveableDivs.MoveWidth.EL8_Width = int.Parse(collection["EL8_Width"]);
            objectMoveableDivs.MoveWidth.EL9_Width = int.Parse(collection["EL9_Width"]);
            objectMoveableDivs.MoveWidth.EL10_Width = int.Parse(collection["EL10_Width"]);
            objectMoveableDivs.MoveWidth.EL11_Width = int.Parse(collection["EL11_Width"]);
            objectMoveableDivs.MoveWidth.EL12_Width = int.Parse(collection["EL12_Width"]);

            //Added 8/22/2020 td
            //
            //  Transfer the positions to the element-fields stored in the cache. 
            //
            objectMoveableDivs.SavePositions_ToCache();

            //Added 8/22/2020 td
            objectMoveableDivs.JSON_Width = objectMoveableDivs.GetJSON_Width();

            //Added 8/22/2020 td
            //  We need to refresh the four(4) JSON-string properties. 
            //   

            return View(objectMoveableDivs.MoveWidth);

        }


    }
}
