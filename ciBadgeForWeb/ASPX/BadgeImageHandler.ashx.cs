using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;  // Added 10/1/2021 Thomas Downes
using System.Web;         // Added 10/1/2021 thomas d. 
using System.Drawing.Imaging;   // Added 5/20/2019 thomas d. 
using System.IO;        // Added 5/20/2019 thomas d. 
using ciLayoutPrintLib; // Added 7/13/2019 td

namespace ciBadgeForWeb.ASPX
{
    /// <summary>
    /// BadgeImageHandler provides the image of the created & saved badge, for the selected recipient. 
    /// </summary>
    public class BadgeImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            IList<Models.CIRecipient> recipients_list;
            bool boolApplyWidth = false;  //Added 7/13/2019 td  

            string strContextRequestQuery = context.Request.QueryString.ToString();
            var queryID_ofRecip = context.Request.QueryString["id"];

            //Added 7/06/2019 thomas downes
            int intPixelsWidth = 0; //Added 7/06/2019 thomas downes 
            try
            {
                //Added 7/06/2019 thomas downes
                intPixelsWidth = int.Parse(context.Request.QueryString["width"]);
                boolApplyWidth = (20 < intPixelsWidth);
            }
            catch (Exception ex)
            {
                //Just try .......
                string strMessage = ex.Message;
                strMessage = ex.Message;
            }

            context.Response.Clear();

            if (!String.IsNullOrEmpty(queryID_ofRecip))
            {
          
                    Image imageNoPic = ciPictures_VB.PictureExamples.GetImageWithNoPicture();

                    //Added 7/13/2019
                    //
                    if (boolApplyWidth)
                    {
                        //Added 7/13/2019
                        imageNoPic = LayoutPrint.ResizeImage_ToWidth(imageNoPic, intPixelsWidth);
                    }

                    context.Response.ContentType = "image/Jpeg";
                    MemoryStream msNoPic = new MemoryStream();

                    if (imageNoPic != null)
                    {
                        imageNoPic.Save(msNoPic, ImageFormat.Jpeg);
                        context.Response.BinaryWrite(msNoPic.GetBuffer());
                    } //End of "if (imageNoPic != null)"

                    return;

                } //End of "if (boolImageNoPicture)"

                recipients_list = Controllers.RecipientController.mod_recipientList2;

                var recipients_by_id_list = recipients_list.Where(s => s.RecipientID == queryID_ofRecip);

                var recipient_by_id_onlyone = recipients_by_id_list.FirstOrDefault();

                if (recipient_by_id_onlyone is null) return;

                Image imageBadge = recipient_by_id_onlyone.BadgeImage;

                if (boolApplyWidth)
                {
                    imageBadge = LayoutPrint.ResizeImage_ToWidth(imageBadge, intPixelsWidth);
                }

                context.Response.ContentType = "image/Jpeg";

                MemoryStream msBadgeImage = new MemoryStream();

                if (imageBadge != null)
                {
                    try //Added 11/13/2019 td
                    {
                        imageBadge.Save(msBadgeImage, ImageFormat.Jpeg);
                        context.Response.BinaryWrite(msBadgeImage.GetBuffer());
                    }
                    catch (Exception ex_memorystream)
                    {
                        string strErrorMsg = ex_memorystream.Message; //Added 11/13/2019 td
                        System.Drawing.Image imagePic_clone = (System.Drawing.Image)imageBadge.Clone();
                        imagePic_clone.Save(msBadgeImage, ImageFormat.Jpeg);
                        context.Response.BinaryWrite(msBadgeImage.GetBuffer());
                    }
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
            g.FillRectangle(Brushes.MediumOrchid, 0, 0, newImage.Width, newImage.Height);
            Rectangle Box = new Rectangle(10, 10, newImage.Size.Width - 20, newImage.Size.Height - 20);
            g.DrawRectangle(Pens.OrangeRed, Box);
            //My drawing code
            return newImage;
        }

    }
}