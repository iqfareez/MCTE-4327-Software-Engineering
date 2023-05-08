
namespace WindowsFormsApp2_Exercise2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.operandInput1 = new System.Windows.Forms.TextBox();
            this.operandInput2 = new System.Windows.Forms.TextBox();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator";
            // 
            // operandInput1
            // 
            this.operandInput1.Location = new System.Drawing.Point(163, 37);
            this.operandInput1.Name = "operandInput1";
            this.operandInput1.Size = new System.Drawing.Size(100, 20);
            this.operandInput1.TabIndex = 3;
            this.operandInput1.TextChanged += new System.EventHandler(this.operandInput1_TextChanged);
            // 
            // operandInput2
            // 
            this.operandInput2.Location = new System.Drawing.Point(163, 90);
            this.operandInput2.Name = "operandInput2";
            this.operandInput2.Size = new System.Drawing.Size(100, 20);
            this.operandInput2.TabIndex = 4;
            this.operandInput2.TextChanged += new System.EventHandler(this.operandInput2_TextChanged);
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "Add (+)",
            "Substract (-)",
            "Divide (/)",
            "Multiplication (x)"});
            this.operatorComboBox.Location = new System.Drawing.Point(163, 135);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(100, 21);
            this.operatorComboBox.TabIndex = 5;
            this.operatorComboBox.SelectedIndexChanged += new System.EventHandler(this.operatorComboBox_SelectedIndexChanged);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(49, 188);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(124, 36);
            this.answerLabel.TabIndex = 6;
            this.answerLabel.Text = "Answer:";
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 257);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.operandInput2);
            this.Controls.Add(this.operandInput1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox operandInput1;
        private System.Windows.Forms.TextBox operandInput2;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.Label answerLabel;
    }
}

