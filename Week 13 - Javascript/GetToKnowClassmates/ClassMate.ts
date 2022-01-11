//Use TS when you need/want strong typing 
//Examples of when you want strong typing: 
//Databases, File IO, certain JS Frameworks 
//When you don't care about strong typing use JS 
//Mostly front-end JS, smaller JS task
class Student {
    name: string;
    homeTown: string;
    favoriteFood: string;
    constructor(name: string, homeTown: string, favoriteFood: string) {
        this.name = name;
        this.homeTown = homeTown;
        this.favoriteFood = favoriteFood;
    }
}

//Like in C#, an array can be of any type built in or user created
let classMates: Student[] = [];

//Push functions like add for C# lists, it will add the new element 
//to he final spot in the array
classMates.push(new Student("Joey", "Raleigh, NC", "Tandoori"));
classMates.push(new Student("Jaime", "Texas, Texas", "Green Fried Tomatoes"));
classMates.push(new Student("Jose", "Nebraska", "Salmon"));
classMates.push(new Student("Jenni", "Ontario, Canada", "Rice n Veggies"));

//Javascript will allow you to print your directly 
//This is a good idea when debugging 
console.log(classMates);

//since we're doing DOM manipulation we don't need a return type
function LearnAboutStudent(): void {
    let index: number = document.getElementById("ClassMate").value;
    let stu: Student = classMates[index];

    let info: string = document.getElementById("Info").value;
    let output: string = `Name: ${stu.name}`;
    if (info === "homeTown") {
        output += `Home Town: ${stu.homeTown}`;
    }
    else {
        output += `Favorite Food: ${stu.favoriteFood} `;
    }

    document.getElementById("Output").innerText = output;


}