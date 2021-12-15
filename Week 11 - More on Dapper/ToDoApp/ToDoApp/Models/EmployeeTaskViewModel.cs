using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class EmployeeTaskViewModel
    {
        //A view model is a model created specifically only to exist on views 
        //Commonly they are used to show off multiple model classes at once 
        //Or to move small pieces data from controler to the view 
        public List<ToDo> ToDos { get; set; }
        public List<Employee> Employees { get; set; }

        public EmployeeTaskViewModel()
        {
            //We will use both our DALs to fill out this model 
            ToDoDAL tdDAL = new ToDoDAL();
            EmployeeDAL eDAL = new EmployeeDAL();
            ToDos = tdDAL.GetToDos();
            Employees = eDAL.GetEmployees();
        }

    }
}
