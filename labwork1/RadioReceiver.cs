namespace labwork1
{
    public class RadioReceiver : AVDevice
    {
        protected string model, operatingMode;
        public string Model
        {
            get => this.model;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                else this.model = value;
            }
        }
        public string OperatingMode
        {
            get => this.operatingMode;
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException();
                }
                else this.operatingMode = value;
            }
        }
        public RadioReceiver(string _firm, string _model, string _operatingMode, double _price) : base(_firm, _price)
        {
            Model = _model;
            OperatingMode = _operatingMode;
        }
        public override void Print()
        {
            Console.WriteLine($"\nРадиоприемник:\nФирма: {firm}\nМодель: {model}\nРежим работы: {operatingMode}\nЦена: {price}");
        }
    }
}
