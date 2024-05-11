using System;
namespace Poly4;
class Program 
{
    public static void Main(string[] args)
    {

        FreeLancer freeLancer=new FreeLancer("fhsd","fdsh","jsdf","sfkdkjj","kdfshj",25);
        System.Console.WriteLine(freeLancer.Display());
        SyncFusion syncFusion=new SyncFusion("fhsd","fdsh","jsdf","sfkdkjj","kdfshj",25,"chennai");
        System.Console.WriteLine(syncFusion.Display());
    }
}
