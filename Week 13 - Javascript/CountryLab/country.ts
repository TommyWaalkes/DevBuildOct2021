class Country {
    name: string;
    lang: string;
    greeting: string;
    colors: string[];
    constructor(name, lang, greeting, colors) {
        this.name = name;
        this.lang = lang;
        this.greeting = greeting;
        this.colors = colors;
    }
}
let usa = new Country("USA", "Murican", "Why Hello there world! Have some McDonalds", ["red", "white", "blue"]);
let mexico = new Country("Mexico", "Spanish", "Hola mundo!", ["red", "white", "green"]);
let algeria = new Country("Algeria", "Arabic and Berber", "Sup", ["blue", "yellow", "red"]);
let stankonia = new Country("Stankonia", "English", "Alright alright", ["black", "white"]);

function SwitchCountry() {
    let input = document.getElementById("CountryList").value;
    let country;

    if (input === "USA") {
        //set country to usa 
        country = usa;
    }
    else if (input === "Mexico") {
        country = mexico;
    }
    else if (input === "Algeria") {
        country = algeria;
    }
    else if (input === "Stankonia") {
        country = stankonia;
    }

    document.getElementById("CountryName").innerText = country.name;
    document.getElementById("OfficialLanguage").innerText = country.lang;
    document.getElementById("HelloWorld").innerText = country.greeting;

    document.getElementById("Color1").style.backgroundColor = country.colors[0];
    document.getElementById("Color2").style.backgroundColor = country.colors[1];

    if (country.colors.length > 2) {
        //if theres 3 colors, use the third one
        document.getElementById("Color3").style.backgroundColor = country.colors[2];
        console.log("hello1");
    }
    else {
        //reuse color 1 if there's only 2 colors 
        document.getElementById("Color3").style.backgroundColor = country.colors[1];
        console.log("hello2");
    }

}
