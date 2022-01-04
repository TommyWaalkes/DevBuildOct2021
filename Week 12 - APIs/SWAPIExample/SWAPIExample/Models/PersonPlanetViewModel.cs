using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPIExample.Models
{
    //A view model is a model that exists purely to carry data to a view.
    //Often it is used to move multiple different models at once like planet and people
    //They exist purely for display purposes 
    public class PersonPlanetViewModel
    {
        public Person Person { get; set; }
        public Planet Planet { get; set; }
    }
}
