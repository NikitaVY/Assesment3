using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class CalcElectricityBill
    {
        static void Main()
        {
            Console.WriteLine(" Enter Customer ID: ");
            int custID = Convert.ToByte(Console.ReadLine());

            Console.WriteLine(" Enter Customer Name: ");
            string custName = Console.ReadLine();

            Console.WriteLine("Enter the unit consumed by user: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Customer ID : {custID}");
            Console.WriteLine($"Customer Name : {custName}");
            Console.WriteLine($"Unit Consumed : {unit}");

            float amtCharge = 0, surCharge = 0, netAmount = 0;
            float a = 1.20F, b = 1.50F, c = 1.80F, d = 2.00F;

            if (unit <= 199)
            {
                amtCharge = unit * a;
                Console.WriteLine($"Amount Charges @Rs.{a} per unit : {amtCharge}");
            }
            else if (unit >= 200 && unit < 400)
            {
                amtCharge = unit * b;
                Console.WriteLine($"Amount Charges @Rs.{b} per unit : {amtCharge}");
            }
            else if (unit >= 400 && unit < 600)
            {
                amtCharge = unit * c;
                Console.WriteLine($"Amount Charges @Rs.{c} per unit : {amtCharge}");
            }
            else if (unit >= 600)
            {
                amtCharge = unit * d;
                Console.WriteLine($"Amount Charges @Rs.{d} per unit : {amtCharge}");
            }
            else
            {
                Console.WriteLine("Invalid Unit");
            }

            float discount = 0.15F;
            if (amtCharge > 400)
            {
                surCharge = amtCharge * discount;
            }
            Console.WriteLine($"Surcharge Amount : {surCharge}");

            netAmount = amtCharge + surCharge;
            if (netAmount < 100)
            {
                netAmount = 100;
            }
            Console.WriteLine($"Net Amount Paid By the Customer : {netAmount}" );
        }
    }
}
