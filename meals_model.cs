using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

public class Meal_model
{
    public string mealName { get; set; }
    public string amount { get; set; }
    public string unit { get; set; }
    public string calories { get; set; }
    public string protein { get; set; }
    public string carbs { get; set; }
    public DateTime MealDate { get; set; }

    // Constructor
    public Meal_model(string mealName, string amount, string unit, DateTime mealDate, string jsonResult)
    {
        this.mealName = mealName;
        this.amount = amount;
        this.unit = unit;
        this.MealDate = mealDate;

        // Parse the JSON response
        JObject json = JObject.Parse(jsonResult);

        // Extract values from the nested structure
        this.calories = json["totalNutrients"]["ENERC_KCAL"]["quantity"].ToString();
        this.protein = json["totalNutrients"]["PROCNT"]["quantity"].ToString();
        this.carbs = json["totalNutrients"]["CHOCDF"]["quantity"].ToString();
    }

    public Meal_model(string mealName, string amount, string unit, string calories, string protein, string carbs, DateTime mealDate)
    {
        this.mealName = mealName;
        this.amount = amount;
        this.unit = unit;
        this.calories = calories;
        this.protein = protein;
        this.carbs = carbs;
        MealDate = mealDate;
    }
}

// Example of usage
// string mealName = "YourMealName";
// string amount = "YourAmount";
// string unit = "YourUnit";
// DateTime mealDate = YourDateTime;
// string jsonResult = "YourJsonResult";
// Meal_model meal = new Meal_model(mealName, amount, unit, mealDate, jsonResult);
