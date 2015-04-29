using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceFinder.BackEnd;

using PPG.AC.NA.SS.SSUtilities; //Add reference to PPG DLL PPG.AC.NA.SS.SSUtilities.DLL
    //Add reference to .NET Assempbly System.IO.Compression and System.IO.Compression.FileSystem

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Exporter
        {
            private string output_path;
            private int output_type;
            private Results results;
            private Settings settings;
            public Exporter() { }
            public Exporter(ref Settings sett, ref Results r)
            {
                settings = sett;
                results = r;
            }

            public string export()//call Settings accessor for output type
            {
                DateTime today = DateTime.Now;
                string export_path = "";
                output_path = settings.getOutputPath();
                output_type = settings.getOutputType();
                if (output_type == 0)//Separate PDFs
                {
                    foreach (Invoice inv in results)
                    {
                        if(inv.Export){
                            string output = output_path + "\\" + inv.File_name;
                            try
                            {
                                File.Copy(inv.Final_destination, output);
                            }
                            catch
                            {
                            }
                            export_path = output;
                        }
                    }
                }
                else if (output_type == 1)//Concatenated PDF
                {
                    PDFUtility _pdfUtility = new PDFUtility();

                    List<string> pdfFileNames = new List<string>();
                    foreach(Invoice inv in results){
                        if(inv.Export){
                            pdfFileNames.Add(inv.Final_destination);
                        }
                    }
                    try{
                        _pdfUtility.ConcatenateFiles(pdfFileNames.ToArray(), output_path + @"\" + today.ToString("Hmmss.MMddyyyy") + ".export.pdf"); //****add dynamic name to output file in settings
                    }
                    catch{
                        //popup error deu to corrupt files
                    }
                    export_path = output_path + @"\concatenated.pdf";
                }
                else//Zip folder
                {
                    //sourceDirectoryName : The path to the directory to be archived, specified as a relative or absolute path. 
                    //                      A relative path is interpreted as relative to the current working directory.

                    //destinationArchiveFileName: The path of the archive to be created, specified as a relative or absolute path. 
                    //                            A relative path is interpreted as relative to the current working directory.

                    string temp_folder_location = settings.getOutputPath() + @"\zip"; //*******chanegd to some folder local to where the program is being run
                    try{
                        Directory.CreateDirectory(temp_folder_location);
                    }
                    catch{
                    }
                    foreach (Invoice inv in results)
                    {
                        if(inv.Export){
                            string output = temp_folder_location + "\\" + inv.File_name;
                            try{
                                File.Copy(inv.Final_destination, output);
                            }
                            catch{
                            }
                        }
                    }
                    string destinationArchiveFileName = output_path + @"\" + today.ToString("Hmmss.MMddyyyy") + ".export.zip";//****add dynamic name to output file in settings
                    try{
                        ZipFile.CreateFromDirectory(temp_folder_location, destinationArchiveFileName);
                    }
                    catch{
                    }
                    try{
                        Directory.Delete(temp_folder_location, true);
                    }
                    catch{
                    }
                    export_path = destinationArchiveFileName;
                }
                return export_path;
            }
        }
    }
}