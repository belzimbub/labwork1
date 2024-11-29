namespace labwork1
{
    public class AVDevice
    {
        protected string firm;
        protected double price;
        public string Firm
        {
            get => this.firm;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                else this.firm = value;
            }
        }
        public double Price
        {
            get => this.price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else this.price = value;
            }
        }
        public AVDevice(string _firm, double _price)
        {
            Firm = _firm;
            Price = _price;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Фирма: {firm}\nЦена: {price}");
        }
    }
}
