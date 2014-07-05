using System.Collections.Generic;

namespace dotNetService.models
{
    public class Cheeses
    {
        public Cheeses()
        {
            Cheese = new List<string>();
        }

        public IList<string> Cheese { get; set; }
    }
}