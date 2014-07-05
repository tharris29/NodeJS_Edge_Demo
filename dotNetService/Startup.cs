using System.Threading.Tasks;
using dotNetService.models;

namespace dotNetService
{
    public class Startup
    {
        
        public async Task<object> Invoke(object input)
        {
            var cheese = new Cheeses();
            cheese.Cheese.Add("blue cheese");

            return cheese;
        }
    }
}
