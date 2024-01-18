﻿using System;
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
        public List<Literature> literature {  get { return _literatures; } }    

        public string addToStock(Literature item) {
            if(_literatures.Contains(item)) 
            {
                return new string($"{item.title}, is already part of the Library collection.");
            }
            else
            {
                this._literatures.Add(item);
                return new string ($"{item.title}, was added to the Library collection.");   
            }
        }


        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInLiterature(string title) {

            if (!IsInLibraryCollection(title)) {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOutLiterature(string title) {
            
            if (!IsInLibraryCollection(title)) {
                return "item is not part of the library's collection";
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

            if (filtered.Count() < 1)
            { return false; }
            else return true;
        }

        
    }
}
