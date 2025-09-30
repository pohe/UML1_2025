// See https://aka.ms/new-console-template for more information

using UML_2025_opg3;

Console.WriteLine("UML1_2025_opg3");


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

Topping t1 = new Topping("Champingnon", 5);
Topping t2 = new Topping("Parma skinke", 7);


Console.WriteLine();
Order o1 = new Order(c1, true);
o1.AddPizza(p1, 2, "Gerne med hvidløg og Chilli", new List<Topping>() { t1, t2 });
o1.AddPizza(p2, 3, "", null);

Console.WriteLine(o1.ToString());