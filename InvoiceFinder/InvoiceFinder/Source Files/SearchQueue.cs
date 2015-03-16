using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace InvoiceFinder
{
    namespace BackEnd
    {
        class SearchQueue
        {
            //class constructor
            public SearchQueue()
            {
                searches = new List<Search>();
            }
            //adds the search s to the back of the queue
            public void addSearch(string s)
            {
               Search temp = new Search(s);
               searches.Add(temp);
            }
            //deletes the item at index
            public void deleteSearch(int index)
            {
                searches.RemoveAt(index);
            }
            //moves the item at from_index to to_index
            public void moveSearch(int from_index, int to_index)
            {
                Search temp = searches[from_index];
                searches.RemoveAt(from_index);
                searches.Insert(to_index, temp);
            }
            //returns a list of each item's value string
            public List<string> readQueue()
            {
                List<string> temp = new List<string>();
                for (int i = 0; i < searches.Count; i++)
                {
                    temp.Add(searches[i].ToString());
                }
                return temp;
            }
            //for use by the Finder, returns the search object at location index in the queue
            public Search getSearch(int index)
            {
                return searches[index];
            }
            //returns the current number of searches
            public int searchCount()
            {
                return searches.Count;
            }
            //temp printing function, just for testing purposes
            public void printSearchQueue()
            {
                for (int i = 0; i < searches.Count; i++)
                {
                    Console.WriteLine("item " + i + ", " + searches[i].ToString());
                }
                Console.WriteLine("\n");
            }
            //holds all the searches
            private List<Search> searches;

        }
    }
}
