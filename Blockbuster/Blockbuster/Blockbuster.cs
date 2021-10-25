using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{

    //This stores and allows us to checkout our movies 
    //This is what I like to call a runner class since its main job 
    //is to manage and delegate to other classes
    class Blockbuster
    {
        List<Movie> Movies { get; set; } = new List<Movie>();

        //We'll use the constructor to fill our movie list
        public Blockbuster()
        {
            Movies.Add(new DVD("28 Days Later", Genre.Horror, 130, "Infected attack", "He Wakes up from a coma"));
            Movies.Add(new VHS("Alladin", Genre.Action, 90, "Opening Song", "Alladin steals bread for the kids", "A whole new world"));
        }
    }
}
