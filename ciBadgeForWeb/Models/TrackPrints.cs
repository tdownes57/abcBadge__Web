using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
//Added 7/9/2019 thomas downes
//

namespace ciBadgeForWeb.Models
{
    public class TrackPrints
    {
        //
        //Added 7/9/2019 thomas downes
        //
        public int TrackPrintsID { get; set; }

        public string RecipientID { get; set; }

        public string Operator { get; set; }

        public string WorkstationName { get; set; }

        public DateTime PrintDate { get; set; }

        public string RFID { get; set; }

        public string MagTrack1 { get; set; }
        public string MagTrack2 { get; set; }
        public string MagTrack3 { get; set; }

    }
}