function FizzBuzz() {
    //prompt is like Console.Readline in C#, it creates a pop-up 
    //window that allows the user to give input
    //The parameter is the prompt the user will see
    let num = prompt("Please input a number");
    console.log(num);

    if (num % 3 === 0) {
        console.log("Fizz");
    }

    if (num % 5 === 0) {
        console.log("buzz");
    }

    if ((num % 3 !== 0 && num % 5 !== 0)) {
        console.log(num);
    }
}