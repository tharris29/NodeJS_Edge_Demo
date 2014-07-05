using System.Threading.Tasks;
using dotNetService.models;

namespace dotNetService
{
    public class Service
    {
        
        public Task<object> GetCheese(object input)
        {
            return GetCheese();
        }

        private async Task<object> GetCheese()
        {
            var cheese = new Cheeses();
            cheese.Cheese.Add("blue cheese");

            return cheese;
        }
    }
}
