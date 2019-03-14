using System;

namespace PrototypePattern
{
    class Sandwich : SandwichPrototype
    {
        private readonly string Bread;
        private readonly string Meat;
        private readonly string Cheese;
        private readonly string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            string ingredientList = GetIngredientList();
            Console.WriteLine($"Cloning sandwich with ingredients: {ingredientList.Remove(ingredientList.LastIndexOf(","))}");

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return $"{Bread}{Meat}{Cheese}{Veggies}";
        }
    }
}
