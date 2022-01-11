//In a TS file both typescript AND Javascript are able to be used

class StudentTS {
    name: string;
    age: number;
    hometown: string;
    favoriteFood: string;

    constructor(name: string, age: number, hometown: string, favoriteFood: string) {
        this.name = name;
        this.age = age;
        this.hometown = hometown;
        this.favoriteFood = favoriteFood;
    }
}

let stu2 = new StudentTS("phil", 39, "Fredrick MD", "Curry Chicken")
console.log(stu2);