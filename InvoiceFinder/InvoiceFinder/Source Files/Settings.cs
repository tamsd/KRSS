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
                input_file_paths = new List<string>();
                final_destination = "";
                archive_a = "";
                archive_b = "";
                output_file_path = "";
                output_type = 1; //needs to be changed
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
            //sets the archive A path
            public void setArchiveA(string file_path)
            {
                archive_a = file_path;
            }
            //gets Archive A
            public string getArchiveA()
            {
                return archive_a;
            }
            //sets the archive B path
            public void setArchiveB(string file_path)
            {
                archive_b = file_path;
            }
            //gets Archive A
            public string getArchiveB()
            {
                return archive_b;
            }


            //adds another search path
            public void addOtherPath(string file_path) {
                input_file_paths.Add(file_path);
            }
            //edits index-th other search path
            public void editOtherPath(int index, string file_path)
            {
                if (index < input_file_paths.Count)
                {
                    input_file_paths[index] = file_path;
                }
            }
            //deletes the index-th other path
            public void deleteOtherPath(int index)
            {
                if (index < input_file_paths.Count)
                {
                    input_file_paths.RemoveAt(index);
                }
            }
            //gets the other path a index
            public string getOtherPath(int index) {
                return input_file_paths[index];
            }
            //return the number of other paths
            public int otherPathCount() {
                return input_file_paths.Count;
            }
            
            //sets and Edits the output_file_path
            public void setOutputPath(string file_path) {
                output_file_path = file_path;
            }
            //gets the output file path
            public string getOutputPath() {
                return output_file_path;
            }
            //set the output type
            public void setOutputType(int type) {
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
            //list of other folders
            //lsit of srchive folders
            //list of temp folders (red boxes)
        }
    }
}
