using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
//  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
//

namespace ciBadgeForWeb.Controllers //EditableListMvc.Controllers
{
    //
    //  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
    //

    public class FieldsListController : Controller
    {
        //
        //  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
        //
        // TODO: remove mock database
        //
        //private static List<ciBadgeFields.ClassFieldAny> MockDb = new List<ciBadgeFields.ClassFieldAny>
        //    {
        //        new ciBadgeFields.ClassFieldAny { PrimaryKey = 1, FirstName = "Fred", LastName="Than", Age=54 },
        //        new ciBadgeFields.ClassFieldAny { PrimaryKey = 2, FirstName = "Erin", LastName="Saavedra", Age=37 },
        //        new ciBadgeFields.ClassFieldAny { PrimaryKey = 4, FirstName = "Abdul", LastName = "Banas", Age = 12 }
        //    };

        //private List<ciBadgeFields.ClassFieldAny> _personList;
        private List<ciBadgeFields.ClassFieldAny> FieldsList
        {
            get
            {
                if (_personList == null)
                    _personList = Session["FieldsList"] as List<ciBadgeFields.ClassFieldAny>;
                return _personList;
            }
            set
            {
                _personList = value;
                Session["FieldsList"] = _personList;
            }
        }

        // GET: FieldsList
        public ActionResult Index()
        {
            if (FieldsList == null)
            {
                // TODO: load real data from database
                FieldsList = MockDb;
            }
            return View(FieldsList);
        }

        [HttpPost]
        public ActionResult Index(List<ciBadgeFields.ClassFieldAny> personList, string command)
        {
            try
            {
                if (command == "Add Item")
                {
                    personList.Add(new ciBadgeFields.ClassFieldAny { PrimaryKey = -1 });
                    FieldsList = personList;
                }
                else if (command == "Remove Selected")
                {
                    int pos = personList.Count();
                    while (pos > 0)
                    {
                        pos--;
                        if (personList[pos].Remove)
                            personList.RemoveAt(pos);
                    }
                    FieldsList = personList;
                }
                else if (command == "Cancel/Refresh")
                {
                    // force reload of data from database
                    FieldsList = null;
                }
                else
                {
                    // update actual database
                    MockDb = personList;
                    // force reload of data from database
                    FieldsList = null;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}