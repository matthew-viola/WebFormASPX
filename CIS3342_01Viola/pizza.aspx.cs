using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342_01Viola
{
    public partial class pizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tip = Request["tip"];
            string size = Request["size"];
            string tops = Request["top"];
            string premium = Request["prem"];
            string soda = Request["soda"];
            string side = Request["side"];
            bool ifFam = false;
            lblFam.Visible = false;
            lblSoda.Visible = false;
            lblSide.Visible = false;
            if (soda != "None" && side != "None")
            {
                ifFam = true;
                lblFam.Visible = true;
                lblSoda.Visible = true;
                lblSide.Visible = true;
            }
            lblTip.Text = "Tip: $" + tip;
            Calculate c = new Calculate(tip, size, tops, premium, ifFam);
            lblName.Text = Request["firstName"] + " " + Request["lastName"];
            lblAddress.Text = Request["address"];
            lblAddress2.Text = Request["address2"] + " " + Request["county"] + " ," + Request["state"]  + " " + Request["zip"];
            lblMethod.Text = Request["method"];

            lblSize.Text = "Pizza Size: " + size + " +$" + c.sizeCost();
            lblCrust.Text = Request["crust"];
            lblSauce.Text = "Sauce: " + Request["sauce"];
            lblTops.Text = "Toppings: " + tops + " +$" + c.totalTops() + ".00";
            lblPremium.Text = "Premium Options: " + premium + " +$" + c.totalPrems() + ".00" ; 
  
            lblSoda.Text = "Soda: " + Request["soda"];
            lblSide.Text = "Side: " + Request["side"];

            double st = c.getSubtotal();
            lblSubtotal.Text = "Subtotal: $" + st;
            lblTax.Text = "Tax: $" + c.getTax(st).ToString();
            lblTotal.Text = "Total: $" + c.getTotal().ToString();
        }
    }
}