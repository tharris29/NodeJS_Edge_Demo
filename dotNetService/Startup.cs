using System.Threading.Tasks;
using dotNetService.models;

namespace dotNetService
{
    public class Startup
    {
        
        public Task<object> Invoke(object input)
        {
            return GetCheese();
        }

        async Task<object> GetCheese()
        {
            var cheese = new Cheeses();
            cheese.Cheese.Add("blue cheese");

            return cheese;
        }
    }
}
