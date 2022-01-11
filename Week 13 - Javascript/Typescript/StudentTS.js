//In a TS file both typescript AND Javascript are able to be used
var StudentTS = /** @class */ (function () {
    function StudentTS(name, age, hometown, favoriteFood) {
        this.name = name;
        this.age = age;
        this.hometown = hometown;
        this.favoriteFood = favoriteFood;
    }
    return StudentTS;
}());
var stu2 = new StudentTS("phil", 39, "Fredrick MD", "Curry Chicken");
console.log(stu2);
