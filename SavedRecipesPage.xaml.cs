using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace RecipeApp
{
    public partial class SavedRecipesPage : ContentPage
    {
        public ObservableCollection<Recipe> SavedRecipes { get; set; }

        public SavedRecipesPage()
        {
            InitializeComponent();
            SavedRecipes = new ObservableCollection<Recipe>();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LoadSavedRecipes();
        }

        private void LoadSavedRecipes()
        {
            var savedRecipes = RecipeService.GetSavedRecipes();
            SavedRecipes.Clear();
            foreach (var recipe in savedRecipes)
            {
                SavedRecipes.Add(recipe);
            }
        }
    }
}
