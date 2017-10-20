using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process();
        }

        static void Process()
        {
            string strPath;
            DCDK.Results.DocConverterResult results;

            //strPath = System.AppDomain.CurrentDomain.BaseDirectory;
            strPath = "c:\\data\\";

            // Instantiate Object
            APDocConverter.DocConverter oDC = new APDocConverter.DocConverter();

            // Set the amount of time before a request will time out
            oDC.TimeoutSpan = new TimeSpan(0, 0, 40);

            // Enable extra logging (logging should only be used while troubleshooting)
            // C:\ProgramData\activePDF\Logs\
            
            oDC.Debug = true;

            // Settings specific to other formats created with from PDF conversions
            // via Solid Documents SDK are set using the FromPDFOptions object
            APDocConverter.FromPDFOptions fPDF = new APDocConverter.FromPDFOptions();

            // To Word options
            fPDF.ToWordHeadersAndFootersMode = APDocConverter.ToWordHeadersAndFootersOptions.Detect;

            // To Excel options
            fPDF.ToExcelAutoDetectSeparators = true;
            fPDF.ToExcelTablesFromContent = APDocConverter.ToExcelTablesFromContentOptions.Default;

            // To Image options
            fPDF.ToImagePageDPI = 300;

            // Confirm the from PDF settings for conversion via Solid Documents SDK
            oDC.SetFromPDFOptions(fPDF);
            fPDF = null;

            // Convert the document from PDF to another format using Solid Documents SDK
            // The second parameter determines the output file format
            results = oDC.ConvertFromPDF(strPath + "{ZHC4_Final_4c791b2e-25ab-4666-af0f-55f838f02554}.pdf", APDocConverter.FromPDFFunction.ToImageMultiPageTIFF, strPath + "ZHealth_ConvertedToTiff.tif");
            if (results.DocConverterStatus != DCDK.Results.DocConverterStatus.Success)
            {
                ErrorHandler("ConvertFromPDF", results, results.DocConverterStatus.ToString());
            }

            // Release Object
            oDC = null;

            // Process Complete
            WriteResults("Done!");
        }

        public static void ErrorHandler(string strMethod, ADK.Results.Result results, string errorStatus)
        {
            WriteResults("Error with " + strMethod);
            WriteResults(errorStatus);
            WriteResults(results.Details);
            if (results.Origin.Function != strMethod)
            {
                WriteResults(results.Origin.Class + "." + results.Origin.Function);
            }
            if (results.ResultException != null)
            {
                // To view the stack trace on an exception uncomment the line below
                WriteResults(results.ResultException.StackTrace);
            }
            Environment.Exit(1);
        }

        // Write output data
        public static void WriteResults(string content)
        {
            // Choose where to write out results

            // Debug output
            System.Diagnostics.Debug.WriteLine("ActivePDF: * " + content);

            // Console
            Console.WriteLine(content);

            //Log file
            using (System.IO.TextWriter writer = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + "application.log", true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "]: => " + content);
            }
        }
    }
}
