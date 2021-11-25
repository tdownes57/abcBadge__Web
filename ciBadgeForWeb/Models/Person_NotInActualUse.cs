// Goes in Models
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
//  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
//

namespace ciBadgeForWeb.Models // EditableListMvc.Models
{
    public class Person
    {
       //
       //  https://gist.github.com/rockfordlhotka/0474af9cf53cec9f2d359fa413d61e73
       //
        public int PrimaryKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool Remove { get; set; }
    }
}