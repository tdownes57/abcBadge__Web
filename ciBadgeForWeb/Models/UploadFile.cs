using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //Added 5/28/2019 td
using System.ComponentModel.DataAnnotations; //Added 5/28/2019 td

namespace ciBadgeForWeb.Models
{
    public class UploadFile
    {
        [Display(Name = "Path To File")]
        public string PathToFile { get; set; }

        [Key]
        [Display(Name = "File Title")]
        public string FileTitle { get; set; }

        [Key]
        [Display(Name = "Disk Folder on Server")]
        public string DiskFolder { get; set; }

        [Display(Name = "Recipient ID")]
        public string RecipientID { get; set; }

        [Display(Name = "Personality ID")]
        public int PersonalityID  { get; set; }

    }
}