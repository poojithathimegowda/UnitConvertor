# WPF Unit Converter

A simple and user-friendly unit converter application built using WPF (Windows Presentation Foundation) in C#. This application allows users to convert values between various units of measurement, such as length, weight, temperature, and more.

## Features

- **Multiple Unit Categories**: Convert between units of length, weight, temperature, volume, and more.
- **Real-Time Conversion**: Automatically updates the conversion results as you type.
- **Easy-to-Use Interface**: Intuitive design with drop-down menus for selecting unit types.
- **Error Handling**: Provides feedback for invalid input.

## Usage

1. **Select the conversion category**:
    - Choose the type of conversion you want to perform from the available categories (e.g., Length, Weight, Temperature).

2. **Enter the value to convert**:
    - Input the value you want to convert in the "From" field.

3. **Select the units**:
    - Choose the source unit and the target unit from the drop-down menus.

4. **View the conversion result**:
    - The converted value will be displayed in the "To" field automatically as you type.

## Project Structure

- **MainWindow.xaml**: Contains the XAML markup for the user interface.
- **MainWindow.xaml.cs**: Contains the code-behind for handling user interactions and conversion logic.
- **Converters**: A folder containing classes for different unit conversions.
- **App.xaml**: Defines application-wide resources and settings.
- **App.xaml.cs**: Contains the startup logic for the application.

## Supported Unit Categories

- **Length**: Convert between meters, kilometers, miles, feet, inches, etc.
- **Weight**: Convert between grams, kilograms, pounds, ounces, etc.
- **Temperature**: Convert between Celsius, Fahrenheit, Kelvin, etc.
- **Volume**: Convert between liters, milliliters, gallons, cups, etc.
- **Area**: Convert between square meters, square kilometers, acres, etc.

## Acknowledgments

- Thanks to the developers and community behind [WPF](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/) and [C#](https://docs.microsoft.com/en-us/dotnet/csharp/).
- Inspired by various unit converter tools and applications.
