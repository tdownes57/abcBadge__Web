using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
//  https://www.aspsnippets.com/Articles/Convert-Image-file-to-Base64-Encoded-string-in-C-and-VBNet.aspx
//

namespace ciBadgeForWeb.Views.PortraitImage
{
    //
    //  https://www.aspsnippets.com/Articles/Convert-Image-file-to-Base64-Encoded-string-in-C-and-VBNet.aspx
    //
    public partial class UploadImageToBase64 : System.Web.UI.Page
    {
        //
        //  https://www.aspsnippets.com/Articles/Convert-Image-file-to-Base64-Encoded-string-in-C-and-VBNet.aspx
        //
        protected void Page_Load(object sender, EventArgs e)
        {
            //
            //  https://www.aspsnippets.com/Articles/Convert-Image-file-to-Base64-Encoded-string-in-C-and-VBNet.aspx
            //

        }

        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        protected void btnUpload_Click(object sender, EventArgs e)
            {
            //
            //  https://www.aspsnippets.com/Articles/Convert-Image-file-to-Base64-Encoded-string-in-C-and-VBNet.aspx
            //
            System.IO.Stream fs = FileUpload1.PostedFile.InputStream;
                System.IO.BinaryReader br = new System.IO.BinaryReader(fs);
                Byte[] bytes = br.ReadBytes((Int32)fs.Length);
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/png;base64," + base64String;
                Image1.Visible = true;
            }
        //}
    }
}