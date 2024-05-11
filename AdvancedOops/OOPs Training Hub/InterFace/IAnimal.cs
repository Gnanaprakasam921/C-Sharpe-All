using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterFace
{
    public interface IAnimal
    {
        string Name{get;set;}
        string Habit{get;set;}
        string EatingHabit{get;set;}

        void DisplayName(string name, string habit, string eatinghabit);
    }
}