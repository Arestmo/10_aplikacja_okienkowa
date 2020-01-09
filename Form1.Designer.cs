namespace _10_aplikacja_okienkowa
{
    partial class Calc
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
            this.label_char = new System.Windows.Forms.Label();
            this.Button_add = new System.Windows.Forms.Button();
            this.Button_substract = new System.Windows.Forms.Button();
            this.Button_multiply = new System.Windows.Forms.Button();
            this.Button_divide = new System.Windows.Forms.Button();
            this.Number_first = new System.Windows.Forms.NumericUpDown();
            this.Number_second = new System.Windows.Forms.NumericUpDown();
            this.Label_result = new System.Windows.Forms.Label();
            this.Text_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Number_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_second)).BeginInit();
            this.SuspendLayout();
            // 
            // label_char
            // 
            this.label_char.AutoSize = true;
            this.label_char.Location = new System.Drawing.Point(113, 27);
            this.label_char.Name = "label_char";
            this.label_char.Size = new System.Drawing.Size(15, 13);
            this.label_char.TabIndex = 0;
            this.label_char.Text = " \"";
            // 
            // Button_add
            // 
            this.Button_add.Location = new System.Drawing.Point(32, 64);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(75, 23);
            this.Button_add.TabIndex = 1;
            this.Button_add.Text = "Dodawanie";
            this.Button_add.UseVisualStyleBackColor = true;
            this.Button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // Button_substract
            // 
            this.Button_substract.Location = new System.Drawing.Point(32, 93);
            this.Button_substract.Name = "Button_substract";
            this.Button_substract.Size = new System.Drawing.Size(75, 23);
            this.Button_substract.TabIndex = 2;
            this.Button_substract.Text = "Odejmowanie";
            this.Button_substract.UseVisualStyleBackColor = true;
            this.Button_substract.Click += new System.EventHandler(this.Button_substract_Click);
            // 
            // Button_multiply
            // 
            this.Button_multiply.Location = new System.Drawing.Point(134, 64);
            this.Button_multiply.Name = "Button_multiply";
            this.Button_multiply.Size = new System.Drawing.Size(75, 23);
            this.Button_multiply.TabIndex = 3;
            this.Button_multiply.Text = "Mnożenie";
            this.Button_multiply.UseVisualStyleBackColor = true;
            this.Button_multiply.Click += new System.EventHandler(this.Button_multiply_Click);
            // 
            // Button_divide
            // 
            this.Button_divide.Location = new System.Drawing.Point(134, 93);
            this.Button_divide.Name = "Button_divide";
            this.Button_divide.Size = new System.Drawing.Size(75, 23);
            this.Button_divide.TabIndex = 4;
            this.Button_divide.Text = "Dzielenie";
            this.Button_divide.UseVisualStyleBackColor = true;
            this.Button_divide.Click += new System.EventHandler(this.Button_divide_Click);
            // 
            // Number_first
            // 
            this.Number_first.Location = new System.Drawing.Point(32, 25);
            this.Number_first.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Number_first.Name = "Number_first";
            this.Number_first.Size = new System.Drawing.Size(75, 20);
            this.Number_first.TabIndex = 5;
            // 
            // Number_second
            // 
            this.Number_second.Location = new System.Drawing.Point(134, 25);
            this.Number_second.Name = "Number_second";
            this.Number_second.Size = new System.Drawing.Size(75, 20);
            this.Number_second.TabIndex = 6;
            // 
            // Label_result
            // 
            this.Label_result.AutoSize = true;
            this.Label_result.Location = new System.Drawing.Point(29, 123);
            this.Label_result.Name = "Label_result";
            this.Label_result.Size = new System.Drawing.Size(37, 13);
            this.Label_result.TabIndex = 7;
            this.Label_result.Text = "Wynik";
            // 
            // Text_result
            // 
            this.Text_result.Location = new System.Drawing.Point(32, 139);
            this.Text_result.Name = "Text_result";
            this.Text_result.Size = new System.Drawing.Size(177, 20);
            this.Text_result.TabIndex = 8;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 190);
            this.Controls.Add(this.Text_result);
            this.Controls.Add(this.Label_result);
            this.Controls.Add(this.Number_second);
            this.Controls.Add(this.Number_first);
            this.Controls.Add(this.Button_divide);
            this.Controls.Add(this.Button_multiply);
            this.Controls.Add(this.Button_substract);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.label_char);
            this.Name = "Calc";
            this.Text = "Kalkulator";
            ((System.ComponentModel.ISupportInitialize)(this.Number_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Number_second)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_char;
        private System.Windows.Forms.Button Button_add;
        private System.Windows.Forms.Button Button_substract;
        private System.Windows.Forms.Button Button_multiply;
        private System.Windows.Forms.Button Button_divide;
        private System.Windows.Forms.NumericUpDown Number_first;
        private System.Windows.Forms.NumericUpDown Number_second;
        private System.Windows.Forms.Label Label_result;
        private System.Windows.Forms.TextBox Text_result;
    }
}

