using ciPictures_VB;  //Added 6/15/2019 thomas d.   
using System;         //Added 11/18/2019 thomas d. 
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Drawing; //Added 11/25/2019 thomas d.
//using System.Web.Abstractions; //Added 11/25/2019 td 
using System.Web.Hosting;  //Added 11/25/2019 td  

namespace ciBadgeForWeb.Controllers
{
    //
    //Recipient = Student or Employee receiving the Badge. 
    //

    public class RecipientController : Controller
    {
        //
        //Currently active Personality-Configuration ID
        //
        public static int PersonalityConfigID_current = 1; //Added 7/12/2019 td 
        public static int RecipientID_current = 1; //Needed for the future Steps1234 controller.  ----Added 7/17/2019 td 

        //
        //Recipient = Student or Employee receiving the Badge. 
        //
        public static IList<Models.CIRecipient> mod_recipientList1 = new List<Models.CIRecipient>() {
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="1", FirstName="Johnny", LastName = "Davidson", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="2", FirstName="Stevie", LastName = "Austin", Picture = PictureExamples.GetExample() },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="3", FirstName="Billy", LastName = "Clinton", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="4", FirstName="Ronny", LastName = "Thegot", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="5", FirstName="Dorothy" , LastName = "Wood", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID ="6", FirstName="Christy", LastName = "Forbes", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=1, RecipientID = "7", FirstName="Tommy", LastName = "Forbes", Picture = PictureExamples.GetExample()   },

            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="1", FirstName="John", LastName = "Davidson", Picture = GetExample()  },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="2", FirstName="Steve", LastName = "Austin", Picture = GetExample()  },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="3", FirstName="Bill", LastName = "Clinton", Picture = GetExample()   },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="4", FirstName="Ram", LastName = "Thegot", Picture = GetExample()   },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="5", FirstName="Ron" , LastName = "Wood", Picture = GetExample()  },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID ="6", FirstName="Christopher", LastName = "Forbes", Picture = GetExample()   },
            //new Models.CIRecipient(){ CustomerID="XYZ999", Personality="Student", RecipientID = "7", FirstName="Robin", LastName = "Forbes", Picture = GetExample()   }

                            new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="1", FirstName="Jayce", LastName = "P.", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="2", FirstName="Chanin", LastName = "F.", Picture = PictureExamples.GetExample() },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="3", FirstName="Sammi", LastName = "F.", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="4", FirstName="Erick", LastName = "M.", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="5", FirstName="Erica" , LastName = "A.", Picture = PictureExamples.GetExample()  },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID ="6", FirstName="Jimmy", LastName = "A.", Picture = PictureExamples.GetExample()   },
                    new Models.CIRecipient(){ CustomerID="CIS100", idfConfigID=2, RecipientID = "7", FirstName="Thomas", LastName = "D.", Picture = PictureExamples.GetExample()   }
};

        //
        //Recipient = Student Or Employee receiving the Badge. 
        //
        //public static List<Models.CIRecipient> mod_recipientList = new List<Models.CIRecipient>() {
        public static IList<Models.CIRecipient> mod_recipientList2 = new List<Models.CIRecipient>() {
        new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "001", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("001")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "002", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "8TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("002") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "003", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "7TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("003")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "004", fstrFirstName = "Ronny", fstrLastName = "Thergeaux", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "6TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("004")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "005", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "5TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("005")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "006", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "4TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("006")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "007", fstrFirstName = "Tommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "3RD", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("007")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "008", fstrFirstName = "Susanny", fstrLastName = "Hunterson", TextField01 = "Woodbridge School", TextField02 = "Mr. Bernstein", TextField03 = "2ND", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("008")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "009", fstrFirstName = "Benny", fstrLastName = "Crawford", TextField01 = "Woodbridge School", TextField02 = "Ms. Ross", TextField03 = "1ST", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("009")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "010", fstrFirstName = "Tommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mrs. Denmore", TextField03 = "PRE-K", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,     Picture = GetImageByRecipID("010")  },
    
    /** 10 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "011", fstrFirstName = "Fritzy", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("011")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "012", fstrFirstName = "Hummy", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("012") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "013", fstrFirstName = "Sandy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("013")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "014", fstrFirstName = "Bobby", fstrLastName = "Therwood", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("014")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "015", fstrFirstName = "Dorothy" , fstrLastName = "Wiedson", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,    Picture = GetImageByRecipID("015")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "016", fstrFirstName = "Chrissy", fstrLastName = "Forbeson", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") ,   Picture = GetImageByRecipID("016")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "017", fstrFirstName = "Sammy", fstrLastName = "Farrowson", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("017")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "018", fstrFirstName = "Markie", fstrLastName = "Rolfberd", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("018")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "019", fstrFirstName = "Sandie", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("019")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "020", fstrFirstName = "Heather", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("020")  },
    
    /** 20 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "021", fstrFirstName = "Sonny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("021")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "022", fstrFirstName = "Steevy", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("022") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "023", fstrFirstName = "SAlly", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("023")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "024", fstrFirstName = "Robby", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("024")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "025", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("025")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "026", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("026")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "027", fstrFirstName = "Timmy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("027")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "028", fstrFirstName = "Tommy", fstrLastName = "Steward", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("028")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "029", fstrFirstName = "Tinny", fstrLastName = "Goodson", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("029")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "030", fstrFirstName = "Tubby", fstrLastName = "Winward", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("030")  },
    
    /** 30 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "031", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("031")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "032", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("032") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "033", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("033")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "034", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("034")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "035", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("035")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "036", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("036")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "037", fstrFirstName = "Dolly", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("037")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "038", fstrFirstName = "Denny", fstrLastName = "Morbeson", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("038")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "039", fstrFirstName = "Bully", fstrLastName = "Torres", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("039")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "040", fstrFirstName = "Vinnie", fstrLastName = "Bordeson", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("040")  },

    /** 40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            40 above            **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "041", fstrFirstName = "Johnny41", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("041")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "042", fstrFirstName = "Stevie42", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("042") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "043", fstrFirstName = "Billy43", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("043")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "044", fstrFirstName = "Ronny44", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("044")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "045", fstrFirstName = "Dorothy45" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("045")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "046", fstrFirstName = "Christy46", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("046")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "047", fstrFirstName = "Tommy47", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("047")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "048", fstrFirstName = "Sally48", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("048")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "049", fstrFirstName = "Volly49", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("049")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "050", fstrFirstName = "Hilly50", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("050")  },
    
    /** 50 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "051", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("051")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "052", fstrFirstName = "Stevie52", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("052") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "053", fstrFirstName = "Billy53", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("053")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "054", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("054")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "055", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("055")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "056", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("056")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "057", fstrFirstName = "Tommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("057")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "058", fstrFirstName = "Bommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("058")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "059", fstrFirstName = "Johnny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("059")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "060", fstrFirstName = "Jimmy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("060")  },
    
    /** 60 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "061", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("061")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "062", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("062") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "063", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("063")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "064", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("064")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "065", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("065")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "066", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("066")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "067", fstrFirstName = "Tommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("067")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "068", fstrFirstName = "Vommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("068")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "069", fstrFirstName = "Sonny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("069")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "070", fstrFirstName = "Winnie", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("070")  },
    
    /** 70 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "071", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("071")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "072", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("072") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "073", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("073")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "074", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("074")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "075", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("075")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "076", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("076")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "077", fstrFirstName = "Annie", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("077")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "078", fstrFirstName = "Tommy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("078")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "079", fstrFirstName = "Sonny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("079")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "080", fstrFirstName = "Honey", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("080")  },

    /** 80 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "081", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("081")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "082", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("082") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "083", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("083")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "084", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("084")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "085", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("085")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "086", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("086")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "087", fstrFirstName = "Hilde", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("087")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "088", fstrFirstName = "Timmy", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("088")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "089", fstrFirstName = "Georgie", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("089")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "090", fstrFirstName = "Ally", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("090")  },

    /** 90 above **/

    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "091", fstrFirstName = "Johnny", fstrLastName = "Davidson", TextField01 = "Willcrest School", TextField02 = "Ms. Robinson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("091")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "092", fstrFirstName = "Stevie", fstrLastName = "Austin", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("092") },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "093", fstrFirstName = "Billy", fstrLastName = "Clinton", TextField01 = "Willcrest School", TextField02 = "Ms. Tennyson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("093")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "094", fstrFirstName = "Ronny", fstrLastName = "Thegot", TextField01 = "Willcrest School", TextField02 = "Ms. Forbeson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("094")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "095", fstrFirstName = "Dorothy" , fstrLastName = "Wood", TextField01 = "Woodbridge School", TextField02 = "Mr. Beauchamp", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("095")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "096", fstrFirstName = "Christy", fstrLastName = "Forbes", TextField01 = "Willcrest School", TextField02 = "Mr. Shikovsky", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("096")   },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "097", fstrFirstName = "Yanny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("097")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "098", fstrFirstName = "Penny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("098")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "099", fstrFirstName = "Zenny", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020")   ,  Picture = GetImageByRecipID("099")  },
    new Models.CIRecipient() { CustomerID = "CIS100", idfConfigID = 1, fstrID = "100", fstrFirstName = "Queenie", fstrLastName = "Forbes", TextField01 = "Woodbridge School", TextField02 = "Mr. Wilson", TextField03 = "9TH", DateField01 = DateTime.Parse("7/21/2003"), DateField02 = DateTime.Parse("7/21/2020") , Picture = GetImageByRecipID("100")  },
        };

        // GET: Recipient
        public ActionResult Index()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Index");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            //Let's test it.  Does the List retain edits??? ----5/29/2019 td
            //mod_recipientList.FirstOrDefault().LastName += "P";

            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //     7-12-2019 td//return (ViewResult)View(mod_recipientList);
            // 11-18-2019 td//return (ViewResult)View(mod_recipientList.Where(s => s.idfConfigID == PersonalityConfigID_current));
            return (ViewResult)View(mod_recipientList2.Where(s => s.idfConfigID == PersonalityConfigID_current));
        }

        // GET: Recipient
        public ActionResult Index_Cfg1()
        {
            //
            //Added 7/12/2019 thomas downes
            //
            PersonalityConfigID_current = 1;  //Set Config #1 to be the Current Personality Config. 
            //return (ViewResult)View(mod_recipientList.Where(s => s.ConfigID == PersonalityConfigID_current));
            // 11-18-2019 td//return (ViewResult)View("Index", mod_recipientList.Where(s => s.idfConfigID == PersonalityConfigID_current));
            return (ViewResult)View("Index", mod_recipientList2.Where(s => s.idfConfigID == PersonalityConfigID_current));
        }

        // GET: Recipient
        public ActionResult Index_Cfg2()
        {
            //
            //Added 7/12/2019 thomas downes
            //
            PersonalityConfigID_current = 2;  //Set Config #1 to be the Current Personality Config. 
            //return (ViewResult)View(mod_recipientList.Where(s => s.ConfigID == PersonalityConfigID_current));
            return (ViewResult)View("Index", mod_recipientList2.Where(s => s.idfConfigID == PersonalityConfigID_current));
        }

        // GET: Recipient/Details/5
        public ActionResult Details(int parameter_id)
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Details");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // GET: Recipient/Create
        public ActionResult Create()
        {
            const bool c_boolSpecifyViewName = false;    //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!

            return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!
        }

        // Recipient/ShowSearchResults   (Doesn't directly match an HTTP command.)
        public ActionResult ShowSearchResults(IList<Models.CIRecipient> par_results) => View("Index", par_results);

        //const bool c_boolSpecifyViewName = false;    / /Added 5/28/2019 td
        //if (c_boolSpecifyViewName) return View("Create");  //A View, i.e. a webpage, is the most popular type of ActionResult !!
        //return (ViewResult)View();   //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!



        // POST: Recipient/Create
        [HttpPost]
        public ActionResult Create(Models.CIRecipient par_recip)     // (FormCollection collection)
        {
            try
            {
                // Added 6/5/2019 td
                //
                mod_recipientList2.Add(par_recip);


                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }

        // GET: Recipient/Edit/5
        public ActionResult Edit(string parameter_id) // (int? parameter_id)
        {
            //Added 7/9/2019 td
            //if (!(parameter_id.HasValue)) parameter_id = "001";  // = 5;
            if (parameter_id == null) parameter_id = "001"; 

            const bool c_boolSpecifyViewName = false; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Edit");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var id_doublecheck = Request.QueryString["parameter_id"];

            //Get the student from studentList sample collection for demo purpose.
            //Get the student from the database in the real application
            var recipients_by_id_list = mod_recipientList2.Where(s => s.RecipientID == parameter_id.ToString());
            var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();
            //return View(recipients_by_id);
            //return View("Index", recipients_by_id);
            return (ViewResult)View(recipient_by_id_onlyone);

        }

        // GET: Recipient/CardsPrintedLog/5
        public ActionResult CardsPrintedLog(int parameter_id)
        {
            const bool c_boolSpecifyViewName = false; //Added 5/28/2019 td
            if (c_boolSpecifyViewName) return View("Index", "TrackPrints");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            //return View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var id_doublecheck = Request.QueryString["parameter_id"];

            var printLog_by_id_list = TrackPrintsController.mod_trackPrintsLog.Where(s => s.RecipientID == parameter_id.ToString());
            return (ViewResult)View(printLog_by_id_list);

        }

        // POST: Recipient/Edit/5
        [HttpPost]
        public ActionResult Edit(int parameter_id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                //
                //Get the student from studentList sample collection for demo purpose.
                //Get the student from the database in the real application
                var edited_recip = mod_recipientList2.Where(s => s.RecipientID == parameter_id.ToString()).FirstOrDefault();

                var name_first = Request["FirstName"];
                var name_last = Request["LastName"];

                edited_recip.FirstName = name_first;  // std.FirstName + "_Revised";
                edited_recip.LastName = name_last;  //  std.LastName + "_Revised";

                UpdateModel(edited_recip, collection);

                //Index = "Nothing specified, go to the root page or action."  
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!
            }
        }

        // GET: Recipient/Delete/5
        public ActionResult Delete(int parameter_id)
        {
            //const bool c_boolSpecifyViewName = true; //Added 5/28/2019 td
            //if (c_boolSpecifyViewName) return View("Delete");  //A ViewResult, i.e. a webpage, is the most popular type of ActionResult !!

            var recipient_tobeDeleted = mod_recipientList2.Where(s => s.RecipientID == parameter_id.ToString()).FirstOrDefault();
            mod_recipientList2.Remove(recipient_tobeDeleted);

            //return View("Index");
            return RedirectToAction("Index");
        }

        // POST: Recipient/Delete/5
        [HttpPost]
        public ActionResult Delete(int parameter_id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                //Index = "Nothing specified, go to the root page or action."  
                //
                return RedirectToAction("Index");  //A Redirect is a less-common ActionResult.  ----5/24 td
            }
            catch
            {
                return (ViewResult)View();  //A ViewResult, i.e. a webpage,  is the most popular type of ActionResult !!  ----5/24 td
            }
        }




        public static IEnumerable<ciBadgeForWeb.Models.CIRecipient> GetRecipents_CurrentPC()
        {
            //
            //Added 7/12/2019 td 
            //
            //return mod_recipientList.Where(s => s.idfConfigID == RecipientController.PersonalityConfigID_current);
            return mod_recipientList2.Where(s => s.idfConfigID == RecipientController.PersonalityConfigID_current);

        }

        public static  IEnumerable<ciBadgeForWeb.Models.CIRecipient> GetStudents() 
        {
            //
            //Added 7/12/2019 td 
            //
            //return mod_recipientList.Where(s => s.idfConfigID == 1);
            return mod_recipientList2.Where(s => s.idfConfigID == 1);

        }

        public static IEnumerable<ciBadgeForWeb.Models.CIRecipient> GetStaff()
        {
            //
            //Added 7/12/2019 td 
            //
            //return mod_recipientList.Where(s => s.idfConfigID == 2);
            return mod_recipientList2.Where(s => s.idfConfigID == 2);

        }

        public static Image GetImageByRecipID(string pstrRecipientID)
        {
            //
            //Added 11/25/2019 td
            //
            //string strPathToFolder = "C:\\Users\\tdown\\source\\repos\\ciBadgeForWeb\\ciBadgeForWeb\\Images\\PictureExamples";
            string strVirtualPathToFolder = "~/Images/PictureExamples";

            //string strPathToFile = System.IO.Path.Combine(strPathToFolder, pstrRecipientID + ".jpg");
            string strVirtualPathToFile = (strVirtualPathToFolder + "/" + (pstrRecipientID + ".jpg"));

            try
            {
                //
                //https://forums.asp.net/t/1839913.aspx?Convert+Relative+Path+to+Absolute+Path
                //
                //string AbsolutePath = Server.MapPath(RelativePath);
                string strAbsolutePathToFile = HostingEnvironment.MapPath(strVirtualPathToFile);
                return (new Bitmap(strAbsolutePathToFile)); 
            }
            catch (Exception ex_GetImageByID) // As Exception
            {
                //''aDDED 11 / 21 / 2019 TD
                string strErrMessage = ex_GetImageByID.Message;
                return null;
            }
        }



    }
}
