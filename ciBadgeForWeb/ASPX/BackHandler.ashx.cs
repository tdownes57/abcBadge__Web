using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;               //Added 5/20/2019 thomas d. 
using System.Drawing;           //Added 5/20/2019 thomas d. 
using System.Drawing.Imaging;   //Added 5/20/2019 thomas d. 
using System.IO;                //Added 5/20/2019 thomas d.
using ciLayoutPrintLib;     //Added 10/5/2019 td

using ciBadgeElements;       //Added 10/5/2019 td  
using ciBadgeElemImage;     //Added 10/5/2019 td  
using ciBadgeGenerator; //Added 11/13/2019 td
using ciBadgeForWeb.Controllers; //Added 10/31/2021 thomas d. 
using System.Web.Mvc;               //Added 11/2/2021 thomas d. 

//
// public class "BackHandler"  
//
// In this coding project, the term "Back" (as in "BackHandler") always refers to "Background Image". 
//   ---10/31/2021 thomas downes
//
namespace ciBadgeForWeb
{
    //
    // public class "BackHandler"  
    //
    // In this coding project, the term "Back" always refers to "Background Image". 
    //   ---10/31/2021 thomas downes
    //
    /// <summary>
    /// Utilizes advanced layout programming from CILayoutDesigner by CI Solutions/Thomas Downes. 10/5/2019 td
    /// </summary>
    public class BackHandler : IHttpHandler
    {
        //
        // public class "BackHandler"  
        //
        // In this coding project, the term "Back" always refers to "Background Image". 
        //   ---10/31/2021 thomas downes
        //
        public void ProcessRequest(HttpContext context)
        {
            try
            {
                //Encapsulated 1/15/2020 td  
                ProcessRequest_noTryCatch(context);
            }
            catch (Exception ex)
            {
                //
                //Added 1/15/2020 td
                //
                //return ex.ToString();
                context.Response.ContentType = "text/html";
                //context.Response.Write($"<p> {ex.ToString()} </p>");
                context.Response.Write($"<p> {ex.Message} </p>");

            }
        }


