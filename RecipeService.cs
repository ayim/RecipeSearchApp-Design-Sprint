using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipeApp
{
    public static class RecipeService
    {
        private static List<Recipe> savedRecipes = new List<Recipe>();

        public static async Task<List<Recipe>> SearchRecipesAsync(string query)
        {
            // Simulate an API call to search for recipes
            await Task.Delay(1000);

            // Return a list of dummy recipes for demonstration purposes
            return new List<Recipe>
            {
                new Recipe { Title = "Spaghetti Bolognese", Ingredients = "Spaghetti, ground beef, tomato sauce", Instructions = "Cook spaghetti, brown beef, add sauce" },
                new Recipe { Title = "Chicken Alfredo", Ingredients = "Fettuccine, chicken breast, Alfredo sauce", Instructions = "Cook fettuccine, cook chicken, add sauce" },
                new Recipe { Title = "Vegetable Stir Fry", Ingredients = "Mixed vegetables, soy sauce, rice", Instructions = "Stir fry vegetables, add sauce, serve with rice" }
            };
        }

        public static List<Recipe> GetSavedRecipes()
        {
            return savedRecipes;
        }

        public static void SaveRecipe(Recipe recipe)
        {
            savedRecipes.Add(recipe);
        }

        public static void RemoveRecipe(Recipe recipe)
        {
            savedRecipes.Remove(recipe);
        }
    }
}
