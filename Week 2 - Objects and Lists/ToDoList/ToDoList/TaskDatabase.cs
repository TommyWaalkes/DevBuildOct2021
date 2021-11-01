using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    class TaskDatabase
    {
        //Main job of this class is to manage a list of ToDo objects 

        //This line makes an empty list for us. 
        public List<ToDo> ToDos { get; set; } = new List<ToDo>();

        //This is the constructor, it matches the class name
        public TaskDatabase()
        {
            ToDos.Add(new ToDo("Wash Windows", "Get the windex"));
            ToDos.Add(new ToDo("Clean Freezer", "Throw anything gone bad"));
            ToDos.Add(new ToDo("Dodge Taxes", "IRS aint got nothing on us"));
        }

        //Notice I don't pass a list into here 
        //That is because the list in this is global, meaning it is useable anywhere in this class
        public void PrintToDos()
        {
            for(int i = 0; i < ToDos.Count; i++)
            {
                ToDo t = ToDos[i];
                Console.WriteLine($" {i} : {t.Name}");
                Console.WriteLine($"Is Completed: {t.IsCompleted}");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void AddToDo(string name, string description)
        {
            //1) Make a new To Do item 
            //2) Add that object into our list 
            ToDo td = new ToDo(name, description);

            //The Add method on lists simply puts the new item at the end of the list
            //so we dont have to mess with index 
            ToDos.Add(td);
        }

        public void RemoveToDo(int index)
        {
            //If we know the index, then we can feed it into the remove at method 
            try
            {
                ToDos.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"{index} was not a valid index");
                Console.WriteLine($"Please input an index between 0 and {ToDos.Count - 1}");
                Console.WriteLine("Nothing was removed from the list");
            }
            //Remove tries to find a match and removes the first matching if one is found
            //ToDos.Remove(Object);

            //Remove All Removes all items matching the input object 
            //ToDos.RemoveAll(object)
        }

        //1) Pass in the index we wish to update 
        //2) Grab the object at that index from our list 
        //3) Ask the user what they would like to change 
        //4) Change the object 
        //5) Store the updated at the same index in the list 

        public void UpdateToDo(int index)
        {
            //This pulls out the object at that index 
            //TD is a copy but NOT a reference, meaning changes to TD 
            //Don't show up in the list
            ToDo td = ToDos[index];
            Console.WriteLine("What would you like to change about this object: ");
            Console.WriteLine($"Current Name: {td.Name}");
            Console.WriteLine($"Current Description: {td.Description}");

            string input = GetUserInput("Would you like to change either the name or the description (des)?");

            if(input == "name")
            {
                Console.WriteLine("What would you like the new task name to be?");
                string newName = Console.ReadLine();

                //This will override what value for name is in the TD object 
                td.Name = newName;
            }
            else if(input == "des"||input=="description")
            {
                Console.WriteLine("Type in the new description for the TO DO item");
                string newDes = Console.ReadLine();

                td.Description = newDes;
            }

            //Next we need to override the old object in the list 
            ToDos[index] = td;
        }

        public void SetComplete(int index)
        {
            try
            {
                ToDo td = ToDos[index];
                
                //We're overriding 
                td.IsCompleted = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"{index} was not a valid index");
                Console.WriteLine($"Please input an index between 0 and {ToDos.Count - 1}");
            }
        }

        public void DisplayCompleted(bool completed)
        {
            if (completed)
            {
                Console.WriteLine("Completed Tasks: ");
            }
            else
            {
                Console.WriteLine("Uncompleted Tasks: ");
            }
            for(int i = 0; i < ToDos.Count; i++)
            {
                ToDo td = ToDos[i];
                if (completed == td.IsCompleted)
                {
                    Console.WriteLine(td.Name);
                }
            }
        }

        public void SearchListByDescription(string searchTerm)
        {
            for(int i = 0; i < ToDos.Count; i++)
            {
                ToDo t = ToDos[i];
                if(t.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Name: "+t.Name);
                    Console.WriteLine("Description: "+ t.Description);
                    Console.WriteLine();
                }
            }
        }

        public string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            return input;
        }
    }
}
