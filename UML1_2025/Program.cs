// See https://aka.ms/new-console-template for more information
using UML1_2025;

Console.WriteLine("Hello, World!");


Pizza p1 = new Pizza(1, "Marcerita", "Tomato & cheese", 69);
Pizza p2 = new Pizza(2, "Vesuvio", "Tomato, cheese & ham", 75);
Pizza p3 = new Pizza(3, "Capricciosa", "Tomato, cheese, ham & mushrooms", 80);

Console.WriteLine("Pizzaer: ");
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Console.WriteLine();
Console.WriteLine("Kunder: ");
Customer c1 = new Customer("Peter", "Gade 123", "12121212");
Customer c2 = new Customer("Mikkel", "Alleen 321", "13131313");
Customer c3 = new Customer("Charlotte", "Vej 111", "14141414");

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);

Console.WriteLine();
Order o1 = new Order(c1, p1, true);

Console.WriteLine(o1.ToString());