using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS3342_01Viola
{
    public class Calculate : pizza
    {
        private string tip;
        private string size;
        private string tops;
        private string prems;
        private bool fam;
        private double subtotal;
        private double tax;
        private double total;
        public Calculate()
        {
        }
        public Calculate(string Tip, string Size, string Top, string Prems, bool Fam)
        {
            this.tip = Tip;
            this.size = Size;
            this.tops = Top;
            this.prems = Prems;
            this.fam = Fam;
        }
        public string totalTops()
        {
            if (tops != null)
            {
                int numOfTops = tops.Split(',').Length;
                if (numOfTops != 0)
                {
                    subtotal += numOfTops;
                }
                return numOfTops.ToString();
            }
            return "0";
        }

        public string totalPrems()
        {
            if (prems != null)
            {
                int numOfPrems = prems.Split(',').Length;
                if (numOfPrems != 0)
                {
                    subtotal += (numOfPrems * 2);
                }
                return (numOfPrems*2).ToString();
            }
            return "0";
        }
        public string sizeCost()
        {
            if (size == "Small")
            {
                subtotal += 8;
                return "8.00";
            }
            else if (size == "Medium")
            {
                subtotal += 9;
                return "9.00";
            }
            else if (size == "Large")
            {
                subtotal += 10;
                return "10.00";
            }
            else
            {
                subtotal += 11;
                return "11.00";
            }
        }
        public double getTax(double subtotal)
        {
            tax = subtotal * 0.06;
            return tax;
          
        }
        /*
        public string test()
        {
            return "test";
        }
        */
        public double getTotal()
        {
            return subtotal + tax;
        }
        public double getSubtotal()
        {
            double t = Convert.ToDouble(tip);
            subtotal += t;        
            if (fam == false)
            {
               
            }
            else
            {
                subtotal += 6;
            }
            return subtotal;
        }
    }
}