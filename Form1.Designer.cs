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
            output = new TextBox();
            button0 = new Button();
            buttonDeci = new Button();
            buttonDelete = new Button();
            buttonEqual = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            buttonAdd = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            buttonSub = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonMultiply = new Button();
            buttonClear = new Button();
            buttonNegative = new Button();
            buttonDivide = new Button();
            AllOps = new TextBox();
            SuspendLayout();
            // 
            // output
            // 
            output.BackColor = Color.FromArgb(64, 64, 64);
            output.BorderStyle = BorderStyle.None;
            output.Font = new Font("Adobe Gothic Std B", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 128);
            output.ForeColor = SystemColors.Control;
            output.Location = new Point(1, 64);
            output.Multiline = true;
            output.Name = "output";
            output.Size = new Size(285, 79);
            output.TabIndex = 0;
            output.TextAlign = HorizontalAlignment.Right;
            output.TextChanged += textBox1_TextChanged;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlDarkDark;
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = SystemColors.ControlLightLight;
            button0.Location = new Point(1, 441);
            button0.Name = "button0";
            button0.Size = new Size(72, 73);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button1_Click;
            // 
            // buttonDeci
            // 
            buttonDeci.BackColor = SystemColors.ControlDarkDark;
            buttonDeci.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeci.ForeColor = SystemColors.ControlLightLight;
            buttonDeci.Location = new Point(72, 441);
            buttonDeci.Name = "buttonDeci";
            buttonDeci.Size = new Size(72, 73);
            buttonDeci.TabIndex = 2;
            buttonDeci.Text = ".";
            buttonDeci.UseVisualStyleBackColor = false;
            buttonDeci.Click += buttonDeci_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ControlDarkDark;
            buttonDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.ControlLightLight;
            buttonDelete.Location = new Point(143, 441);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(72, 73);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "⌫";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.BackColor = SystemColors.ControlDark;
            buttonEqual.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEqual.Location = new Point(214, 368);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(72, 146);
            buttonEqual.TabIndex = 4;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = false;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(72, 368);
            button2.Name = "button2";
            button2.Size = new Size(72, 73);
            button2.TabIndex = 5;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(1, 368);
            button1.Name = "button1";
            button1.Size = new Size(72, 73);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(143, 368);
            button3.Name = "button3";
            button3.Size = new Size(72, 73);
            button3.TabIndex = 6;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlDarkDark;
            buttonAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(1, 149);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(72, 73);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1, 295);
            button4.Name = "button4";
            button4.Size = new Size(72, 73);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlDarkDark;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(72, 295);
            button5.Name = "button5";
            button5.Size = new Size(72, 73);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlDarkDark;
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(1, 222);
            button7.Name = "button7";
            button7.Size = new Size(72, 73);
            button7.TabIndex = 10;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDarkDark;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(143, 295);
            button6.Name = "button6";
            button6.Size = new Size(72, 73);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonSub
            // 
            buttonSub.BackColor = SystemColors.ControlDarkDark;
            buttonSub.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSub.ForeColor = SystemColors.ControlLightLight;
            buttonSub.Location = new Point(72, 149);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(72, 73);
            buttonSub.TabIndex = 11;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = false;
            buttonSub.Click += buttonSub_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDarkDark;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(72, 222);
            button8.Name = "button8";
            button8.Size = new Size(72, 73);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDarkDark;
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(143, 222);
            button9.Name = "button9";
            button9.Size = new Size(72, 73);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = SystemColors.ControlDarkDark;
            buttonMultiply.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.ForeColor = SystemColors.ControlLightLight;
            buttonMultiply.Location = new Point(143, 149);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(72, 73);
            buttonMultiply.TabIndex = 14;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = SystemColors.ControlDarkDark;
            buttonClear.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = SystemColors.ControlLightLight;
            buttonClear.Location = new Point(214, 295);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(72, 73);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonNegative
            // 
            buttonNegative.BackColor = SystemColors.ControlDarkDark;
            buttonNegative.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNegative.ForeColor = SystemColors.ControlLightLight;
            buttonNegative.Location = new Point(214, 222);
            buttonNegative.Name = "buttonNegative";
            buttonNegative.Size = new Size(72, 73);
            buttonNegative.TabIndex = 17;
            buttonNegative.Text = "+/-";
            buttonNegative.UseVisualStyleBackColor = false;
            buttonNegative.Click += buttonNegative_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = SystemColors.ControlDarkDark;
            buttonDivide.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivide.ForeColor = SystemColors.ControlLightLight;
            buttonDivide.Location = new Point(214, 149);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(72, 73);
            buttonDivide.TabIndex = 18;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // AllOps
            // 
            AllOps.BackColor = Color.FromArgb(64, 64, 64);
            AllOps.BorderStyle = BorderStyle.None;
            AllOps.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllOps.ForeColor = SystemColors.Control;
            AllOps.Location = new Point(1, 2);
            AllOps.Multiline = true;
            AllOps.Name = "AllOps";
            AllOps.Size = new Size(285, 56);
            AllOps.TabIndex = 19;
            AllOps.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(287, 516);
            Controls.Add(AllOps);
            Controls.Add(buttonDivide);
            Controls.Add(buttonNegative);
            Controls.Add(buttonClear);
            Controls.Add(buttonMultiply);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(buttonSub);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonAdd);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDeci);
            Controls.Add(button0);
            Controls.Add(output);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox output;
        private Button button0;
        private Button buttonDeci;
        private Button buttonDelete;
        private Button buttonEqual;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button buttonAdd;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button buttonSub;
        private Button button8;
        private Button button9;
        private Button buttonMultiply;
        private Button buttonClear;
        private Button buttonNegative;
        private Button buttonDivide;
        private TextBox AllOps;
    }
}
