using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class ToDo
    {
        //3 possible parts of a class each part optional
        //only put in what you need 
        //1) Properties 
        //2) Constructor
        //3) Methods 
        public string Name { get; set; }
        public string Description { get; set; }
        
        //This is initialized the property with a default value
        public bool IsCompleted { get; set; } = false;


        public ToDo(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }


    }
}
