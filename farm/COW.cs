using farm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farm
{
    public class COW: Animal
    {
       public DateTime BirthDate { get; init; }
        static readonly int Maxlife { get; }

        static int Number;
        public float Weight { get; set; }

        public bool IsMale { get; set; }

        public float HealthParameteTemp { get; set; }

    }






    public override string Tostring() => $"C{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}";
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
public class Sheep:Animal
{
    public DateTime BirthDate { get; init; }
    static readonly int Maxlife { get; }

    static int Number;
    public float Weight { get; set; }

    public bool IsMale { get; set; }
    public float HealthParameteTemp { get; set; }


    public override string Tostring()
    {
        return $"S{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}";
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