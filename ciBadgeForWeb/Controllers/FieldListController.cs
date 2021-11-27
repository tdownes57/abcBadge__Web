using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ciBadgeElements;  //Added 11/13/2021 thomas downes  

//
//  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
//

namespace ciBadgeForWeb.Controllers //EditableListMvc.Controllers
{
    //
    //  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
    //

    public class FieldListController : Controller
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

        //private List<ciBadgeFields.ClassFieldAny> _par_fieldList;
        //---private List<ciBadgeFields.ClassFieldAny> _fieldList;
        private List<Models.Field> _fieldList;

        //---private List<ciBadgeFields.ClassFieldAny> FieldsList
        private List<Models.Field> FieldsList
        {
            get
            {
                if (_fieldList == null)
                //_fieldList = Session["FieldsList"] as List<ciBadgeFields.ClassFieldAny>;
                //  { _fieldList = FieldsController.GetFieldsList();  }
                { _fieldList = FieldsController.GetMvcFieldsListAny(); }

                return _fieldList;
            }
            set
            {
                _fieldList = value;
                Session["FieldsList"] = _fieldList;
            }
        }

        // GET: FieldsList
        public ActionResult Index()
        {
            //if (FieldsList == null)
            if (_fieldList == null)
            {
                // TODO: load real data from database
                //FieldsList = MockDb;
                //FieldsList = ciBadgeFields.ClassFieldStandard;
                //    _fieldList = ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();
                //_fieldList = ClassElementsCache_Deprecated.Singleton.ListOfFields_Any();

                //_fieldList = ClassElementsCache_Deprecated.Singleton.ListOfFields_CreateCopies();
                //----_fieldList = FieldsController.GetFieldsList();
                _fieldList = FieldsController.GetMvcFieldsListAny();

            }

            //Added 11/27/2021 td
            //  We don't want any Recipient values to appear on this
            //  page. 
            //
            ClassElementField.oRecipient = null;
            ClassElementField.iRecipientInfo = null;

            return View(_fieldList);
        }

        [HttpPost]
        public ActionResult Index(List<Models.Field> par_fieldList, string command)
        {
            //----public ActionResult Index(List<ciBadgeFields.ClassFieldAny> par_fieldList, string command)
            try
            {
                if (command == "Add Item")
                {
                    //--par_fieldList.Add(new ciBadgeFields.ClassFieldAny { PrimaryKey = -1 });
                    //--FieldsList = par_fieldList;
                }
                else if (command == "Remove Selected")
                {
                    int pos = par_fieldList.Count();
                    while (pos > 0)
                    {
                        pos--;
                        //if (par_fieldList[pos].Remove)
                        //    par_fieldList.RemoveAt(pos);
                    }
                    
                    //FieldsList = par_fieldList;
                    _fieldList = par_fieldList;
                
                }
                else if (command == "Cancel/Refresh")
                {
                    // force reload of data from database
                    //FieldsList = null;
                    _fieldList = null;

                }
                else
                {
                    //
                    // update actual database
                    //
                    //MockDb = par_fieldList;
                    //ClassElementsCache_Deprecated.Singleton.ListOfElementFields =
                    //ClassElementsCache_Deprecated.Singleton.ListOfFields_Any =
                    //    // (HashSet<ciBadgeFields.ClassFieldAny>)par_fieldList; ;
                    //    new HashSet<ciBadgeFields.ClassFieldAny>(par_fieldList);

                    //----ClassElementsCache_Deprecated.Singleton.LoadFields_FromList(par_fieldList);

                    // Modified 11/17/2021 thomas downes 
                    //var list_converted = Models.Field.ConvertListItems(par_fieldList);
                    //var list_converted = Models.Field.ConvertListItems_Deprecated(par_fieldList);
                    //ClassElementsCache_Deprecated.Singleton.LoadFields_FromList(list_converted);

                    var listFieldsStandard = new List<ciBadgeFields.ClassFieldStandard>();
                    var listFieldsCustom = new List<ciBadgeFields.ClassFieldCustomized>();

                    Models.Field.ConvertListItems(par_fieldList, 
                                            ref listFieldsStandard,
                                            ref listFieldsCustom);
                    ClassElementsCache_Deprecated.Singleton.LoadFields_FromList(listFieldsStandard, listFieldsCustom);

                    // force reload of data from database
                    //_fieldList = null;
                    FieldsController.RefreshMcvFieldsList();

                    //----_fieldList = FieldsController.GetFieldsList();
                    _fieldList = FieldsController.GetMvcFieldsListAny();

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