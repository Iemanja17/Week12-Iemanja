using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;

Console.WriteLine("Checkpoint 2 - Iemanja");

Console.WriteLine("Proyect: Add Product");
Console.WriteLine();

List<Product> products = new List<Product>();
//Add new product
while (true)
{
    Console.WriteLine("To enter a new product, follow the steps. To quit, enter 'Q':");
    Console.WriteLine();
    Console.Write("Enter Category: ");
    string category = Console.ReadLine();
    if( category.ToLower().Trim() == "q")
    {
        break;
    }
    Console.Write("Enter Product name: ");
    string productName = Console.ReadLine();
    if (category.ToLower().Trim() == "q")
    {
        break;
    }
    Console.Write("Enter Product price: ");
    string price = Console.ReadLine();
    if (category.ToLower().Trim() == "q")
    {
        break;
    }
    //Console.ForegroundColor = ConsoleColor.Blue;
    //Console.Write("The product was succefully added! ");
    bool isDecimal = decimal.TryParse(price, out decimal value);
    if (isDecimal)
    {
        products.Add(new Product(category, productName, value));
        Console.WriteLine("The product added succesfully");
    }
    else
    {
        Console.WriteLine("It is not a number");
    }   

}


Console.WriteLine();


//Lamdba expression

List<Product> sortedList = products.OrderBy(p => p.Price).ToList();


Console.WriteLine("My Productslist Sorted");
Console.WriteLine();
//Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Category".PadRight(15) + "Name".PadRight(15) + "Price");

foreach(var item in sortedList)
{
    Console.WriteLine(item.Category.PadRight(15) + " " + item.ProductName.PadRight(15) + " " + item.Price);
}
// Calculate the total amount of the products
decimal totalAmount = products.Sum(p => p.Price);

Console.WriteLine();
Console.WriteLine("Total Amount: " + totalAmount.ToString("C"));
/*
while (true)
{
    AddProducts();
    DisplayProducts();

    Console.WriteLine("\nDo you want to add more products? (Y/N): ");
    Console.ReadLine();
    if (response.ToLower().Trim() != "y")
    {
        break;
    }
}

Console.WriteLine("Thank you for using the program!");*/
class Product
{
    public Product(string category, string productname, decimal price)
    {
        Category = category;
        ProductName = productname;
        Price = price;
        
    }    
    public string Category { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }

 
}




//class ProductManager;
//List<ProductManager> sortedList = ProductManager.Orderby(ProductManager => Product.Category).ToList();
//Console.ReadLine();