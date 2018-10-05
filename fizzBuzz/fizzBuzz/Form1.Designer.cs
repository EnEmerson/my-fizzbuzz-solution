namespace fizzBuzz
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
            this.fizzBuzzButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.fizzInput = new System.Windows.Forms.TextBox();
            this.buzzInput = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fizzBuzzButton
            // 
            this.fizzBuzzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fizzBuzzButton.Location = new System.Drawing.Point(74, 217);
            this.fizzBuzzButton.Name = "fizzBuzzButton";
            this.fizzBuzzButton.Size = new System.Drawing.Size(163, 98);
            this.fizzBuzzButton.TabIndex = 0;
            this.fizzBuzzButton.Text = "Fizz Buzz";
            this.fizzBuzzButton.UseVisualStyleBackColor = true;
            this.fizzBuzzButton.Click += new System.EventHandler(this.fizzBuzzButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(137, 352);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 33);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // fizzInput
            // 
            this.fizzInput.Location = new System.Drawing.Point(137, 71);
            this.fizzInput.Name = "fizzInput";
            this.fizzInput.Size = new System.Drawing.Size(100, 26);
            this.fizzInput.TabIndex = 2;
            // 
            // buzzInput
            // 
            this.buzzInput.Location = new System.Drawing.Point(137, 143);
            this.buzzInput.Name = "buzzInput";
            this.buzzInput.Size = new System.Drawing.Size(100, 26);
            this.buzzInput.TabIndex = 3;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 20;
            this.outputBox.Location = new System.Drawing.Point(347, 61);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(349, 324);
            this.outputBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fizz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buzz:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.buzzInput);
            this.Controls.Add(this.fizzInput);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.fizzBuzzButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fizzBuzzButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox fizzInput;
        private System.Windows.Forms.TextBox buzzInput;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

