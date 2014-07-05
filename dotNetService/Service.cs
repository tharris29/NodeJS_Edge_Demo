using System.Threading.Tasks;
using dotNetService.models;

namespace dotNetService
{
    public class Service
    {
        
        public async Task<object> GetCheese(object input)
        {

            var cheese = new Cheeses();
            cheese.Cheese.Add("blue cheese");

            return cheese;
        }
    }
}
