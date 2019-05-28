using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ciBadgeForWeb.Views.Home
{
    public partial class ExampleBadge : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            // https://stackoverflow.com/questions/21877/dynamically-rendering-aspimage-from-blob-entry-in-asp-net
            //
            //imageBadge.ImageUrl = "imageHandler.ashx";

            imageBadge.ImageUrl = "~/ImageHandler.ashx?ID=myImageId";


        }
    }
}