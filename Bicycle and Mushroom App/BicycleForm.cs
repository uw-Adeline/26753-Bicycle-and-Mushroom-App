
using System;
using System.Windows.Forms;

namespace Bicycle_and_Mushroom_App
{
    public partial class BicycleForm : Form
    {
        private LoginForm? loginForm;

        // Default constructor
        public BicycleForm()
        {
            InitializeComponent();

        }

        // Constructor that receives LoginForm
        public BicycleForm(LoginForm login) : this()
        {
            loginForm = login;
            lblResult.Text = "Bicycle Result will appear here";
        }



        // Exit and return to LoginForm
        private void btnExit_Click(object sender, EventArgs e)
        {
            loginForm?.Show();
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            // No action required
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            loginForm.Show();

        }

        private void txtStartHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            {
                int startHour;
                int endHour;

                // 1. Validate starting hour
                if (txtStartHour.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the starting hour.");
                    txtStartHour.Focus();
                    return;
                }

                // 2. Validate ending hour
                if (txtEndHour.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter the ending hour.");
                    txtEndHour.Focus();
                    return;
                }

                // 3. Check whether inputs are numbers
                if (!int.TryParse(txtStartHour.Text, out startHour))
                {
                    MessageBox.Show("Starting hour must be a number.");
                    txtStartHour.Focus();
                    return;
                }

                if (!int.TryParse(txtEndHour.Text, out endHour))
                {
                    MessageBox.Show("Ending hour must be a number.");
                    txtEndHour.Focus();
                    return;
                }

                // 4. Check valid hour ranges
                if (startHour < 0 || startHour > 23)
                {
                    MessageBox.Show("Starting hour must be between 0 and 23.");
                    txtStartHour.Focus();
                    return;
                }

                if (endHour < 1 || endHour > 24)
                {
                    MessageBox.Show("Ending hour must be between 1 and 24.");
                    txtEndHour.Focus();
                    return;
                }

                // 5. Check that ending hour is after starting hour
                if (startHour >= endHour)
                {
                    MessageBox.Show("Ending hour must be greater than starting hour.");
                    txtEndHour.Focus();
                    return;
                }

                // Calculate the rental cost
                int totalCost = 0;

                for (int hour = startHour; hour < endHour; hour++)
                {
                    if (hour < 7)
                    {
                        totalCost += 500;
                    }
                    else if (hour < 14)
                    {
                        totalCost += 1000;
                    }
                    else if (hour < 19)
                    {
                        totalCost += 1500;
                    }
                    else if (hour < 21)
                    {
                        totalCost += 1000;
                    }
                    else
                    {
                        totalCost += 500;
                    }
                }


                // Display result in Label
                lblResult.Text = totalCost.ToString("N0") + " RWF";


                // Display final total in MessageBox
                MessageBox.Show(
                   "The total bicycle rental cost is: " +
                   totalCost.ToString("N0") + " RWF",
                   "Bicycle Rental Result"
               );
            }

        }
    }
}
