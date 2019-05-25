using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;// Added 5/20/2019 thomas d. 
using System.Drawing; // Added 5/20/2019 thomas d. 
using System.Drawing.Imaging;// Added 5/20/2019 thomas d. 
using System.IO;// Added 5/20/2019 thomas d. 

namespace ciBadgeForWeb
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            context.Response.Clear();
            if (!String.IsNullOrEmpty(context.Request.QueryString["id"]))
            {
                int id = Int32.Parse(context.Request.QueryString["id"]);
                // Now you have the id, do what you want with it, to get the right image
                // More than likely, just pass it to the method, that builds the image
                Image image = GetImage(id);
                // Of course set this to whatever your format is of the image
                context.Response.ContentType = "image/jpeg";
                // Save the image to the OutputStream
                image.Save(context.Response.OutputStream, ImageFormat.Jpeg);
            }
            else
            {
                context.Response.ContentType = "text/html";
                context.Response.Write("<p>Need a valid id</p>");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private Image GetImage(string customer_id, int config_id, string recipient_id)
        {
            //
            //Recipient = Student or Employee receiving the Badge. 
            //
            var newImage = new Bitmap(800, 250);
            System.Drawing.Graphics g = Graphics.FromImage(newImage);
            g.FillRectangle(Brushes.White, 0, 0, newImage.Width, newImage.Height);
            Rectangle Box = new Rectangle(10, 10, newImage.Size.Width - 20, newImage.Size.Height - 20);
            g.DrawRectangle(Pens.Black, Box);
            //My drawing code
            return newImage;
        }

        private Image GetImage(int id)
        {
            var newImage = new Bitmap(800, 250);
            System.Drawing.Graphics g = Graphics.FromImage(newImage);
            g.FillRectangle(Brushes.White, 0, 0, newImage.Width, newImage.Height);
            Rectangle Box = new Rectangle(10, 10, newImage.Size.Width - 20, newImage.Size.Height - 20);
            g.DrawRectangle(Pens.Black, Box);
            //My drawing code
            return newImage;
        }

    }
}