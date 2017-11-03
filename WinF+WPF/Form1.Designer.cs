namespace WinF_WPF
{
    partial class FormCalc
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
            this.tbScreen = new System.Windows.Forms.TextBox();
            this.btNum1 = new System.Windows.Forms.Button();
            this.btNum2 = new System.Windows.Forms.Button();
            this.btNum3 = new System.Windows.Forms.Button();
            this.btNum4 = new System.Windows.Forms.Button();
            this.btNum5 = new System.Windows.Forms.Button();
            this.btNum6 = new System.Windows.Forms.Button();
            this.btNum7 = new System.Windows.Forms.Button();
            this.btNum8 = new System.Windows.Forms.Button();
            this.btNum9 = new System.Windows.Forms.Button();
            this.btNum0 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btCount = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btNeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbScreen
            // 
            this.tbScreen.Location = new System.Drawing.Point(31, 29);
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(249, 20);
            this.tbScreen.TabIndex = 0;
            this.tbScreen.TextChanged += new System.EventHandler(this.tbScreen_TextChanged);
            // 
            // btNum1
            // 
            this.btNum1.Location = new System.Drawing.Point(31, 85);
            this.btNum1.Name = "btNum1";
            this.btNum1.Size = new System.Drawing.Size(32, 24);
            this.btNum1.TabIndex = 1;
            this.btNum1.Text = "1";
            this.btNum1.UseVisualStyleBackColor = true;
            this.btNum1.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum2
            // 
            this.btNum2.Location = new System.Drawing.Point(69, 85);
            this.btNum2.Name = "btNum2";
            this.btNum2.Size = new System.Drawing.Size(32, 24);
            this.btNum2.TabIndex = 1;
            this.btNum2.Text = "2";
            this.btNum2.UseVisualStyleBackColor = true;
            this.btNum2.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum3
            // 
            this.btNum3.Location = new System.Drawing.Point(107, 85);
            this.btNum3.Name = "btNum3";
            this.btNum3.Size = new System.Drawing.Size(32, 24);
            this.btNum3.TabIndex = 1;
            this.btNum3.Text = "3";
            this.btNum3.UseVisualStyleBackColor = true;
            this.btNum3.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum4
            // 
            this.btNum4.Location = new System.Drawing.Point(31, 115);
            this.btNum4.Name = "btNum4";
            this.btNum4.Size = new System.Drawing.Size(32, 24);
            this.btNum4.TabIndex = 1;
            this.btNum4.Text = "4";
            this.btNum4.UseVisualStyleBackColor = true;
            this.btNum4.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum5
            // 
            this.btNum5.Location = new System.Drawing.Point(69, 115);
            this.btNum5.Name = "btNum5";
            this.btNum5.Size = new System.Drawing.Size(32, 24);
            this.btNum5.TabIndex = 1;
            this.btNum5.Text = "5";
            this.btNum5.UseVisualStyleBackColor = true;
            this.btNum5.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum6
            // 
            this.btNum6.Location = new System.Drawing.Point(107, 115);
            this.btNum6.Name = "btNum6";
            this.btNum6.Size = new System.Drawing.Size(32, 24);
            this.btNum6.TabIndex = 1;
            this.btNum6.Text = "6";
            this.btNum6.UseVisualStyleBackColor = true;
            this.btNum6.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum7
            // 
            this.btNum7.Location = new System.Drawing.Point(31, 145);
            this.btNum7.Name = "btNum7";
            this.btNum7.Size = new System.Drawing.Size(32, 24);
            this.btNum7.TabIndex = 1;
            this.btNum7.Text = "7";
            this.btNum7.UseVisualStyleBackColor = true;
            this.btNum7.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum8
            // 
            this.btNum8.Location = new System.Drawing.Point(69, 145);
            this.btNum8.Name = "btNum8";
            this.btNum8.Size = new System.Drawing.Size(32, 24);
            this.btNum8.TabIndex = 1;
            this.btNum8.Text = "8";
            this.btNum8.UseVisualStyleBackColor = true;
            this.btNum8.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum9
            // 
            this.btNum9.Location = new System.Drawing.Point(107, 145);
            this.btNum9.Name = "btNum9";
            this.btNum9.Size = new System.Drawing.Size(32, 24);
            this.btNum9.TabIndex = 1;
            this.btNum9.Text = "9";
            this.btNum9.UseVisualStyleBackColor = true;
            this.btNum9.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btNum0
            // 
            this.btNum0.Location = new System.Drawing.Point(31, 175);
            this.btNum0.Name = "btNum0";
            this.btNum0.Size = new System.Drawing.Size(32, 24);
            this.btNum0.TabIndex = 1;
            this.btNum0.Text = "0";
            this.btNum0.UseVisualStyleBackColor = true;
            this.btNum0.Click += new System.EventHandler(this.btNum1_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(210, 85);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(32, 24);
            this.btPlus.TabIndex = 1;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(248, 85);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(32, 24);
            this.btMinus.TabIndex = 1;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(210, 115);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(32, 24);
            this.btDiv.TabIndex = 1;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(248, 115);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(32, 24);
            this.btMult.TabIndex = 1;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(210, 145);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(32, 24);
            this.btCount.TabIndex = 1;
            this.btCount.Text = "=";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(248, 145);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(32, 24);
            this.btClear.TabIndex = 1;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btNeg
            // 
            this.btNeg.Enabled = false;
            this.btNeg.Location = new System.Drawing.Point(107, 175);
            this.btNeg.Name = "btNeg";
            this.btNeg.Size = new System.Drawing.Size(32, 24);
            this.btNeg.TabIndex = 1;
            this.btNeg.Text = "+/-";
            this.btNeg.UseVisualStyleBackColor = true;
            this.btNeg.Visible = false;
            this.btNeg.Click += new System.EventHandler(this.btNeg_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 223);
            this.Controls.Add(this.btNum0);
            this.Controls.Add(this.btNeg);
            this.Controls.Add(this.btNum9);
            this.Controls.Add(this.btNum8);
            this.Controls.Add(this.btNum7);
            this.Controls.Add(this.btNum6);
            this.Controls.Add(this.btNum5);
            this.Controls.Add(this.btNum4);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCount);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btNum3);
            this.Controls.Add(this.btNum2);
            this.Controls.Add(this.btNum1);
            this.Controls.Add(this.tbScreen);
            this.Name = "FormCalc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbScreen;
        private System.Windows.Forms.Button btNum1;
        private System.Windows.Forms.Button btNum2;
        private System.Windows.Forms.Button btNum3;
        private System.Windows.Forms.Button btNum4;
        private System.Windows.Forms.Button btNum5;
        private System.Windows.Forms.Button btNum6;
        private System.Windows.Forms.Button btNum7;
        private System.Windows.Forms.Button btNum8;
        private System.Windows.Forms.Button btNum9;
        private System.Windows.Forms.Button btNum0;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btNeg;
    }
}

