namespace UML_2025_opg3
{
    public class Topping
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public Topping(string name, int price)
        {
            Price = price;
            Name = name; 
        }

        public override string ToString()
        {
            return $"topping {Name} pris {Price} kr.";
        }
    }
}