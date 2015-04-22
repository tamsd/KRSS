using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceFinder.BackEnd;

using PPG.AC.NA.SS.SSUtilities; //Add reference to PPG DLL PPG.AC.NA.SS.SSUtilities.DLL
using System.IO.Compression;    //Add reference to .NET Assempbly System.IO.Compression and System.IO.Compression.FileSystem

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Exporter
        {
            private string output_path;
            private int output_type;

            public Exporter() { }
            public Exporter(ref Settings settings)
            {
                output_path = settings.getOutputPath();
                output_type = settings.getOutputType();
            }

            public void export(List<Invoice> results)//call Settings accessor for output type
            {
                if (output_type == 0)//Separate PDFs
                {
                    //PDFUtility _pdfUtility = new PDFUtility();
                    //List<string> pdfFileNames = new List<string>();
                    //pdfFileNames.Add("C:\\Sample1.PDF");
                    //pdfFileNames.Add("C:\\Sample2.PDF");

                    for (int i = 0; i < results.Count; i++)
                    {
                        string output = output_path + results[i].File_name;
                        File.Copy(results[i].Final_destination, output);
                    }


                }
                else if (output_type == 1)//Concatenated PDF
                {
                    PDFUtility _pdfUtility = new PDFUtility();

                    List<string> pdfFileNames = new List<string>();

                    for (int i = 0; i < results.Count; i++)
                    {
                        pdfFileNames.Add(results[i].Final_destination);
                    }

                    _pdfUtility.ConcatenateFiles(pdfFileNames.ToArray(), output_path);
                }
                else//Zip folder
                {
                    //sourceDirectoryName : The path to the directory to be archived, specified as a relative or absolute path. 
                    //                      A relative path is interpreted as relative to the current working directory.

                    //destinationArchiveFileName: The path of the archive to be created, specified as a relative or absolute path. 
                    //                            A relative path is interpreted as relative to the current working directory.

                    string folder_location = output_path + "temp'\'";
                    Console.WriteLine(folder_location);
                    for (int i = 0; i < results.Count; i++)
                    {
                        string output = folder_location + results[i].File_name;
                        File.Copy(results[i].Final_destination, output);
                    }

                    string sourceDirectoryName = folder_location;
                    string destinationArchiveFileName = output_path + "output.zip";
                    ZipFile.CreateFromDirectory(sourceDirectoryName, destinationArchiveFileName);
                }
            }

        }
    }
}


