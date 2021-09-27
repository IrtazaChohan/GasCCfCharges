
namespace GasCCfCharges
{
    partial class FrmGasCCFPrice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 31);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 41);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(108, 94);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(100, 23);
            this.txtGas.TabIndex = 1;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(86, 153);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(153, 30);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "First 8ccf = 0.50p\r\nMore than 8cc = 0.30p each";
            this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(128, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(56, 15);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Enter Gas";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(108, 206);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 4;
            this.lblResult.Visible = false;
            // 
            // FrmGasCCFPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 260);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.btnCalculate);
            this.Name = "FrmGasCCFPrice";
            this.Text = "Gas Price Caluculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblResult;
    }
}

