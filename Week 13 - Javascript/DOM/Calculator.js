function RunCalculator() {
    //Get Element grabs an HTML element, but want the inputted number
    let num1 = parseInt(document.getElementById("num1").value);
    let num2 = parseInt(document.getElementById("num2").value);

    //This grabs all our radio buttons 
    //Inputs come in as an array, lets iterate through and find where checked === true
    let inputs = document.getElementById("operation").getElementsByTagName("input");
    let checkedInput;
    for (let i = 0; i < inputs.length; i++) {
        let input = inputs[i];
        if (input.checked === true) {
            //we want to rember the input 
            //and stop the loop
            checkedInput = input;
            break;
        }
    }

    let result;
    //figure out which operation was selected: 
    if (checkedInput.value === "plus") {
        result = num1 + num2;
    }

    document.getElementById("Result").innerText = result;
}