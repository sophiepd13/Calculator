namespace Calculator
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CButton = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("NSimSun", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(7, 7);
            this.richTextBox1.MaxLength = 8;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 64);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // CButton
            // 
            this.CButton.Location = new System.Drawing.Point(12, 87);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(83, 57);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // SignButton
            // 
            this.SignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignButton.Location = new System.Drawing.Point(119, 87);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(83, 57);
            this.SignButton.TabIndex = 2;
            this.SignButton.Text = "+ / -";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MultiplyButton.Location = new System.Drawing.Point(226, 87);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(83, 57);
            this.MultiplyButton.TabIndex = 3;
            this.MultiplyButton.Text = "X";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DivideButton.Location = new System.Drawing.Point(336, 87);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(83, 57);
            this.DivideButton.TabIndex = 4;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click_1);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PlusButton.Location = new System.Drawing.Point(336, 172);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(83, 57);
            this.PlusButton.TabIndex = 5;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MinusButton.Location = new System.Drawing.Point(336, 257);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(83, 57);
            this.MinusButton.TabIndex = 6;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button0.Location = new System.Drawing.Point(336, 350);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(83, 57);
            this.Button0.TabIndex = 7;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button3.Location = new System.Drawing.Point(226, 172);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(83, 57);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button2.Location = new System.Drawing.Point(119, 172);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(83, 57);
            this.Button2.TabIndex = 10;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button1.Location = new System.Drawing.Point(12, 172);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(83, 57);
            this.Button1.TabIndex = 11;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button6.Location = new System.Drawing.Point(226, 257);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(83, 57);
            this.Button6.TabIndex = 12;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button5.Location = new System.Drawing.Point(119, 257);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(83, 57);
            this.Button5.TabIndex = 13;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button4.Location = new System.Drawing.Point(12, 257);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(83, 57);
            this.Button4.TabIndex = 14;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button9.Location = new System.Drawing.Point(226, 350);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(83, 57);
            this.Button9.TabIndex = 15;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button8.Location = new System.Drawing.Point(119, 350);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(83, 57);
            this.Button8.TabIndex = 16;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Button7.Location = new System.Drawing.Point(12, 350);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(83, 57);
            this.Button7.TabIndex = 17;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.Calculate.Location = new System.Drawing.Point(60, 437);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(305, 57);
            this.Calculate.TabIndex = 18;
            this.Calculate.Text = "=";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 537);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Calculate;
    }
}

