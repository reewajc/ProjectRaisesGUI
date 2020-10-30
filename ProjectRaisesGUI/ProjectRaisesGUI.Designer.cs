namespace ProjectRaisesGUI
{
    partial class ProjectRaisesGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.txtSalaryInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDisplaySalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-185, -57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Location = new System.Drawing.Point(48, 46);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(254, 36);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please enter your current salary:";
            // 
            // txtSalaryInput
            // 
            this.txtSalaryInput.AcceptsReturn = true;
            this.txtSalaryInput.Location = new System.Drawing.Point(391, 43);
            this.txtSalaryInput.Name = "txtSalaryInput";
            this.txtSalaryInput.Size = new System.Drawing.Size(182, 27);
            this.txtSalaryInput.TabIndex = 2;
            this.txtSalaryInput.TextChanged += new System.EventHandler(this.txtSalaryInput_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(246, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(166, 29);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDisplaySalary
            // 
            this.lblDisplaySalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplaySalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDisplaySalary.Location = new System.Drawing.Point(165, 118);
            this.lblDisplaySalary.Name = "lblDisplaySalary";
            this.lblDisplaySalary.Size = new System.Drawing.Size(339, 109);
            this.lblDisplaySalary.TabIndex = 4;
            this.lblDisplaySalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplaySalary.Visible = false;
            // 
            // ProjectRaisesGUI
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 336);
            this.Controls.Add(this.lblDisplaySalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSalaryInput);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.label1);
            this.Name = "ProjectRaisesGUI";
            this.Text = "Next Year Salary Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtSalaryInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDisplaySalary;
    }
}

