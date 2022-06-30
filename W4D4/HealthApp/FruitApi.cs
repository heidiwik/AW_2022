using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using APIHelpers;


namespace HealthApp
{
    public static class FruitApi
    {
        const string url = "https://www.fruityvice.com/api/";

        public static async Task<Fruit> GetSingleFruit(string fruitName)
        {
            string urlParams = "fruit/" + fruitName;

            Fruit response = await ApiHelper.RunAsync<Fruit>(url, urlParams);

            return response;
        }
    }
}
