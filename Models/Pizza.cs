using System.ComponentModel.DataAnnotations;

namespace Pizza_App_Phase_4_project.Models
{
    public class Pizza
    {
        public int PizzaId { get; set; }

     
        public string Type { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
    }
}
