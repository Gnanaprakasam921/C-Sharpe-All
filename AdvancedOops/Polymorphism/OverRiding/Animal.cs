using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverRiding
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Animal sound";
        }
    }
    public class Dog:Animal
    {
        public override string Sound()
        {
            return "Dog sound";
        }
    }

     public class Pomrian:Dog
    {
        public override string Sound()
        {
            return "wow wow";
        }
    }
}