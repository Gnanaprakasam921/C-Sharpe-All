using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterFace
{
    public class Dog:IAnimal
    {
        
       public string Name{get;set;}
       public string Habit{get;set;}
       public string EatingHabit{get;set;}

       public Dog(string name, string habit, string eatinghabit)
       {
        Name=name;
        Habit=habit;
        EatingHabit=eatinghabit;
       }
        public void DisplayName(string name, string habit, string eatinghabit)
        {
            Name=name;
            Habit=habit;
            EatingHabit=eatinghabit;
        }
    }
}