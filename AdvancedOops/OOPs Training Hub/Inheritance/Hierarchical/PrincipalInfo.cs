using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public class PrincipalInfo:PersonalDetails
    {
        private int s_princiapID=100;
        public string PrincipalID { get;}
        public string Qualification { get; set; }
        public int Exp { get; set; }
        public DateTime Joining { get; set; }

        public PrincipalInfo(string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string qualification, int exp, DateTime joining):base(name,  fatherName,  mobile,  mail,  dob,  gender)
        {
            s_princiapID++;
            PrincipalID="PID"+s_princiapID;
            Qualification=qualification;
            Exp=exp;
            Joining=joining;

        }

         public PrincipalInfo(string principalID,string name, string fatherName, long mobile, string mail, DateTime dob, string gender,string qualification, int exp, DateTime joining):base(name,  fatherName,  mobile,  mail,  dob,  gender)
        {
           // s_princiapID++;
            PrincipalID=principalID;
            // Qualification=qualification;
            // Exp=exp;
            // Joining=joining;

        }

        public string ShowPreinciapDetails()
        {
            return($"{PrincipalID}  {Name}  {FatherName}  {Mobile}  {Mail}  {DOB}  {Gender}  {Qualification}  {Exp}  {Joining}");
        }
    }
    
}