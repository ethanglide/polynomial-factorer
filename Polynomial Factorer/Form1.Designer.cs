
namespace Polynomial_Factorer
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
            this.label1 = new System.Windows.Forms.Label();
            this.coefficientsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.function = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.Label();
            this.showWork = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(963, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factor Your Simple Polynomial";
            // 
            // coefficientsText
            // 
            this.coefficientsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coefficientsText.Location = new System.Drawing.Point(24, 243);
            this.coefficientsText.MaxLength = 35;
            this.coefficientsText.Name = "coefficientsText";
            this.coefficientsText.Size = new System.Drawing.Size(794, 49);
            this.coefficientsText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your coefficients here, each seperated by only one space:";
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(944, 243);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(138, 49);
            this.button.TabIndex = 3;
            this.button.Text = "Factor";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // function
            // 
            this.function.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function.ForeColor = System.Drawing.SystemColors.ControlText;
            this.function.Location = new System.Drawing.Point(12, 339);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(1181, 89);
            this.function.TabIndex = 4;
            this.function.Text = "ax^2 + bx + c";
            // 
            // final
            // 
            this.final.AutoSize = true;
            this.final.Font = new System.Drawing.Font("Yu Gothic UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.ForeColor = System.Drawing.SystemColors.ControlText;
            this.final.Location = new System.Drawing.Point(12, 463);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(565, 89);
            this.final.TabIndex = 5;
            this.final.Text = "x = zero1, zero2...";
            // 
            // showWork
            // 
            this.showWork.AutoSize = true;
            this.showWork.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showWork.Location = new System.Drawing.Point(944, 220);
            this.showWork.Name = "showWork";
            this.showWork.Size = new System.Drawing.Size(136, 17);
            this.showWork.TabIndex = 6;
            this.showWork.Text = "Enable Guess Showing";
            this.showWork.UseVisualStyleBackColor = true;
            this.showWork.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1205, 597);
            this.Controls.Add(this.showWork);
            this.Controls.Add(this.final);
            this.Controls.Add(this.function);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coefficientsText);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1221, 636);
            this.MinimumSize = new System.Drawing.Size(1221, 636);
            this.Name = "Form1";
            this.Text = "Polynomial Factorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coefficientsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label function;
        private System.Windows.Forms.Label final;
        private System.Windows.Forms.CheckBox showWork;
    }
}

