using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Ram Chapagai
 * Date: 10/29/2020
 * Company: Bellevue
 * Description: Salary projection app
 * 
 */

namespace ProjectRaisesGUI
{
    public partial class ProjectRaisesGUI : Form
    {
        //variable to hold salary for next year
        double salaryNextYear = 0;
        public ProjectRaisesGUI()
        {
            InitializeComponent();
        }

        //Calculate button click event handler
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double currentSalary;
            //Check whether the user entered a value or not in text box
            if(txtSalaryInput.Text.Trim() != string.Empty )
            {
                try
                {
                    currentSalary = Convert.ToDouble(txtSalaryInput.Text);
                    salaryNextYear = currentSalary + (0.4 * currentSalary);
                    lblDisplaySalary.Text = "Your next year salary with 4% increase is: " + salaryNextYear.ToString("C");
                    lblDisplaySalary.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid salary", "Invalid Salary");
                    txtSalaryInput.Clear();
                    txtSalaryInput.Focus();
                  
                }
              
            }
            //If no value was entered in the text field, dispaly error via alert
            else
            {
                MessageBox.Show("You haven't enter your salary", "Please try it again!");
                txtSalaryInput.Focus();
            }
            
           
        }

        //When the input changes in the text field the event is triggered.
        private void txtSalaryInput_TextChanged(object sender, EventArgs e)
        {
            lblDisplaySalary.Text = " ";
            lblDisplaySalary.Visible = false;
        }
    }
}
