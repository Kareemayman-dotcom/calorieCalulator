using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

public static class GlobalVariables
{
    // Replace these values with your actual API key and host
    public static string apiKey = "c1090af0c9msha6b1febadbd6214p13d9bejsnd5e4d3ec06ed";
    public static string apiHost = "edamam-edamam-nutrition-analysis.p.rapidapi.com";

    public static FoodApi foodApi = new FoodApi(apiKey, apiHost);

    public static int currentWeight;
    public static int currentHeight;
    public static int currentTargetWeight;
    public static int timeFrame;
    public static double deficit =5;
    public static SQLiteDatabase sQLiteDatabase;
    public static void DrawRoundedCorners(Control control, int radius)
    {
        // Adjust the radius based on your preference

        GraphicsPath path = new GraphicsPath();
        path.AddArc(control.ClientRectangle.X, control.ClientRectangle.Y, radius * 2, radius * 2, 180, 90);
        path.AddArc(control.ClientRectangle.Right - radius * 2, control.ClientRectangle.Y, radius * 2, radius * 2, 270, 90);
        path.AddArc(control.ClientRectangle.Right - radius * 2, control.ClientRectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
        path.AddArc(control.ClientRectangle.X, control.ClientRectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
        path.CloseFigure();

        control.Region = new Region(path);

        
    }
    public static Person person;
    // Define activity factors for different levels of activity
    public const double Sedentary = 1.2;
    public const double LightlyActive = 1.375;
    public const double ModeratelyActive = 1.55;
    public const double VeryActive = 1.725;
    public const double ExtraActive = 1.9;

    // Use the appropriate activity factor based on the user's input or profile
    public static double GetActivityFactor(string activityLevel)
    {
        switch (activityLevel)
        {
            case "Sedentary":
                return Sedentary;
            case "Lightly Active":
                return LightlyActive;
            case "Moderately Active":
                return ModeratelyActive;
            case "Very Active":
                return VeryActive;
            case "Extra Active":
                return ExtraActive;
            default:
                return Sedentary; // Default to Sedentary if the input is not recognized
        }
    }
}
