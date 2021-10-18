using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDBRedux
{
    class Student
    {
        //The main job of this class is to represent an individual student's data 
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }

        public Student(string Name, string HomeTown, string FavoriteFood)
        {
            this.Name = Name;
            this.HomeTown = HomeTown;
            this.FavoriteFood = FavoriteFood;
        }


    }
}
