class Student {
    //This is a property, same idea as C# but different syntax    
    name = "Tommy";
    age;
    hometown;
    favoriteFood;

    //Constructors work the same as C#, but have 
    //different syntax
    constructor(age, hometown, favoriteFood) {

        this.age = age;
        this.hometown = hometown;
        this.favoriteFood = favoriteFood;
    }
}

let stu1 = new Student(30, "Raleigh NC", "Buttered Chicken");
console.log(stu1);
