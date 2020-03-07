using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//   I think maybe I will put this into the ABC IDCard_Core solution,
//   rather than having this in the ciBadgeForWeb solution.
//    -----2/11/2020 thomas downes
//

namespace ABC IDCardService
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //
            //   I think maybe I will put this into the ABC IDCard_Core solution,
            //   rather than having this in the ciBadgeForWeb solution.
            //    -----2/11/2020 thomas downes
            //

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
