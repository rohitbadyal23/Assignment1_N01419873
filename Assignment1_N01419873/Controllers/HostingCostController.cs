using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_N01419873.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/HostingCost/{id}
        public IEnumerable<string> Get(double id)
        {   
            //rounding down the values 15 and 21 to be 1 fortnight instead of a decimal.
            double FN = Math.Floor(id / 14);
            //How much to charge
            double charge = (5.50 * FN) + 5.50;
            //Finding the HST
            double HST = (charge * 0.13);
            //Rounding HST to 2 decimal places for output 2
            double HSTround = Math.Round(HST, 2);
            //Adding the hst to the charge
            double total = (charge + HST);
            //Rounding the total to 2 decimal places
            double total_round = Math.Round(total, 2);
            //Creating the three strings
            string output1 = (FN + " " + "fortnights at $5.50/FN = $" + charge + " " + "CAD");
            string output2 = ("HST 13% = $" + HSTround + " " + "CAD");
            string output3 = ("Total = $" + total_round + " " + "CAD");
            //Returning the three outputs
            return new string[] { output1, output2, output3 };
        }
    }
}
