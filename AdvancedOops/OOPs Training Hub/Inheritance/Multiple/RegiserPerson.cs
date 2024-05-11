using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple
{
    public class RegiserPerson:PersonalDetails,IShowData,IFamilyInfo
    {
        private static int s_regNo=1000;
        public string RegNo { get; set; }
        public DateTime DateOfRegister { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string Adress { get; set; }
        public int Sibilings { get; set; }


        public RegiserPerson(string name, string gender, DateTime dob, long mobile, Marital marital, string fathername, string motherName, string address, int sibilings,DateTime dateofRegister):base( name,  gender,  dob,  mobile,  marital)
        {
            s_regNo++;
            RegNo="SF"+s_regNo;
            DateOfRegister=dateofRegister;

            FatherName=fathername;
            MotherName=motherName;
            Adress=address;
            Sibilings=sibilings;
        }

        public new string ShowDetails()
        {
            return($"{RegNo}  {Name}  {Gender}  {DOB}  {Mobile}  {Marital}  {FatherName}  {MotherName}  {Adress}  {Sibilings}  {DateOfRegister}");
        }



    }
}