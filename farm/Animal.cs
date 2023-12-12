using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace farm
{
   
    public abstract class Animal
    {
      public Animal() { Number++; }
     public DateTime BirthDate { get; init; }
      static readonly int Maxlife { get; }
     public float Weight { get; set; }

     public bool IsMale { get; set; }

     public int Number { get; protected set; }


    
    
     
    }
 


   

  
 


  public void Life()
    {


        int Age = 0;
        if (Age == 0)
        {
            Console.WriteLine("youe animal are not born");
        }
        else
        {
            Console.WriteLine($"The Age is{Age}");
        }
    }
  
}