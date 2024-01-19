using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class InventoryItem: Item

{
    private string _title = "";
    private bool onLoan = false;

    public bool isOnLoan()
    {
        return onLoan;
    }

     public string checkIn()
    {

        if (!this.isOnLoan())
        {
            return "item is not currently on loan";
        }

        this.onLoan = false;

        return "item has been checked in";
    }

    public string checkOut()
    {
        if (this.isOnLoan())
        {
            return "item is currently on loan";
        }

        this.onLoan = true;

        return "item has been checked out";

    }
       

        public string Title { get { return _title; } set { _title = value; } }
        
    }
}
