namespace AVDeviceClass
{
    public class AVDevice
    {
        protected string firm;
        protected float price;
        public AVDevice(string _firm, float _price)
        {
            firm = _firm;
            price = _price;
        }
        public virtual void Print()
        {
            Console.WriteLine("Фирма: " + firm + "\nЦена: " + $"{price:0.#####}");
        }
    }
}