using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<Literature> _literatures;
        List<Literature> filtered;

        public Library()
        {
            _literatures = new List<Literature>();
        }

        public List<Literature> literature { get { return _literatures; } }

        public string addToStock(Literature item) 
        {
            if (_literatures.Contains(item))
            {
                return new string($"{item.title} has already been added to the collection in your library");
            }
            else
            {
                this._literatures.Add(item);
                return new string($"{item.title} was added to the collection!");
            }
        }

        public string checkInLiterature(string title)
        {
            if(!IsInLibraryCollection(title)) 
            {
                return "item is not in the library collection";
            }

            return filtered[0].checkIn();
        }
        public string checkOutLiterature(string title)
        {
            if (!IsInLibraryCollection(title))
            {
                return "item is not part of the library's collection";
            }

            filtered = new List<Literature>(); // Initialize filtered list

            foreach (Literature item in this._literatures)
            {
                if (item.title.Equals(title))
                {
                    filtered.Add(item);
                }
            }

            // Ensure filtered is not empty
            if (filtered.Count == 0)
            {
                return "error during check-out: filtered list is empty";
            }

            return filtered[0].checkOut();
        }



        private bool IsInLibraryCollection(string title)
        {
            filtered = new List<Literature>();

            foreach (Literature item in this._literatures)
            {
                if (item.title.Equals(title))
                {
                    filtered.Add(item);
                }
            }

            return filtered.Count > 0;
        }

    }
}
