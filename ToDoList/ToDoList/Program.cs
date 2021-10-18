using System;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //With object the job of main become mostly creating an running and calling methods on objects
            TaskDatabase TaskDb = new TaskDatabase();

            TaskDb.PrintToDos();
            // TaskDb.AddToDo("Reogranize Code", "We need to clean up the code in our toDo list lab");
            //TaskDb.RemoveToDo(10);
            TaskDb.SetComplete(-10);
            TaskDb.PrintToDos();

        }
    }
}
