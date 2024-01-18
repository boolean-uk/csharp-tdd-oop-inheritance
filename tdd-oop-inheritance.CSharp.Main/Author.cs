using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author {
        
        protected string Name;
        protected string ContactInformation;
        private string Website;


        public Author(string name, string contactInformation, string website) {
            Name = name;
            ContactInformation = contactInformation;
            Website = website;
        }

        
        // Exercise 2
        public string getName() {
            return Name;
        }

        public string getContactInformation() {
            return ContactInformation;
        }

        public string getWebsite() {
            return Website;
        }


    }
}