        private void ProcessRequest_noTryCatch(HttpContext par_context)
        {
            //
            //Encapsulated 1-15-2020 td
            //
            //context.Response.Clear();
            //context.Response.ContentType = "text/html";
            //context.Response.Write("<p>No images were loaded, unfortunately.</p>");
            //return;

            //===-IList<Models.CIRecipient> recipients_list;

            bool bSizeLarge = false, bHorizontalLarge = false, bHorizontalSmall = false; //Added 6/20/2019 thomas downes 
            bool bNoImagesAvailable = false;  //Added 11/1/2021 thomas downes
            bool bExceptionThrown = false;   //Added 11/1/2021 thomas downes

            par_context.Response.Clear();

            //Added 6/20/2019 td
            //
            if (!String.IsNullOrEmpty(par_context.Request.QueryString["big"])) // ....["size"]))
            {
                //Added 6/20/2019 td
                if (!String.IsNullOrEmpty(par_context.Request.QueryString["hor"]))
                {
                    //Adde d 6/20/2019 td
                    bSizeLarge = ("y" == par_context.Request.QueryString["big"]);  // ["size"]);
                    bHorizontalLarge = (bSizeLarge && ("y" == par_context.Request.QueryString["hor"]));
                    bHorizontalSmall = (!(bSizeLarge) && ("y" == par_context.Request.QueryString["hor"]));
                }
            }

            //Added 10/31/2021 thomas downes 
            bool boolIsAnIDValueSupplied = true; 
            //        (!String.IsNullOrEmpty(par_context.Request.QueryString["id"])) 
            //     || (!String.IsNullOrEmpty(par_context.Request.QueryString["backid"]));
            bool bIsAnIDValueSupplied_just_id =
                    (!String.IsNullOrEmpty(par_context.Request.QueryString["id"]));
            bool bIsAnIDValueSupplied_back_id =
                    (!String.IsNullOrEmpty(par_context.Request.QueryString["backid"]));

            int intBackgroundImageIndex = -1;
            string strQueryField = ""; 
            if (bIsAnIDValueSupplied_back_id)
            {
                strQueryField = "backid";
                //intBackgroundImageIndex = int.Parse(par_context.Request.QueryString["backid"]);
            }
            else if (bIsAnIDValueSupplied_just_id)
            {
                strQueryField = "id";
                //intBackgroundImageIndex = int.Parse(par_context.Request.QueryString["id"]);
            }
            else
            {
                boolIsAnIDValueSupplied = false;
                par_context.Response.ContentType = "text/html";
                par_context.Response.Write("<p>No ID value was supplied, unfortunately.</p>");
                return;
            }

            // Pull the ID value, either preceded by "id=" or "backid=". 
            intBackgroundImageIndex = int.Parse(par_context.Request.QueryString[strQueryField]);
             
            //---if (!String.IsNullOrEmpty(par_context.Request.QueryString["id"]))
            if (boolIsAnIDValueSupplied)
            {
                int intPixelsWidth = 0;
                int intPixelsHeight = 0;
                bool boolHeightSpecified = false; // Added 11/4/2021 td

                // Added 11/4/2021 td
                boolHeightSpecified = !String.IsNullOrEmpty(par_context.Request.QueryString["height"]);

                //
                // Check the desired displayed width of the background image.  
                //
                try
                {
                    if (boolHeightSpecified)
                    {
                        // Added 11/4/2021 td 
                        intPixelsHeight = int.Parse(par_context.Request.QueryString["height"]);
                        intPixelsWidth = (int)(intPixelsHeight *
                            ClassProportions.LongSideToShortRatio());
                    }
                    else
                    {
                        // Originally (pre-11/4/2021), only Width was specified.
                        //    (Height was not specified.)  ---11/4/2021 td
                        intPixelsWidth = int.Parse(par_context.Request.QueryString["width"]);
                        intPixelsHeight = (int)(intPixelsWidth /
                            ClassProportions.LongSideToShortRatio());
                    }
                }
                catch
                {
                    //Just try .......
                    //    If it's missing we should assume that a print-ready badge is being prepared. 
                    //   ------10/5/2019 td
                    bExceptionThrown = true;
                    par_context.Response.ContentType = "text/html";
                    par_context.Response.Write("<p>The width of the background image is undetermined.</p>");
                    return;
                }

                //
                // Major function!!
                //
                //Encapsulated 11/1/2021
                //
                Image image_background_output = null;
                const bool c_allowDoublewidths = true;  // Added 11/4/2021 td

                try
                {
                    //
                    //Encapsulated 11/1/2021
                    //
                    image_background_output = GetBackImage_ByIndexAndWidth(par_context,
                        intBackgroundImageIndex, intPixelsWidth, intPixelsHeight,
                        ref bNoImagesAvailable,
                        c_allowDoublewidths);
                }
                catch (Exception ex_get_image)
                {
                    //Added 11/1/2021 td
                    par_context.Response.ContentType = "text/html";
                    par_context.Response.Write($"<p> {ex_get_image.Message} </p>");
                    return;
                }

                //if (boolPlainBackgroundImage)
                //{
                //    //Added 6/28/2019 thomas downes  
                //    image_ex = objLayoutEx.GenerateImage_BackgroundOnly(bHorizontalLarge, bHorizontalSmall);
                //}

                // Of course set this to whatever your format is of the image
                //context.Response.ContentType = "image/png";
                par_context.Response.ContentType = "image/Jpeg";

                //Save the image to the OutputStream
                MemoryStream obj_ms_output = new MemoryStream();
                image_background_output.Save(obj_ms_output, ImageFormat.Jpeg);
                par_context.Response.BinaryWrite(obj_ms_output.GetBuffer());
                return;

            }
            else
            {
                par_context.Response.ContentType = "text/html";
                par_context.Response.Write("<p>Need a valid id</p>");
            }

        }


