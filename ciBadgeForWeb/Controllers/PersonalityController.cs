using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models;  //Added 7/11/2019 Thomas DOWNES

namespace ciBadgeForWeb.Controllers
{
    //
    // For [HandleError], please make sure that CustomError mode is on in System.web section of web.config,  
    //    in order for the Attribute [HandleError] (HandleErrorAttribute) work properly.
    //    https://www.tutorialsteacher.com/mvc/filters-in-asp.net-mvc
    //    -----3/7/2020 thomas d.
    //

    [HandleError]
    public class PersonalityController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        //
        //Added 7/10/2019 td
        //
        //
        //Recipient = Student or Employee receiving the Badge. 
        //
        public static IList<Models.Personality> mod_Personalities = new List<Models.Personality>() {
          new Models.Personality() { ConfigID = 11, ConfigNameBrief = "Students", ConfigNameFull = "Westmont High Students"  },
          new Models.Personality() { ConfigID = 12, ConfigNameBrief = "Staff", ConfigNameFull = "Westmont High Staff"   }
        };

        //Added 2/22/2020 thomas downes 
        public static Models.Personality CurrentPersonality;

        public static void SelectPersonality_ByConfigID(int par_intPersConfigID)
        {
            //Added 2/22/2020 thomas downes 
            CurrentPersonality = mod_Personalities
                .Where(x => (x.ConfigID == par_intPersConfigID)).FirstOrDefault();
        }


        public static void SelectPersonality_Initialize()
        {
            //Added 2/23/2020 thomas downes 
            if (CurrentPersonality == null)
            {
                CurrentPersonality = mod_Personalities.FirstOrDefault();
                RecipientController.PersonalityConfigID_current = CurrentPersonality.ConfigID;
            }
        }


        // GET: Personality
        public ActionResult Index()
        {
            return (ViewResult)View(mod_Personalities);
        }

        // GET: Personality/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personality/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personality/Edit/5
        public ActionResult Edit(int? id)
        {
            //Return View();

            //Added 7/9/2019 td
            if (!(id.HasValue)) id = 5;

            const bool c_boolSpecifyViewName = false; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var id_doublecheck = Request.QueryString["parameter_id"];

            //Get the Personality and open it for Viewing. 
            var personality_by_id = mod_Personalities.Where(s => s.ConfigID == id).FirstOrDefault();
            return (ViewResult)View(personality_by_id);

        }


        // GET: Personality/Select/5
        public ActionResult Select(int? id)
        {
            //Added 12/13/2019 thomas d
            //
            Controllers.RecipientController.PersonalityConfigID_current = (int)id;
            Controllers.PersonalityController.SelectPersonality_ByConfigID((int)id);  //Added 2/22/2020 td 
            return RedirectToAction("Index");

        }

        // GET: Personality/Fields
        public ActionResult Fields()
        {
            //
            //Added 1/19/2020 thomas d
            //
            //return View("Fields", "Index");
            //return RedirectToRoute("~/Fields");
            //return RedirectToRoute("Fields");

            return RedirectToRoute(new
            {
                controller = "Fields",
                action = "Index"
                //userId = user.Id,
                //applicantId = applicant.Id
            });

        }

        // POST: Personality/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // Added 7/11/2019 thomas downes
                //
                // 7/11 td//UpdateModel(mod_Personalities[id], collection);

                Personality editedConfig = mod_Personalities.Where(s => s.ConfigID == id).FirstOrDefault();

                UpdateModel(editedConfig, collection);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personality/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personality/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
