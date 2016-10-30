namespace Vending
{
    public abstract class AProduct
    {
        public int Id { get; set; }
        public string Name {get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public AProduct (int id, string name, int price, int amount)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}