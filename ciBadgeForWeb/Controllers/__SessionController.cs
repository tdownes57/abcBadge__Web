using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//
//  Added 11/13/2021 Thomas c. downes
//   http://tutorials.jenkov.com/java-servlets/httpsession.html
//
namespace ciBadgeForWeb.Controllers
{
    //
    //   http://tutorials.jenkov.com/java-servlets/httpsession.html
    //
    //  Added 11/13/2021 Thomas c. downes
    //
    //    The HttpSession object represents a user session.A user session contains information about the user across multiple HTTP requests.

    //When a user enters your site for the first time, the user is given a unique ID to identify his session by.This ID is typically stored in a cookie or in a request parameter.

    //Here is how you access the session object:

    //protected void doPost(HttpServletRequest request,
    //    HttpServletResponse response)
    //        throws ServletException, IOException {

    //    HttpSession session = request.getSession();
    //}
    //
    //You can store values in the session object, and retrieve them later. First, let's see how you can store values in the session object:
    //
    //session.setAttribute("userName", "theUserName");
    //This code sets an attribute named "userName", with the value "theUserName".
    //
    //To read the value again, you do this:
    //
    //String userName = (String)session.getAttribute("userName");
    //Values stored in the session object are stored in the memory of the servlet container.
    //
    //   http://tutorials.jenkov.com/java-servlets/httpsession.html
    //

    public class __SessionController : Controller
    {
        // GET: __Session
        public ActionResult Index()
        {
            return View();
        }
    }
}