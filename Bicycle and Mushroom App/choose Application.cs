
using System;
using System.Windows.Forms;

namespace Bicycle_and_Mushroom_App
{
    public partial class choose_Application : Form
    {
        private LoginForm? loginForm;

        public choose_Application()
        {
            InitializeComponent();
        }

        public choose_Application(LoginForm login) : this()
        {
            loginForm = login;
        }

        // Open Bicycle Form
        private void btnRental_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                MessageBox.Show("Login form reference is missing.");
                return;
            }

            BicycleForm bicycle = new BicycleForm(loginForm);

            bicycle.Show();

            this.Close();
        }

        // Mushroom is not created yet
        private void btnmushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm(loginForm);
            mushroom.Show();
            this.Hide();
        }
           
    }
}