        private Image GetBackImage_ByIndexAndWidth(HttpContext par_context,
            int par_intBackgroundImageIndex, 
            int par_intBackWidth_Pixels,
            int par_intBackHeight_Pixels, 
            ref bool pref_bNoImagesAvailable,
            bool pbAllowDoublewidthsIfDoublesided)
        {
            //
            // Encapsulated 11/1/2021 td
            //
            //
            //Added 6/20/2019 thomas downes  
            //
            Image image_exampleBackgroundOnly = null;  // = recipient_by_id_onlyone.Picture;
            Image image_background_output = null;   // Added 9/17/2021 thomas downes

            //
            // objLayoutExample 
            //
            LayoutExample objLayoutExample = new ciLayoutPrintLib.LayoutExample();

            //+++bool boolPlainBackgroundImage;//Added 6/28/2019 thomas downes 
            //+++boolPlainBackgroundImage = ("back" == par_context.Request.QueryString["id"]);
            //===bool boolNoImagesAreAvailable = false; //added 7/6/2019 td

            //----int intPixelsWidth = 0; //Added 7/06/2019 thomas downes 
            //----int intPixelsHeight = 0; //Added 11/14/2019 thomas downes
            //----bool bExceptionThrown = false;  //Added 10/30/2021 thomas downes 


            //+++if (boolPlainBackgroundImage)
            const bool c_boolPlainBackgroundImage = true;  // True, since we are only showing
                                                           //   background images through this 
                                                           //   handler. ---10/31/2021 td 
            if (c_boolPlainBackgroundImage)
            {
                //
                //Plain Background Image 
                //
                //----objLayoutExample.WidthInPixels_Land = intPixelsWidth;
                objLayoutExample.WidthInPixels_Land = par_intBackWidth_Pixels; // intPixelsWidth;

                if (-1 != par_intBackgroundImageIndex)
                {
                    const bool c_boolToggleImage = false;  // Added 3/9/2020 thoams
                    if (c_boolToggleImage)
                        ciLayoutPrintLib.LayoutExample
                            .RefreshChoiceOfBackground_ByIndex(par_intBackgroundImageIndex);
                }

                //Added 4/9/2020 td
                LayoutExample.PathToFolderWithBacks = ciBadgeForWeb.App_Start.DiskFolders
                    .PathToFolderWithBacks(true);

                //image_exampleBackgroundOnly = objLayoutExample
                //    .GenerateImage_BackgroundOnly(bHorizontalLarge,
                //         bHorizontalSmall, ref boolNoImagesAreAvailable);

                // Added 3/9/2020 thomas downes
                //
                //    It's important that the correct background image be displayed.
                //
                ciBadgeInterfaces.BadgeLayoutClass objLayout_B;   // Added 3/9/2020 thomas downes 
                objLayout_B = ciBadgeElements.ClassElementsCache_Deprecated.Singleton.BadgeLayout;
                string strPathToBackImages_B = ciBadgeForWeb.App_Start.DiskFolders.PathToFolderWithBacks(true);
                
                // Deprecated 11/1/2021 thomas downes
                int intBackWidth_B_deprecated = objLayout_B.Width_Pixels;
                int intBackHeight_B_deprecated = objLayout_B.Height_Pixels;

                // Added 10/31/2021 Thomas Downes
                var backgrounds_by_id_list = BackgroundController.mod_backgrounds
                    .Where(s => s.Index == par_intBackgroundImageIndex);
                var background_by_id_onlyone = backgrounds_by_id_list.FirstOrDefault();
                string strFileTitle = background_by_id_onlyone.FileName;

                const bool c_boolUseLocalFun = true;

                if (c_boolUseLocalFun)
                {
                    // Added 11/2/2021 thomas downes
                    //   Let's use a new local function for pulling the 
                    //   image object from the disk-IO system. 
                    image_background_output = GetBackgroundImage(par_intBackWidth_Pixels,
                          par_intBackHeight_Pixels,
                          strPathToBackImages_B, strFileTitle,
                          pbAllowDoublewidthsIfDoublesided);
                }
                else
                {
                    // Added 11/2/2021 thomas downes
                    bool bTwoPropertiesRefreshed = false; // We haven't refreshed the 2 properties. --11/2/2021 
                    ClassElementsCache_Deprecated.Singleton.BackgroundImage_FTitle = strFileTitle;
                    ClassElementsCache_Deprecated.Singleton.BackgroundImage_Path =
                           System.IO.Path.Combine(strPathToBackImages_B, strFileTitle);  // ==========
                    bTwoPropertiesRefreshed = true; // We just refreshed the 2 properties. --11/2/2021 

                    // Added 10/30/2021 Thomas Downes
                    //image_badge_output = image_badge_exampleBackgroundOnly;
                    //22image_background_output = ClassElementsCache_Deprecated.Singleton
                    //22    .GetBackgroundImage(intBackWidth_B, intBackHeight_B,
                    //22       strPathToBackImages_B);
                    image_background_output = ClassElementsCache_Deprecated.Singleton
                        .GetBackgroundImage(par_intBackWidth_Pixels, par_intBackHeight_Pixels,
                           strPathToBackImages_B, bTwoPropertiesRefreshed);
                }

                return image_background_output;  

            }

        }


        private Image GetBackgroundImage(int pintWidth, int pintHeight,
                                          string pstrPathToLikelyFolder,
                                          string pstrFileTitle,
                                          bool pbAllowDoublewidthsIfTwoSided)
        {
            //
            // Added 11/2/2021 thomas d. 
            //
            string strFullPathToImageFile = System.IO.Path.Combine(pstrPathToLikelyFolder, pstrFileTitle);

            // Added 11/2/2021 td
            //    
            //  Good page:   https://stackoverflow.com/questions/28330257/get-relative-url-in-asp-net-mvc-view
            //  Even better: https://weblog.west-wind.com/posts/2007/Sep/18/ResolveUrl-without-Page
            //      
            strFullPathToImageFile = App_Start.DiskFilesCS.ResolveUrl(strFullPathToImageFile);

            //Graphics g = new Graphics
            Image imageCreated1 = new Bitmap(strFullPathToImageFile);

            //Added 11/3/2021 thomas downes
            bool boolLikelyDoubleSided = ClassProportions.BackgroundIsDoubleSided(imageCreated1);
            //---int intWidth_MaybeDoubleSided = (boolLikelyDoubleSided ? (pintWidth * 2) : pintWidth);
            bool boolDoubleTheWidth = (boolLikelyDoubleSided && pbAllowDoublewidthsIfTwoSided);
            int intWidth_MaybeDoubleSided = (boolDoubleTheWidth ? (pintWidth * 2) : pintWidth);

            //''imageCreated.Dispose()
            Image imageCreated2 = new Bitmap(imageCreated1, new Size(intWidth_MaybeDoubleSided, pintHeight));
            //mod_dictionaryBackImages.Add(structCurrent, imageCreated2)
            imageCreated1.Dispose();
            return imageCreated2;

        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}

