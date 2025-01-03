// Importing necessary namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// Namespace definition
namespace White_Ch6._6
{
    // Form class for Hospital_Expenses
    public partial class Hospital_Expenses : Form
    {
        // Constructor for the Hospital_Expenses form
        public Hospital_Expenses()
        {
            InitializeComponent(); // Initialize form components
        }

        // Event handler for the exit button click event
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }

        // Placeholder for GetCharges method
        private void GetCharges()
        {
            // Method implementation is missing
        }

        // Event handler for key press event in DayInput
        // This ensures only numeric input is allowed
        private void DayInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it is not a digit or control character, cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter only numbers."); // Show error message
            }
        }

        // Event handler for key press event in MedInput
        // This ensures only numeric input is allowed
        private void MedInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it is not a digit or control character, cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter only numbers."); // Show error message
            }
        }

        // Event handler for key press event in SurgInput
        // This ensures only numeric input is allowed
        private void SurgInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it is not a digit or control character, cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter only numbers."); // Show error message
            }
        }

        // Event handler for key press event in LabInput
        // This ensures only numeric input is allowed
        private void LabInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it is not a digit or control character, cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter only numbers."); // Show error message
            }
        }

        // Event handler for key press event in RehabInput
        // This ensures only numeric input is allowed
        private void RehabInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it is not a digit or control character, cancel the key press event
                e.Handled = true;
                MessageBox.Show("Please enter only numbers."); // Show error message
            }
        }

        // Method to calculate the total stay charges
        private int GetStayTotal()
        {
            int Day;

            // Try to parse the number of days from DayInput
            if (int.TryParse(DayInput.Text, out Day))
            {
                return Day * 350; // Return total stay charges (350 per day)
            }

            return 0; // Return 0 if parsing fails
        }

        // Method to calculate other charges (rehab, lab, medication, surgical)
        private double OtherCharges()
        {
            double Rehab;
            double Lab;
            double Medication;
            double Surgical;

            // Try to parse rehab charges from RehabInput
            if (double.TryParse(RehabInput.Text, out Rehab))
            {
                // Parsed value is assigned to Rehab variable
            }

            // Try to parse lab charges from LabInput
            if (double.TryParse(LabInput.Text, out Lab))
            {
                // Parsed value is assigned to Lab variable
            }

            // Try to parse surgical charges from SurgInput
            if (double.TryParse(SurgInput.Text, out Surgical))
            {
                // Parsed value is assigned to Surgical variable
            }

            // Try to parse medication charges from MedInput
            if (double.TryParse(MedInput.Text, out Medication))
            {
                // Parsed value is assigned to Medication variable
            }

            // Return the sum of all charges
            return Medication + Surgical + Lab + Rehab;
        }

        // Event handler for the calculate button click event
        private void CalcBtn_Click(object sender, EventArgs e)
        {
            double Total;

            // Calculate other charges
            double MiscTotal = OtherCharges();
            // Calculate total stay charges
            int DayTotal = GetStayTotal();
            // Update labels with calculated values
            StayLbl.Text = GetStayTotal().ToString();
            OtherLbl.Text = OtherCharges().ToString();
            // Calculate total charges
            Total = DayTotal + MiscTotal;
            // Update total label with calculated value
            TotalLbl.Text = Total.ToString();
        }
    }
}
