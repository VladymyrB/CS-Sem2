namespace Calculator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calculationParts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.getResult = new System.Windows.Forms.Button();
            this.addOperation = new System.Windows.Forms.Button();
            this.subOperation = new System.Windows.Forms.Button();
            this.multiplyOperation = new System.Windows.Forms.Button();
            this.devideOperation = new System.Windows.Forms.Button();
            this.numberSign = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decimalSign = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calculationParts);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.resultTextBox);
            this.groupBox1.Controls.Add(this.getResult);
            this.groupBox1.Controls.Add(this.addOperation);
            this.groupBox1.Controls.Add(this.subOperation);
            this.groupBox1.Controls.Add(this.multiplyOperation);
            this.groupBox1.Controls.Add(this.devideOperation);
            this.groupBox1.Controls.Add(this.numberSign);
            this.groupBox1.Controls.Add(this.zero);
            this.groupBox1.Controls.Add(this.decimalSign);
            this.groupBox1.Controls.Add(this.number3);
            this.groupBox1.Controls.Add(this.number2);
            this.groupBox1.Controls.Add(this.number1);
            this.groupBox1.Controls.Add(this.number6);
            this.groupBox1.Controls.Add(this.number5);
            this.groupBox1.Controls.Add(this.number4);
            this.groupBox1.Controls.Add(this.number9);
            this.groupBox1.Controls.Add(this.number8);
            this.groupBox1.Controls.Add(this.number7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Калькулятор";
            // 
            // calculationParts
            // 
            this.calculationParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calculationParts.Location = new System.Drawing.Point(105, 18);
            this.calculationParts.Name = "calculationParts";
            this.calculationParts.Size = new System.Drawing.Size(194, 16);
            this.calculationParts.TabIndex = 4;
            this.calculationParts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(105, 40);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(194, 23);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(105, 214);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(142, 31);
            this.getResult.TabIndex = 0;
            this.getResult.Text = "=";
            this.getResult.UseVisualStyleBackColor = true;
            // 
            // addOperation
            // 
            this.addOperation.Location = new System.Drawing.Point(262, 180);
            this.addOperation.Name = "addOperation";
            this.addOperation.Size = new System.Drawing.Size(37, 31);
            this.addOperation.TabIndex = 0;
            this.addOperation.Text = "+";
            this.addOperation.UseVisualStyleBackColor = true;
            this.addOperation.Click += new System.EventHandler(this.addOperation_Click);
            // 
            // subOperation
            // 
            this.subOperation.Location = new System.Drawing.Point(262, 143);
            this.subOperation.Name = "subOperation";
            this.subOperation.Size = new System.Drawing.Size(37, 31);
            this.subOperation.TabIndex = 0;
            this.subOperation.Text = "-";
            this.subOperation.UseVisualStyleBackColor = true;
            this.subOperation.Click += new System.EventHandler(this.subOperation_Click);
            // 
            // multiplyOperation
            // 
            this.multiplyOperation.Location = new System.Drawing.Point(262, 106);
            this.multiplyOperation.Name = "multiplyOperation";
            this.multiplyOperation.Size = new System.Drawing.Size(37, 31);
            this.multiplyOperation.TabIndex = 0;
            this.multiplyOperation.Text = "*";
            this.multiplyOperation.UseVisualStyleBackColor = true;
            this.multiplyOperation.Click += new System.EventHandler(this.multiplyOperation_Click);
            // 
            // devideOperation
            // 
            this.devideOperation.Location = new System.Drawing.Point(262, 69);
            this.devideOperation.Name = "devideOperation";
            this.devideOperation.Size = new System.Drawing.Size(37, 31);
            this.devideOperation.TabIndex = 0;
            this.devideOperation.Text = "/";
            this.devideOperation.UseVisualStyleBackColor = true;
            this.devideOperation.Click += new System.EventHandler(this.devideOperation_Click);
            // 
            // numberSign
            // 
            this.numberSign.Location = new System.Drawing.Point(105, 180);
            this.numberSign.Name = "numberSign";
            this.numberSign.Size = new System.Drawing.Size(37, 31);
            this.numberSign.TabIndex = 0;
            this.numberSign.Text = "+/-";
            this.numberSign.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(157, 180);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(37, 31);
            this.zero.TabIndex = 0;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // decimalSign
            // 
            this.decimalSign.Location = new System.Drawing.Point(210, 180);
            this.decimalSign.Name = "decimalSign";
            this.decimalSign.Size = new System.Drawing.Size(37, 31);
            this.decimalSign.TabIndex = 0;
            this.decimalSign.Text = ".";
            this.decimalSign.UseVisualStyleBackColor = true;
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(210, 143);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(37, 31);
            this.number3.TabIndex = 0;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(157, 143);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(37, 31);
            this.number2.TabIndex = 0;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(105, 143);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(37, 31);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(210, 106);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(37, 31);
            this.number6.TabIndex = 0;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(157, 106);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(37, 31);
            this.number5.TabIndex = 0;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(105, 106);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(37, 31);
            this.number4.TabIndex = 0;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(210, 69);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(37, 31);
            this.number9.TabIndex = 0;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(157, 69);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(37, 31);
            this.number8.TabIndex = 0;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(105, 69);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(37, 31);
            this.number7.TabIndex = 0;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 295);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.Button addOperation;
        private System.Windows.Forms.Button subOperation;
        private System.Windows.Forms.Button multiplyOperation;
        private System.Windows.Forms.Button devideOperation;
        private System.Windows.Forms.Button numberSign;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decimalSign;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox calculationParts;
    }
}

