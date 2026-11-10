using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_and_Mushroom_App
{
    public partial class MushroomForm : Form
    {
        // Store the Login Form so we can return to it when exiting.
        private LoginForm? loginForm;

        // Keep track of the current question.
        private enum QuestionStage
        {
            Ring,
            Forest,
            Gills,
            ConvexCap
        }

        private QuestionStage currentStage = QuestionStage.Ring;

        // Remember which decision branch led to the convex cap question.
        private bool capForRingBranch = false;

        // Count the questions already answered.
        private int questionsAnswered = 0;

        // Check whether identification is complete.
        private bool identificationFinished = false;


        // Default constructor
        public MushroomForm()


        {
            InitializeComponent();
            StartIdentification();
        }
        // Constructor that receives LoginForm
        public MushroomForm(LoginForm login) : this()
        {
            loginForm = login;
        }




        private void MushroomForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to Mushroom identification ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to restart the identification?",
                "Confirm Reset",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (response == DialogResult.Yes)
            {
                StartIdentification();
            }
        }



        // Start or restart identification
        private void StartIdentification()
        {
            currentStage = QuestionStage.Ring;
            capForRingBranch = false;
            questionsAnswered = 0;
            identificationFinished = false;

            // Display the first question.
            lblQuestionTitle.Text = "QUESTION 1 OF 3";
            lblQuestion.Text = "Does the mushroom have a ring?";
            lblInstruction.Text = "Select YES or NO to continue.";

            // Clear previous result.
            lblResultTitle.Text = "IDENTIFICATION RESULT";
            lblResult.Text = "Your result will appear here.";

            // Enable the answer buttons.
            btnYes.Enabled = true;
            btnNo.Enabled = true;
        }


        // Display the next question
        private void AskQuestion(QuestionStage stage, string question)
        {
            currentStage = stage;

            lblQuestionTitle.Text =
                "QUESTION " + (questionsAnswered + 1) + " OF 3";

            lblQuestion.Text = question;
            lblInstruction.Text = "Select YES or NO to continue.";
        }


        // Process the answer selected by the user
        private void ProcessAnswer(bool answer)
        {
            // Validation: prevent answers after identification is complete.
            if (identificationFinished)
            {
                MessageBox.Show(
                    "Identification is already complete. Please click RESET to start again.",
                    "Identification Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // Count the answered question.
            questionsAnswered++;

            switch (currentStage)
            {
                case QuestionStage.Ring:

                    if (answer == true)
                    {
                        // The mushroom has a ring.
                        AskQuestion(
                            QuestionStage.Forest,
                            "Does the mushroom grow in a forest?"
                        );
                    }
                    else
                    {
                        // The mushroom does not have a ring.
                        AskQuestion(
                            QuestionStage.Gills,
                            "Does the mushroom have gills?"
                        );
                    }

                    break;


                case QuestionStage.Forest:

                    if (answer == true)
                    {
                        ShowResult(
                            "Amanite tue-mouche",
                            "The mushroom has a ring and grows in a forest."
                        );
                    }
                    else
                    {
                        capForRingBranch = true;

                        AskQuestion(
                            QuestionStage.ConvexCap,
                            "Does the mushroom have a convex cap?"
                        );
                    }

                    break;


                case QuestionStage.Gills:

                    if (answer == false)
                    {
                        ShowResult(
                            "Cepe de Bordeaux",
                            "The mushroom has no ring and does not have gills."
                        );
                    }
                    else
                    {
                        capForRingBranch = false;

                        AskQuestion(
                            QuestionStage.ConvexCap,
                            "Does the mushroom have a convex cap?"
                        );
                    }

                    break;


                case QuestionStage.ConvexCap:

                    if (capForRingBranch == true)
                    {
                        // Ring branch: Agaric or Coprin.
                        if (answer == true)
                        {
                            ShowResult(
                                "Agaric Jaunissant",
                                "The mushroom has a ring, does not grow in a forest, and has a convex cap."
                            );
                        }
                        else
                        {
                            ShowResult(
                                "Coprin chevelu",
                                "The mushroom has a ring, does not grow in a forest, and does not have a convex cap."
                            );
                        }
                    }
                    else
                    {
                        // No-ring branch: Pied bleu or Girolle.
                        if (answer == true)
                        {
                            ShowResult(
                                "Pied bleu",
                                "The mushroom has no ring, has gills, and has a convex cap."
                            );
                        }
                        else
                        {
                            ShowResult(
                                "Girolle",
                                "The mushroom has no ring, has gills, and does not have a convex cap."
                            );
                        }
                    }

                    break;
            }
        }


        // Display the final identification result
        private void ShowResult(string mushroomName, string explanation)
        {
            identificationFinished = true;

            lblQuestionTitle.Text = "IDENTIFICATION COMPLETE";
            lblQuestion.Text = "The identification process is finished.";

            lblInstruction.Text =
                "Click RESET if you want to identify another mushroom.";

            lblResultTitle.Text = "IDENTIFIED MUSHROOM";

            lblResult.Text =
                mushroomName + Environment.NewLine +
                explanation +
                Environment.NewLine + Environment.NewLine +
                "Educational result only. This does not confirm whether a mushroom is safe to eat.";

            // Disable answer buttons after getting a result.
            btnYes.Enabled = false;
            btnNo.Enabled = false;

            MessageBox.Show(
                "Identification Result: " + mushroomName,
                "Mushroom Identification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure you want to exit Mushroom Identification?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (response == DialogResult.Yes)
            {
                if (loginForm != null)
                {
                    loginForm.Show();
                }

                this.Close();
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ProcessAnswer(true);


        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ProcessAnswer(false);

        }
    }
}
