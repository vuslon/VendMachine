namespace Vending
{
    public class Drinkable : AProduct
    {
        private int _id;
        private string _name;
        private int _price;
        private int _amount;

       public int Id
        {
            get {return _id;}
            protected set {_id = value;}
        }

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public int Price
        {
            get { return _price; }
            protected set { _price = value; }
        }

        public int Amount
        {
            get {return _amount; }
            set {_amount = value;}
        }

        public Drinkable(int id, string name, int price, int amount) : base(id, name, price, amount)
        {
           
        }
    }
}