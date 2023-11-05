using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Red, Green , Refractor

namespace DemoLibrary;
public class DisplayMessages
{
    public string Greeting(string firstname, int hourOfTheDay)
    {
        string output = "";
        // DataAccess da = new DataAccess();
        // da.WriteToDB("MyData ")

        if(hourOfTheDay < 5 )
        {
            output = $"Go to bed {firstname}";
        }

        else if  (hourOfTheDay < 12)
        {
            output = $"Good morning {firstname}";
        }
        else if (hourOfTheDay < 18)
        {
            output = $"Good afternoon {firstname}";
        }
        else
        {
            output = $"Good evening {firstname}";
        }

        return output;
    }

}