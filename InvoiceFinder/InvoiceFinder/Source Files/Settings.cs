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
        class Settings
        {
            ////constructor for the settings class, initializes the private variables
            //public Settings()
            //{
            //    input_file_paths = new Dictionary<int, string>();
            //}
            ////places the final destination path into the dictionary
            //public void setFinalDestination(string file_path)
            //{
            //    input_file_paths.Add(0, file_path);
            //}
            ////edits the final destination path
            //public void setFinalDestination(string file_path)
            //{
            //    if (input_file_paths.ContainsKey(0))
            //    {
            //        input_file_paths[0] = file_path;
            //    }
            //}
            ////places the archive A path into the dictionary
            //public void setArchiveA(string file_path)
            //{
            //    input_file_paths.Add(1, file_path);
            //}

            ////places the archive B path into the dictionary
            //public void setArchiveA(string file_path)
            //{
            //    input_file_paths.Add(2, file_path);
            //}

            //private Dictionary<int, string> input_file_paths;
            //private string output_file_path;
            //private int output_type;
        }
    }
}
