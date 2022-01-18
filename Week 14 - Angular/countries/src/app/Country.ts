//This a model done with typescript 
//This is the same idea as a C# model 
export class Country {
    name: string;
    lang: string;
    flagURL: string;
    president: string;

    constructor(name: string, lang: string, flagURL: string, president: string) {
        this.name = name;
        this.lang = lang;
        this.flagURL = flagURL;
        this.president = president;
    }
}