using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class EligibilityOfAdmission
    {
        static void Main()
        {
            int phy_marks = 65;
            int che_marks = 51;
            int math_marks = 72;

            if(phy_marks >= 55 && che_marks >= 50 && math_marks >= 65 && ((phy_marks + che_marks + math_marks >= 180) || (math_marks + phy_marks >= 140)))
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
               Console.WriteLine("The candidate is not eligible for admission");
            }
        }
    }
}
