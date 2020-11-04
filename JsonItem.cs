using System;
using System.Collections.Generic;
using System.Text;

//Define your PokeItem model which will have a Name, and a Url.
namespace WTHjsonitem
{
    //Make your class public, since by default it is internal.
    public class JsonItem
    {
        public JsonItem(string name)
        {
            Name = name;
        }

        //Your Properties are auto-implemented.
        public string Name { get; set; }
    }
}