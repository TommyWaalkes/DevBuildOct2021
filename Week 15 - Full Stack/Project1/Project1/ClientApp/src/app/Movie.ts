//So what is a typescript interface vs class?
//A class may declare methods and properties, fills the same role as a C#
//A TS interface operates differently than a C# one, 
//a TS interfaces exist purely to contain properties. And all of those properties 
//have the option of being uninitialized
//Not every API's json data will return consistently in the same format 

//In a JS/TS class, you MUST initialize all properties. 

export interface Movie {
    id: number;
    title: string;
    genre: string;
    runtime: number;
    year: number;
}

export class Convert {
    public static toMovie(json: string): Movie {
        return JSON.parse(json);
    }

    public static movieToJson(value: Movie): string {
        return JSON.stringify(value);
    }
}
