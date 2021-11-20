using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PizzaStore.Blazor.Models;

namespace PizzaStore.Blazor.Repository

{public class PizzaStoreRepository
     {
         public async Task<List<Pizza>> GetPizzaFromApi()
         {
             var httpClient = new HttpClient();
             var httpResponse = await httpClient.GetAsync("https://localhost:5001/Pizza");
             var pizza = await httpResponse.Content.ReadAsStringAsync();
             var options = new JsonSerializerOptions
             {
                 PropertyNameCaseInsensitive = true
             };
             var res = JsonSerializer.Deserialize<List<Pizza>>(pizza, options);
 
             return res;
         }
 
         public async Task<List<Topping>> GetToppingFromApi()
         {
             var httpClient = new HttpClient();
             var httpResponse = await httpClient.GetAsync("https://localhost:5001/Topping");
             var topping = await httpResponse.Content.ReadAsStringAsync();
             var options = new JsonSerializerOptions
             {
                 PropertyNameCaseInsensitive = true
             };
             var res = JsonSerializer.Deserialize<List<Topping>>(topping, options);
 
             return res;
         }
         
         public async Task<List<OrderResponse>> GetOrdersFromApi()
         {
             var httpClient = new HttpClient();
             var httpResponse = await httpClient.GetAsync("https://localhost:5001/Order");
             var order = await httpResponse.Content.ReadAsStringAsync();
             var options = new JsonSerializerOptions
             {
                 PropertyNameCaseInsensitive = true
             };
             var res = JsonSerializer.Deserialize<List<OrderResponse>>(order, options);
             return res;
         }
         public async Task PostOrderToApi(Order order)
         {
             var httpClient = new HttpClient();
             var body = JsonSerializer.Serialize(order);
             var requestContent = new StringContent(body, Encoding.UTF8, "application/json");
             var httpResponse = await httpClient.PostAsync("https://localhost:5001/Order", requestContent);
         }
     }
}