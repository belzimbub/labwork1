namespace labwork1
{
    //Интерфейс и работа с классами
    public class MenuClass()
    {
        //Добавление телевизора в список
        public static void addTelevision(List<AVDevice> deviceList)
        {
            try
            {
                Console.WriteLine("Введите фирму:");
                string _firm = Console.ReadLine();
                Console.WriteLine("Введите разрешение экрана:");
                string _screenResolution = Console.ReadLine();
                Console.WriteLine("Введите размер телевизора:");
                double _size = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите цену:");
                double _price = Convert.ToDouble(Console.ReadLine());
                deviceList.Add(new Television(_firm, _screenResolution, _size, _price));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Пожалуйста, введите допустимое значение.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат числа. Пожалуйста, введите допустимое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком велико или слишком мало.");
            }
        }
        //Добавление радиоприемника в список
        public static void addRadio(List<AVDevice> deviceList)
        {
            try
            {
                Console.WriteLine("Введите фирму:");
                string _firm = Console.ReadLine();
                Console.WriteLine("Введите модель:");
                string _model = Console.ReadLine();
                Console.WriteLine("Введите режим работы:");
                string _operatingMode = Console.ReadLine();
                Console.WriteLine("Введите цену:");
                float _price = Convert.ToSingle(Console.ReadLine());
                deviceList.Add(new RadioReceiver(_firm, _model, _operatingMode, _price));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Пожалуйста, введите допустимое значение.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат числа. Пожалуйста, введите допустимое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Число слишком велико или слишком мало.");
            }
        }
        //Вывод списка
        public static void printList(List<AVDevice> deviceList)
        {
            Console.WriteLine("Список объектов:");
            if (!deviceList.Equals(null))
            {
                foreach (var device in deviceList)
                {
                    device.Print();    
                }
            }
        }
        //Меню опций
        public static void choice(int num, List<AVDevice> deviceList)
        {
            switch (num)
            {
                case 1: addTelevision(deviceList); break;
                case 2: addRadio(deviceList); break;
                case 3: printList(deviceList); break;
                //Удаление списка и выключение приложения
                case 4: deviceList.Clear(); System.Environment.Exit(1); break;
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            var deviceList = new List<AVDevice>();
            int num;
            while (true)
            {
                Console.WriteLine("\n1) Добавить телевизор\n2) Добавить радиоприёмник\n3) Вывести список\n4) Завершить работу программы\nВведите цифру от 1 до 4:\n");
                num = Convert.ToInt32(Console.ReadLine());
                MenuClass.choice(num, deviceList);
            }
        }
    }
}