function AddHello() {

    //the document represents our page and is the base of any 
    //DOM manipulate 
    let output = document.getElementById("Output");

    //This makes a p Tag object, but doesnt inject it 
    let p = document.createElement("p");
    p.innerText = "Hello World";
    output.appendChild(p);
}