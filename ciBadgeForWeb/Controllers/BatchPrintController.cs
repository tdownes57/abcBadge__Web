using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeForWeb.Models; //Added 7/14/2019 Thomas DOWNES  
using ciPictures_VB;  //Added 9/12/2019 td  

namespace ciBadgeForWeb.Controllers
{
    //
    //Added 7-14-2019 Thomas DOWNES
    //

    public class BatchPrintController : Controller
    {
        //
        //BatchPrintController  
        //
        //    Ignoring for now the issue of the Preview Window that opens by Chrome, triggered 
        //    by a Control-P, can the Keyboard-Emulation of RFID-Enrollment cause a sequence of 
        //    badges to be displayed?    (The sequence corresponding to the Recipients who need
        //    a printed badge, one printed badge-card per Recipient.)  
        //
        //    -----7/14/2019 Thomas DOWNES   
        //
        public static int BP_RecipientID_Current = 0; //Initialize the sequence.   ---7/14/2019 td 

        // GET: BatchPrint
        public ActionResult Index()
        {
            //
            //Next recipient in the sequence.   
            //
            BP_RecipientID_Current += 1;

            //
            //Added 7-14-2019 Thomas DOWNES 
            //
            CIRecipient curr_recip = RecipientController.mod_recipientList2[BP_RecipientID_Current]; 
            return View(curr_recip);

        }

        // GET: BatchPrint/Next
        public ActionResult Next()
        {
            //return View();

            //
            //Next recipient in the sequence.   ----7/14/2019 td
            //
            return RedirectToAction("Index");

        }


    }
}
