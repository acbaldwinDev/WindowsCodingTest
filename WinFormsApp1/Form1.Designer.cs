namespace WinFormsApp1
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
            btnReverseString = new Button();
            lblOutputLabel = new Label();
            txtStringInput = new TextBox();
            btnFizzBuzz = new Button();
            SuspendLayout();
            // 
            // btnReverseString
            // 
            btnReverseString.Location = new Point(68, 95);
            btnReverseString.Name = "btnReverseString";
            btnReverseString.Size = new Size(163, 34);
            btnReverseString.TabIndex = 0;
            btnReverseString.Text = "Reverse String";
            btnReverseString.UseVisualStyleBackColor = true;
            btnReverseString.Click += reverseString;
            // 
            // lblOutputLabel
            // 
            lblOutputLabel.AutoSize = true;
            lblOutputLabel.BackColor = SystemColors.ActiveBorder;
            lblOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            lblOutputLabel.Location = new Point(452, 102);
            lblOutputLabel.MinimumSize = new Size(150, 0);
            lblOutputLabel.Name = "lblOutputLabel";
            lblOutputLabel.Size = new Size(150, 27);
            lblOutputLabel.TabIndex = 1;
            // 
            // txtStringInput
            // 
            txtStringInput.Location = new Point(258, 98);
            txtStringInput.Name = "txtStringInput";
            txtStringInput.Size = new Size(150, 31);
            txtStringInput.TabIndex = 2;
            // 
            // btnFizzBuzz
            // 
            btnFizzBuzz.Location = new Point(68, 159);
            btnFizzBuzz.Name = "btnFizzBuzz";
            btnFizzBuzz.Size = new Size(163, 34);
            btnFizzBuzz.TabIndex = 3;
            btnFizzBuzz.Text = "Fizz Buzz";
            btnFizzBuzz.UseVisualStyleBackColor = true;
            btnFizzBuzz.Click += btnFizzBuzz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFizzBuzz);
            Controls.Add(txtStringInput);
            Controls.Add(lblOutputLabel);
            Controls.Add(btnReverseString);
            Name = "Form1";
            Text = "Coding Test Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblOutputLabel;
        private TextBox txtStringInput;
        private Button btnReverseString;
        private Button btnFizzBuzz;
    }
}
