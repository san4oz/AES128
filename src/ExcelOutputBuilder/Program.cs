using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelOutputBuilder.OutputFormatter;
using Microsoft.Office.Interop.Excel;

namespace ExcelOutputBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = null;

            try
            {
                app = new Application();

                var formatter = new FirstOutputFormatter();
                var formattedApp = formatter.CreateOutput(app);

                OpenApp(app);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(app);
            }
        }

        static void OpenApp(Application app)
        {
            app.Visible = true;
            app.UserControl = true;
        }
    }
}
