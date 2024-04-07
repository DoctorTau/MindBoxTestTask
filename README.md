# FiguresLib 📐

FiguresLib is a .NET library for working with geometric figures. It provides an abstract [`Figure`](FiguresLib/Figure.cs) class that you can extend to create your own geometric figures.

## Features 🚀

- Abstract [`Figure`](FiguresLib/Figure.cs) class with methods for calculating the area and perimeter of a figure.
- [`Triangle`](FiguresLib/Triangle.cs) class that extends the `Figure` class. It has methods for calculating the area, perimeter of a triangle and check weather it's a right triangle.
- [`Round`](FiguresLib/Round.cs) class that extends the `Figure` class. It has methods for calculating the area and perimeter of a round.

## Getting Started 🏁

To get started with FiguresLib, you need to have .NET 8.0 installed on your machine. Once you have that, you can clone this repository and open `MindBox.sln` in your preferred IDE.

## Testing 🧪

Tests for the library are located in the `FiguresTest` directory. You can run these tests to verify the functionality of the library.
