using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            FastFoodMenu burger = new Burger("Burger", "Juicy", 76, "Mayo");
            FastFoodMenu chicken = new Chicken("Chicken", "Flaky", 87, "Rough");

            burger.ingridients();
            Console.WriteLine();
            chicken.ingridients();

        }
    }
    
    class FastFoodMenu
    {
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        virtual public void ingridients()
        {
            Console.WriteLine("Ingridients : ");
        }

        public FastFoodMenu(string name, string description, float price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }

    class Burger : FastFoodMenu
    {
        public string sauce { get; set; }

        

        public Burger(string name, string description, float price, string sauce) 
            : base(name, description, price) 
        { 
            this.sauce = sauce;
        }
        public override void ingridients()
        {
            base.ingridients();
            Console.WriteLine("Has Buns, Pickles, Mustard, Ketchup, Patty");
            Console.WriteLine(name + " " + description + " " + price + " " + sauce);
        }

    }

    class Chicken : FastFoodMenu
    {
        public string texture  { get; set; }
        public Chicken(string name, string description, float price, string texture)
            : base(name, description, price)
        {
            this.texture = texture;
        }

        public override void ingridients()
        {
            base.ingridients();
            Console.WriteLine("Chicken, Breader, Oil, Seasoning");
            Console.WriteLine(name + " " + description + " " + price + " " + texture);
        }

    }
}