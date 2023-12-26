using System.Data.SQLite;

public class SQLiteDatabase
{
    private SQLiteConnection _connection;

    public SQLiteDatabase(string databasePath)
    {
        _connection = new SQLiteConnection($"Data Source={databasePath};Version=3;");
        _connection.Open();
    }

    public void CloseConnection()
    {
        _connection.Close();
    }


    public void storeMeal(Meal_model meal)
    {
        string insertQuery = "INSERT INTO meals (meal_name, amount, calories, protein, carbs, meal_date, unit) " +
                             "VALUES (@mealName, @amount, @calories, @protein, @carbs, @mealDate, @unit)";
        using (var command = new SQLiteCommand(insertQuery, _connection))
        {
            // Add parameters
            command.Parameters.AddWithValue("@mealName", meal.mealName);
            command.Parameters.AddWithValue("@amount", meal.amount);
            command.Parameters.AddWithValue("@calories", meal.calories); // Add the actual calories value
            command.Parameters.AddWithValue("@protein", meal.protein); // Add the actual protein value
            command.Parameters.AddWithValue("@carbs", meal.carbs); // Add the actual carbs value
            command.Parameters.AddWithValue("@mealDate", meal.MealDate);
            command.Parameters.AddWithValue("@unit", meal.unit);

            // Execute the command
            command.ExecuteNonQuery();
        }
    }
    public void RemoveMeal(Meal_model meal)
    {
        try
        {
            // Use SQLite date function to extract date part
            string deleteQuery = "DELETE FROM meals WHERE meal_name = @mealName AND amount = @amount AND strftime('%Y-%m-%d', meal_date) = @mealDate";

            using (var command = new SQLiteCommand(deleteQuery, _connection))
            {
                // Add parameters
                command.Parameters.AddWithValue("@mealName", meal.mealName);
                command.Parameters.AddWithValue("@amount", meal.amount);

                // Extract date part from DateTime and convert it to string
                string mealDate = meal.MealDate.ToString("yyyy-MM-dd");
                command.Parameters.AddWithValue("@mealDate", mealDate);

                // Execute the command
                command.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error removing meal: {ex.Message}");
        }
    }


    public List<Meal_model> LoadMealsForToday()
    {
        List<Meal_model> meals = new List<Meal_model>();

        string selectQuery = "SELECT * FROM meals WHERE strftime('%Y-%m-%d', meal_date) = date('now')";

        using (var command = new SQLiteCommand(selectQuery, _connection))
        using (var reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                Meal_model meal = new Meal_model(reader["meal_name"].ToString(), reader["amount"].ToString(), reader["unit"].ToString(), reader["calories"].ToString(), reader["protein"].ToString(), reader["carbs"].ToString(), DateTime.Parse(reader["meal_date"].ToString()));

                meals.Add(meal);
            }
        }

        return meals;
    }

    public void AddPerson(Person person)
    {
        string insertQuery = "INSERT INTO person (current_weight, target_weight, time_frame, current_height, target_calories) " +
                             "VALUES (@currentWeight, @targetWeight, @timeFrame, @currentHeight,@target_calories)";
        using (var command = new SQLiteCommand(insertQuery, _connection))
        {
            // Add parameters
            command.Parameters.AddWithValue("@currentWeight", person.currentWeight);
            command.Parameters.AddWithValue("@targetWeight", person.targetWeight);
            command.Parameters.AddWithValue("@timeFrame", person.timeFrame);
            command.Parameters.AddWithValue("@currentHeight", person.currentHeight);
            command.Parameters.AddWithValue("@target_calories", person.targetCalories);


            // Execute the command
            command.ExecuteNonQuery();
        }
    }
    public Person GetLastPerson()
    {
        string selectQuery = "SELECT * FROM person ORDER BY id DESC LIMIT 1";

        using (var command = new SQLiteCommand(selectQuery, _connection))
        using (var reader = command.ExecuteReader())
        {
            if (reader.Read())
            {
                Person lastPerson = new Person(Convert.ToDouble(reader["current_weight"]), Convert.ToDouble(reader["target_weight"]), Convert.ToInt32(reader["time_frame"]), Convert.ToDouble(reader["current_height"]), Convert.ToDouble(reader["target_calories"]));
                //{
                //    currentWeight = Convert.ToDouble(reader["current_weight"]),
                //    targetWeight = Convert.ToDouble(reader["target_weight"]),
                //    timeFrame = Convert.ToInt32(reader["time_frame"]),
                //    currentHeight = Convert.ToDouble(reader["current_height"]),
                //    targetCalories = Convert.ToDouble(reader["target_calories"])
                //    // Add other properties as needed
                //};

                return lastPerson;
            }
        }

        return null; // Return null if no person found
    }
    public void DeleteAllPersons()
    {
        string deleteQuery = "DELETE FROM person";

        using (var command = new SQLiteCommand(deleteQuery, _connection))
        {
            // Execute the command
            command.ExecuteNonQuery();
        }
    }
}
//    public List<Person> ReadRecords()
//    {
//        List<Person> persons = new List<Person>();

//        using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM Persons", _connection))
//        using (SQLiteDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                string name = reader["Name"].ToString();
//                int age = Convert.ToInt32(reader["Age"]);
//                persons.Add(new Person { Name = name, Age = age });
//            }
//        }

//        return persons;
//    }

//    // Implement Update and Delete methods as needed...

//}
