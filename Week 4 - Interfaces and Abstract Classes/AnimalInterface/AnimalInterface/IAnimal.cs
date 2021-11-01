using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalInterface
{
    //In C#, the naming convention for interfaces so that 
    //They look different from other types of inheritance 
    //is to put a I at start of the interface name 
    interface IAnimal
    {
        //We cannot make properties or constructors in an interface 
        //Just Method stubs 
        //Method stubs are just the method signature, you cannot define a body

        //If I put a parameter in my interface stub
        //My child must have that parameter in their version as well 
        public void Eat(Food f);

    }
}
