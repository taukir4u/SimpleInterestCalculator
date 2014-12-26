namespace SimpleInterestCalculator
{
    partial class SimpleInterestCalculatorUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pricipalAmountTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.timePeriodTextBox = new System.Windows.Forms.TextBox();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest Rate (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Period (in Year)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Amount (Result)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note: Interest Calculation Interval Yearly";
            // 
            // pricipalAmountTextBox
            // 
            this.pricipalAmountTextBox.Location = new System.Drawing.Point(143, 22);
            this.pricipalAmountTextBox.Name = "pricipalAmountTextBox";
            this.pricipalAmountTextBox.Size = new System.Drawing.Size(228, 20);
            this.pricipalAmountTextBox.TabIndex = 0;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(143, 55);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(228, 20);
            this.annualInterestRateTextBox.TabIndex = 1;
            // 
            // timePeriodTextBox
            // 
            this.timePeriodTextBox.Location = new System.Drawing.Point(143, 90);
            this.timePeriodTextBox.Name = "timePeriodTextBox";
            this.timePeriodTextBox.Size = new System.Drawing.Size(228, 20);
            this.timePeriodTextBox.TabIndex = 2;
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(143, 192);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(228, 20);
            this.totalAmountTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(280, 136);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(91, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SimpleInterestCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 268);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.timePeriodTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.pricipalAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterestCalculatorUI";
            this.Text = "A Simple Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricipalAmountTextBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox timePeriodTextBox;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

