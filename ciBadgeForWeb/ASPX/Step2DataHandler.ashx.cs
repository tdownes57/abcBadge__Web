using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;         // Added 11/10/2021 thomas d. 
using System.Drawing;           // Added 11/10/2021 thomas d. 
using System.Drawing.Imaging;   // Added 11/20/2021 thomas d. 
using System.IO;        // Added 11/20/2021 thomas d. 
using ciLayoutPrintLib; // Added 11/20/2021 td
using ciBadgeElements;       //Added 11/20/2021 td

namespace ciBadgeForWeb.ASPX
{
    /// <summary>
    /// Summary description for Step2DataHandler
    /// </summary>
    public class Step2DataHandler : IHttpHandler
    {
        //
        // Added 11/10/2021 Thomas Downes 
        //
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");

            // Added 11/10/2021 Thomas Downes  
            List<string> listMessages = new List<string>();

            try
            {
                //Encapsulated 1/15/2020 td  
                ProcessRequest_noTryCatch(context,
                      listMessages);
            }
            catch (Exception ex)
            {
                //
                //Added 11/10/2021 td
                //
                //return ex.ToString();
                context.Response.ContentType = "text/html";
                //context.Response.Write($"<p> {ex.ToString()} </p>");
                context.Response.Write($"<p> {ex.Message} </p>");
                context.Response.Write($"<p> </p>");
                context.Response.Write($"<p> {ex.ToString()} </p>");

            }

        }



        private void ProcessRequest_noTryCatch(HttpContext par_context,
           List<string> par_listMessages)
        {
            //
            //Encapsulated 11-10-2021 td
            //
            int intElementIndex = -1;
            int intFieldIndex = -1;
            string strFieldCaption = ""; //Added 11/18/2021 td
            string strTextDisplayed = "";  //Added 11/18/2021 td

            //context.Response.Clear();
            //context.Response.ContentType = "text/html";
            //context.Response.Write("<p>No images were loaded, unfortunately.</p>");
            //return;

            bool bWeHave_ElementIndex = false; //Added 11/17/2021 
            bool bDisplayMessagesEtc = ("y" == par_context.Request.QueryString["msgs"]);
            bool bQueryByField = false; //Added 11/18/2021 td

            string strQueryKey0 = ""; // par_context.Request.QueryString.Keys[0];
            string strQueryKey1 = ""; // par_context.Request.QueryString.Keys[1];
            string strValue0 = ""; // par_context.Request.QueryString.Keys[0];
            string strValue1 = ""; // par_context.Request.QueryString.Keys[1];

            try
            {
                strQueryKey0 = par_context.Request.QueryString.Keys[0];
                strQueryKey1 = par_context.Request.QueryString.Keys[1];
                strValue0 = par_context.Request.QueryString.GetValues(0).ToString();
                strValue1 = par_context.Request.QueryString.GetValues(1).ToString();
            }
            catch { }

            if (!String.IsNullOrEmpty(par_context.Request.QueryString["elemindex"]))
            {
                //
                //Added 11/10/2021 thomas downes  
                //
                intElementIndex = int.Parse(par_context.Request.QueryString["elemindex"]);
                intFieldIndex = intElementIndex;  //Is this aspirational, or a fact? 
                bWeHave_ElementIndex = true;  //Added 11/17/2021 td
            }

            if (!String.IsNullOrEmpty(par_context.Request.QueryString["fldindex"]))
            {
                //
                //Added 11/17/2021 thomas downes  
                //
                // Example of call:
                //   < img src = "~/ASPX/Step2DataHandler.ashx?fldindex=@Model.FieldIndex
                //        &fldcaption=@Model.FieldLabelCaption" />
                //
                intFieldIndex = int.Parse(par_context.Request.QueryString["fldindex"]);
                strFieldCaption = (par_context.Request.QueryString["fldcaption"]).ToString();
                intElementIndex = ClassElementsCache_Deprecated.Singleton
                    .GetElementIndexByFieldIndex(intFieldIndex);
                bWeHave_ElementIndex = true;  //Added 11/17/2021 td
                bQueryByField = true;  
            }


            if (bWeHave_ElementIndex) 
            {
                //
                // We can proceed with image generation. 
                //
                var objImageGen = new ciBadgeGenerator.ClassMakeBadge();

                //= objImageGen.ElementFieldToImage(each_element, par_cache.BadgeLayout);

                var list_elements = 
                  ClassElementsCache_Deprecated.Singleton.ListOfElementFields
                  //--.Where(i => i.FieldInfo.FieldIndex == intElementIndex)
                  .Where(i => i.ElementIndexIsFieldIndex() == intElementIndex);

                var obj_element = list_elements.FirstOrDefault();
                var obj_badgeLayout = ClassElementsCache_Deprecated.Singleton.BadgeLayout;

                //Image output_dataImage = objImageGen.ElementFieldToImage(obj_element, obj_badgeLayout);
                string strBugMessage = "";
                Image output_dataImage = objImageGen.ElementFieldToImage(obj_element, 
                    obj_badgeLayout, ref strBugMessage, ref strTextDisplayed);

                // Added 11/18/2021 td 
                System.Diagnostics.Debug.Print($"Field index: {intFieldIndex} Field caption: {strFieldCaption} Text displayed: {strTextDisplayed}");

                // Added 11/18/2021 td 
                if (bQueryByField) Models.Field.Messages[intFieldIndex] = strBugMessage;
                else Models.MoveableDivImage.Messages[intFieldIndex] = strBugMessage;

                //
                //Display error messages, if any.  ----11/11/2021 td 
                //
                if (bDisplayMessagesEtc)
                {
                    par_context.Response.ContentType = "text/html";
                    par_context.Response.Write($"<p>-----Messages-------</p>");
                    par_context.Response.Write($"<p>{strBugMessage}</p>");
                }
                else
                {
                    par_context.Response.ContentType = "image/Jpeg";

                    //
                    // Create a memory-stream variable.
                    //
                    MemoryStream memstream_output = new MemoryStream();

                    //
                    // Load ("Save" to) the memory stream.
                    //
                    output_dataImage.Save(memstream_output, ImageFormat.Jpeg);

                    //
                    // Load the .Response property, via the memory stream. 
                    //
                    par_context.Response.BinaryWrite(memstream_output.GetBuffer());

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
    }
}