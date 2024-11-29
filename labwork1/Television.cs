namespace labwork1
{
    public class Television : AVDevice
    {
        protected string screenResolution;
        protected double size;
        public string Resolution
        {
            get => this.screenResolution;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                else this.screenResolution = value;
            }
        }
        public double Size
        {
            get => this.size;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                else this.size = value;
            }
        }
        public Television(string _firm, string _screenResolution, double _size, double _price) : base(_firm, _price)
        {
            Resolution = _screenResolution;
            Size = _size;
        }
        public override void Print()
        {
            Console.WriteLine($"\nТелевизор:\nФирма: {firm}\nРазрешение экрана: {screenResolution}\nРазмер телевизора: {size}\nЦена: {price}");
        }
    }
}
