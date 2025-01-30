# Recipe Search Application

This is a .NET MAUI application that runs on Android, iOS, Windows, and Mac. The application allows users to search for recipes and save their favorite recipes. The application uses Shell to navigate between two tabbed views: one with the recipe search feature and one with a collection of saved recipes.

## Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022 with .NET MAUI workload installed
- Android Emulator or physical device for Android development
- Xcode and iOS Simulator or physical device for iOS development
- Windows 10 or later for Windows development
- macOS for Mac development

## Setting Up the Development Environment

1. Install the .NET 9.0 SDK or later from the [official .NET website](https://dotnet.microsoft.com/download).
2. Install Visual Studio 2022 with the .NET MAUI workload. You can download Visual Studio 2022 from the [official Visual Studio website](https://visualstudio.microsoft.com/).
3. For Android development, set up an Android Emulator or connect a physical Android device.
4. For iOS development, install Xcode from the App Store and set up an iOS Simulator or connect a physical iOS device.
5. Clone this repository to your local machine.

## Running the Application

### Android

1. Open the solution in Visual Studio 2022.
2. Select the Android project as the startup project.
3. Choose an Android Emulator or connected device from the device list.
4. Press F5 to build and run the application on the selected device.

### iOS

1. Open the solution in Visual Studio 2022.
2. Select the iOS project as the startup project.
3. Choose an iOS Simulator or connected device from the device list.
4. Press F5 to build and run the application on the selected device.

### Windows

1. Open the solution in Visual Studio 2022.
2. Select the Windows project as the startup project.
3. Press F5 to build and run the application on your Windows machine.

### Mac

1. Open the solution in Visual Studio 2022.
2. Select the Mac project as the startup project.
3. Press F5 to build and run the application on your Mac.

## Dependencies

- .NET 9.0 SDK or later
- Visual Studio 2022 with .NET MAUI workload
- Android Emulator or physical device for Android development
- Xcode and iOS Simulator or physical device for iOS development
- Windows 10 or later for Windows development
- macOS for Mac development

## Project Structure

- `AppShell.xaml` and `AppShell.xaml.cs`: Define the Shell navigation structure with two tabs: "Search" and "Saved Recipes".
- `MauiProgram.cs`: Configure the app and register services, including `RecipeService`.
- `MainPage.xaml` and `MainPage.xaml.cs`: Define the layout and UI elements for the main page and implement the logic for handling navigation and user interactions.
- `SearchPage.xaml` and `SearchPage.xaml.cs`: Define the layout and UI elements for the search page and implement the logic for handling search queries and displaying results.
- `SavedRecipesPage.xaml` and `SavedRecipesPage.xaml.cs`: Define the layout and UI elements for the saved recipes page and implement the logic for handling saved recipes and displaying them.
- `Recipe.cs`: Define properties for the recipe, such as title, ingredients, and instructions.
- `RecipeService.cs`: Implement methods for searching recipes and managing saved recipes.
