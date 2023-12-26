    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace calorieCalulator
    {
    public partial class Weightscreen : Form
    {
        public Weightscreen()
        {
            InitializeComponent();
            timeframetxt.SelectedIndex = 0;
            activityFactortxt.SelectedIndex = 0;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw rounded corners for text fields
            GlobalVariables.DrawRoundedCorners(weightText, 10);
            GlobalVariables.DrawRoundedCorners(heightText, 10);
            GlobalVariables.DrawRoundedCorners(calcbtn, 20);
            GraphicsPath roundedRect = GetRoundedRect(ClientRectangle, 20);
            
            this.Region = new Region(roundedRect);

            //DrawRoundedCorners(timeframetxt,20);


        }
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath roundedRect = new GraphicsPath();

            roundedRect.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            roundedRect.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            roundedRect.CloseFigure();

            return roundedRect;
        }


        private void calcbtn_MouseClick(object sender, MouseEventArgs e)
        {
            // When the calcbtn is clicked, calculate the average healthy weight and display it in an alert box

            // Get the entered weight and height as strings
            string weightStr = weightText.Text;
            string heightStr = heightText.Text;
            int timeFrameint = int.Parse((string)timeframetxt.Text);

            // Validate that both weight and height are not empty
            if (string.IsNullOrWhiteSpace(weightStr) || string.IsNullOrWhiteSpace(heightStr))
            {
                MessageBox.Show("Please enter valid values for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the entered values to double
            double weight = double.Parse(weightStr);
            double height = double.Parse(heightStr);

            Dailyscreen dailyscreen = new Dailyscreen();

            // Calculate the average healthy weight (you can replace this formula with the actual calculation)
            double averageHealthyWeight = (height - 100) * 0.9;

            // Display the result in an alert box
            GlobalVariables.deficit = CalculateCalorieDeficit(weight, averageHealthyWeight, timeFrameint, height, activityFactortxt.Text);
            Person person = new Person(weight, averageHealthyWeight, timeFrameint, height, GlobalVariables.deficit);
            GlobalVariables.person = person;
            GlobalVariables.sQLiteDatabase.DeleteAllPersons();
            GlobalVariables.sQLiteDatabase.AddPerson(person);

            MessageBox.Show($"Your average healthy weight is: {averageHealthyWeight:F2} kg", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            dailyscreen.Show();
        }


        private double CalculateCalorieDeficit(double currentWeight, double targetWeight, int timeFrame, double height, string activityFactor)
        {
            const double caloriesPerKg = 7700;

            double weightLossKg = currentWeight - targetWeight;
            // Harris-Benedict equation adjusted for height
            double bmr = 66.47 + (13.75 * currentWeight) + (5.003 * height) - (6.755 * 12);

            // Calculate TDEE based on activity level
            double tdee = bmr * GlobalVariables.GetActivityFactor(activityFactor);

            // Calculate calorie deficit needed for weight loss
            double calorieDeficit = weightLossKg * caloriesPerKg;

            // Calculate target calories per day for weight loss
            double targetCaloriesPerDay = tdee - (calorieDeficit / timeFrame);

            return Math.Max(targetCaloriesPerDay, 1200); // Ensure a minimum of 1200 calories per day
        }

        private void activityFactortxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
