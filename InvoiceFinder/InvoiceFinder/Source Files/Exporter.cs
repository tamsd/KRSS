/*
 * Author(s):
 * Date:
 * Description:
*/
using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceFinder.BackEnd;
using PPG.AC.NA.SS.SSUtilities;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        public class Exporter
        {
            private string output_path; //stores path to a directory where export() will send file(s) to
            private int output_type;    //stores the type of export 0=list, 1=conc pdf, 2=zip
            private Results results;    //intialized to the results passed to exporter
            private Settings settings;  //used to set output_path and output_type
            public Exporter() { }       //empty default constructor
            public Exporter(ref Settings sett, ref Results r)
            {
                settings = sett;
                results = r;
            }   //2 argument constructor

            /* export() Function is called when user triggers event to export files stored in results. Return export path or "" if nothing exported*/
            public string export(){
                int count_exports = 0;          //used to track if any found invoices have been exported
                DateTime today = DateTime.Now;  //used for timestamp on conc pdf and zip file name
                string export_path = "";        //returned by function so that caller can open directory where export was saved

                //update output path
                output_path = settings.getOutputPath();
                //update export type
                output_type = settings.getOutputType();

                if (output_type == 0) { //Separate PDFs List
                    foreach (Invoice inv in results){ //iterate through results checking if invoice needs to be exported
                        if(inv.Export == true){
                            count_exports++;
                            string output = output_path + "\\" + inv.File_name;
                            try{
                                File.Copy(inv.Final_destination, output);
                            }
                            catch{
                                //error copying 
                            }
                            export_path = output; //set export_path to last copied file
                        }
                    }
                }
                else if (output_type == 1){ //Concatenated PDF
                    PDFUtility _pdfUtility = new PDFUtility();      //intialize pdf utility
                    List<string> file_paths = new List<string>();   //List stores the full paths to files that need to be concatnated
                    
                    foreach(Invoice inv in results){ //iterate through results checking if invoice needs to be exported
                        if(inv.Export == true){
                            count_exports++;
                            file_paths.Add(inv.Final_destination);
                        }
                    }
                    if(count_exports > 0){ //check if anything was exported, as to not make empty pdf
                        export_path = output_path + @"\" + today.ToString("Hmmss.MMddyyyy") + ".export.pdf"; //timestamp export filename and generate path to export
                        try{
                            _pdfUtility.ConcatenateFiles(file_paths.ToArray(), export_path);
                        }
                        catch{
                            //error with a corrupt or empty pdf
                        }
                    }
                }
                else{ //zip file
                    string temp_folder_location = settings.getOutputPath() + @"\zip"; //create path for a temp folder that will get zipped then deleted
                    try{
                        Directory.CreateDirectory(temp_folder_location);
                    }
                    catch{
                        //error creating the temp directory
                    }
                    foreach (Invoice inv in results) { //iterate through results checking if invoice needs to be exported
                        if(inv.Export){
                            count_exports++;
                            string output = temp_folder_location + "\\" + inv.File_name;
                            try{
                                File.Copy(inv.Final_destination, output);
                            }
                            catch{
                                //error copying file
                            }
                        }
                    }
                    if(count_exports > 0){ //check if anything was exported, as to not make empty pdf
                        export_path = output_path + @"\" + today.ToString("Hmmss.MMddyyyy") + ".export.zip"; //path of zip file export with timestamp in zip filename
                        try{
                            ZipFile.CreateFromDirectory(temp_folder_location, export_path);
                            try{
                            Directory.Delete(temp_folder_location, true);
                            }
                            catch{
                                //error deleting temp folder
                            }
                        }
                        catch{
                            //error zipping folder
                        }
                    }
                }

                //return either "" or path where export was saved to
                return export_path;
            }
        }
    }
}