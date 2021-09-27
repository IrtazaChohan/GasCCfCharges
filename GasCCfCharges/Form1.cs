using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasCCfCharges
{
    public partial class FrmGasCCFPrice : Form
    {
        public FrmGasCCFPrice()
        {
            InitializeComponent();
        }

        //A gas company measures the amount of gas its customers use in hundreds of cubic feet(ccf) and charges them
        //according to the following schedule:
        //    first 8 ccf 50 cents each
        //    more than 8 ccf 30 cents each
        //Note that the 30 cent rate applies only to usage above 8 ccf.A customer who uses 10 ccf is charged 50 cents for the
        //first 8 ccf and 30 cents for the next 2 ccf.Write a program to calculate customer’s bills.

        double gas = 0;
        double result = 0;
        string formattedMoneyValue;
        private void lblCost_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtGas.Text) <= 8)
            {
                result = int.Parse(txtGas.Text) * 0.50;
                string formattedMoneyValue = String.Format("{0:C2}", result);
                lblResult.Text = "Cost is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
            else if (int.Parse(txtGas.Text) >8)
            {
                //we want anything after 8ccf to be costing 30p and the first 8 to always be 50p
                gas = int.Parse(txtGas.Text);
                result = ((gas - 8) * 0.30) + (8 * 0.50);
                string formattedMoneyValue = String.Format("{0:C2}", result);
                lblResult.Text = "Cost is " + formattedMoneyValue;
                lblResult.Visible = true;
            }
        }
    }
}
