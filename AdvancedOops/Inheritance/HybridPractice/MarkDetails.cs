using System;

namespace HybridPractice
{
    public interface IMarkDetails
    {
        // inter face has propertey  and metohd 
        // it dont has feild
    
        int Mark1 { get; set; }
         int Mark2 { get; set; }
         int Mark3 { get; set; }

          void GetMark(int mark1,int mark2, int mark3);
    
        
    }

   
}
