using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public interface IFamilyInfo:IShowData
    {
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Adress { get; set; }
        public int Sibilings { get; set; }


         new string ShowDetails();

    }

    
}