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

    public partial class Dailyscreen : Form
    {
        bool sideBarExpand = false;
        private string query;
        private string amount;
        private string unit;
        private string ingr;
        List<Meal_model> meals = new List<Meal_model>();
        double totalCalories;
        double totalProtien;
        double totalCarb;
        Weightscreen weightscreen = new Weightscreen();

        GraphicsPath roundedRect;
        public Dailyscreen()
        {
            InitializeComponent();
            GlobalVariables.DrawRoundedCorners(addbtn, 15);
            GlobalVariables.DrawRoundedCorners(removebtn, 15);
            unittxt.SelectedIndex = 0;
             roundedRect = GetRoundedRect(ClientRectangle, 20);
            this.Region = new Region(roundedRect);
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
        private void Dailyscreen_Load(object sender, EventArgs e)
        {
            targetCaloriestxt.Text = $"{Math.Floor(GlobalVariables.person.targetCalories)}";
            meals = GlobalVariables.sQLiteDatabase.LoadMealsForToday();
            updateIngrList();
            CalculateTotal();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBarBackground_Paint(object sender, PaintEventArgs e)
        {

        }


        private void menuButton_MouseClick(object sender, MouseEventArgs e)
        {

            if (sideBarTimer.Enabled)
            {
                sideBarTimer.Stop();
                sideBarExpand = !sideBarExpand;
                sideBarTimer.Start();
            }
            else
            {
                sideBarTimer.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                sideBar.Width += 8;
                if (sideBar.Width >= sideBar.MaximumSize.Width)
                {
                    sideBarExpand = false;
                    sideBarTimer.Stop();

                }
            }
            else
            {
                sideBar.Width -= 8;
                if (sideBar.Width <= sideBar.MinimumSize.Width)
                {
                    sideBarExpand = true;
                    sideBarTimer.Stop();
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalculateTotal()
        {
            totalCalories = 0;
            totalProtien = 0;
            totalCarb = 0;

            foreach (var meal in meals)
            {
                totalCalories += double.Parse(meal.calories);
                totalProtien += double.Parse(meal.protein);
                totalCarb += double.Parse(meal.carbs);
            }

            // Update the UI with the calculated values
            day_caloriestxt.Text = $"{(int)Math.Floor(totalCalories)}";
            day_protientxt.Text = $"{(int)Math.Floor(totalProtien)} g";
            day_carbstxt.Text = $"{(int)Math.Floor(totalCarb)} g";

        }
        private void updateIngrList()
        {
            ingrList.Items.Clear();

            foreach (var meal in meals)
            {
                // Concatenate amount, unit, and meal name
                string listItem = $"{meal.amount} {meal.unit} - {meal.mealName}";
                ingrList.Items.Add(listItem);
            }
        }
        private void RemoveBtn_Click(object sender, MouseEventArgs e)
        {
            // Check if an item is selected in the ingrList
            if (ingrList.SelectedIndex != -1)
            {
                // Get the selected item
                string selectedItem = ingrList.SelectedItem.ToString();

                // Extract the meal name from the selected item (assuming it is formatted as "amount unit - mealName")
                string[] parts = selectedItem.Split('-');
                string mealNameToRemove = parts[1].Trim();

                // Find the meal in the list by meal name
                var mealToRemove = meals.Find(m => m.mealName == mealNameToRemove);

                // Remove the meal from the list
                if (mealToRemove != null)
                {
                    GlobalVariables.sQLiteDatabase.RemoveMeal(mealToRemove);
                    meals.Remove(mealToRemove);

                    // Update the UI
                    CalculateTotal();
                    updateIngrList();
                }
            }

        }
        private void scaleClick(object sender, MouseEventArgs e)
        {
            // Close the current form
            this.Close();

            // Show the previous form
            if (weightscreen != null && !weightscreen.IsDisposed)
            {
                weightscreen.Show();
            }
        }
        private async void Addingrbtn_MouseClick(object sender, MouseEventArgs e)
        {
            amount = amounttxt.Text;
            unit = unittxt.Text;
            ingr = ingrtxt.Text;
            query = $"{amount} {unit} {ingr}";
            string formattedIngredient = $"{amount}%{unit}%{ingr}";
            string nutritionData = await GlobalVariables.foodApi.GetNutritionData(formattedIngredient);
            Meal_model meal = new Meal_model(ingr, amount, unit, DateTime.Now, nutritionData);
            meals.Add(meal);
            CalculateTotal();
            updateIngrList();
            GlobalVariables.sQLiteDatabase.storeMeal(meal);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath roundedRect = GetRoundedRect(ClientRectangle, 20);

            this.Region = new Region(roundedRect);

            //DrawRoundedCorners(timeframetxt,20);


        }
    }
}
