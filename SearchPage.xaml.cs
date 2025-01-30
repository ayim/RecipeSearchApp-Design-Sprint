using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace RecipeApp
{
    public partial class SearchPage : ContentPage
    {
        public ObservableCollection<Recipe> SearchResults { get; set; }
        public ICommand SearchCommand { get; set; }

        public SearchPage()
        {
            InitializeComponent();
            SearchResults = new ObservableCollection<Recipe>();
            SearchCommand = new Command<string>(async (query) => await ExecuteSearchCommand(query));
            BindingContext = this;
        }

        private async Task ExecuteSearchCommand(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return;

            var recipes = await RecipeService.SearchRecipesAsync(query);
            SearchResults.Clear();
            foreach (var recipe in recipes)
            {
                SearchResults.Add(recipe);
            }
        }
    }
}
