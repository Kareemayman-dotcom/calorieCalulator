using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Threading.Tasks;

public class FoodApi
{
    private readonly string apiKey;
    private readonly string apiHost;
    private readonly HttpClient client;

    public FoodApi(string apiKey, string apiHost)
    {
        this.apiKey = apiKey;
        this.apiHost = apiHost;
        this.client = new HttpClient();
        this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<string> GetNutritionData(string ingredient)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://edamam-edamam-nutrition-analysis.p.rapidapi.com/api/nutrition-data?ingr={ingredient}&nutrition-type=cooking"),
            Headers =
            {
                { "X-RapidAPI-Key", apiKey },
                { "X-RapidAPI-Host", apiHost },
            },
        };

        using (var response = await client.SendAsync(request))
        {
            var content = await response.Content.ReadAsStringAsync();

            // Print the content to the console
            Console.WriteLine(content);

            return content;
        }
    }
}

//class Program
//{
//    static async Task Main(string[] args)
//    {
       

//        // Replace "500g%20of%20oats" with the actual ingredient you want to query
//        string ingredient = "500g%20of%20oats";

//        string result = await GlobalVariables.foodApi.GetNutritionData(ingredient);
//        Console.WriteLine(result);
//    }
//}
