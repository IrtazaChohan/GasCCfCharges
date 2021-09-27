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
