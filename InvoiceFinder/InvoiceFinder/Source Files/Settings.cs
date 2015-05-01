using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        //The Settings class
        //note: when ordering the input file pathes, lower keys are higher priority for the search, and it begins with 0.
        public class Settings
        {

            //constructor for the settings class, initializes the private variables
            public Settings()
            {
                Temp_Folders = new List<string>();
                Archive_Folders = new List<string>();
                Other_Folders = new List<string>();
                final_destination = "";
                output_file_path = InvoiceFinder.Properties.Settings.Default.Output_Path_Persistent;    //default on first is ""
                output_type = InvoiceFinder.Properties.Settings.Default.Output_Type_Persistent;         //default on first load is zip
            }
            //sets the final destination path
            public void setFinalDestination(string file_path)
            {
                final_destination = file_path;
            }
            //gets final destination
            public string getFinalDestination() {
                return final_destination;
            }
           /*Temp_Folders*/
            //adds another search path
            public void addTempFolder(string file_path) {
                Temp_Folders.Add(file_path);
            }
            //edits index-th other search path
            public void editTempFolder(int index, string file_path)
            {
                if (index < Temp_Folders.Count)
                {
                    Temp_Folders[index] = file_path;
                }
            }
            //deletes the index-th other path
            public void deleteTempFolder(int index)
            {
                if (index < Temp_Folders.Count)
                {
                    Temp_Folders.RemoveAt(index);
                }
            }
            //gets the other path a index
            public string getTempFolder(int index) {
                return Temp_Folders[index];
            }
            //return the number of other paths
            public int Temp_FoldersCount() {
                return Temp_Folders.Count;
            }
            /*Archive_Folders*/
            //adds another search path
            public void addArchive_Folder(string file_path)
            {
                Archive_Folders.Add(file_path);
            }
            //edits index-th other search path
            public void editArchive_Folder(int index, string file_path)
            {
                if (index < Archive_Folders.Count)
                {
                    Archive_Folders[index] = file_path;
                }
            }
            //deletes the index-th other path
            public void deleteArchive_Folder(int index)
            {
                if (index < Archive_Folders.Count)
                {
                    Archive_Folders.RemoveAt(index);
                }
            }
            //gets the other path a index
            public string getArchive_Folder(int index)
            {
                return Archive_Folders[index];
            }
            //return the number of other paths
            public int Archive_FoldersCount()
            {
                return Archive_Folders.Count;
            }

            /*Other_Folders*/
            //adds another search path
            public void addOther_Folder(string file_path)
            {
                Other_Folders.Add(file_path);
            }
            //edits index-th other search path
            public void editOther_Folder(int index, string file_path)
            {
                if (index < Other_Folders.Count)
                {
                    Other_Folders[index] = file_path;
                }
            }
            //deletes the index-th other path
            public void deleteOther_Folder(int index)
            {
                if (index < Other_Folders.Count)
                {
                    Other_Folders.RemoveAt(index);
                }
            }
            //gets the other path a index
            public string getOther_Folder(int index)
            {
                return Other_Folders[index];
            }
            //return the number of other paths
            public int Other_FolderCount()
            {
                return Other_Folders.Count;
            }

            
            //sets and Edits the output_file_path
            public void setOutputPath(string file_path) {
                InvoiceFinder.Properties.Settings.Default.Output_Path_Persistent = file_path;
                InvoiceFinder.Properties.Settings.Default.Save();
                output_file_path = file_path;
            }
            //gets the output file path
            public string getOutputPath() {
                return output_file_path;
            }
            //set the output type
            public void setOutputType(int type) {
                InvoiceFinder.Properties.Settings.Default.Output_Type_Persistent = type;
                InvoiceFinder.Properties.Settings.Default.Save();
                output_type = type;
            }
            //set the output type
            public int getOutputType()
            {
                return output_type;
            }

            //for tests
            public void printPaths(){
                for (int i = 0; i < input_file_paths.Count; i++)
                {
                    Console.WriteLine(input_file_paths[i]);
                }
                Console.WriteLine(output_file_path + ", type: " + output_type + "\n");
            }

            private List<string> input_file_paths;
            private string final_destination;
            private string archive_a;
            private string archive_b;
            private string output_file_path;
            private int output_type;
            private List<string> Temp_Folders;
            private List<string> Archive_Folders;
            private List<string> Other_Folders;
        }
    }
}
