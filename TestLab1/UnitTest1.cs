using labwork1;
namespace Lab1.Tests
{
    [TestClass]
    public class AVDeviceTests
    {
        [TestMethod]
        public void AVDevicePrintTest()
        {
            var device = new AVDevice("Sony", 999.99);
            var expected = "Фирма: Sony\nЦена: 999,99";
            //Запись в переменную результата, выводимого в консоль
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                device.Print();
                var result = sw.ToString();
                //И сравнение с ожидаемым результатом
                Assert.AreEqual(expected.Trim(), result.Trim());
            }
        }
    }

    [TestClass]
    public class RadioReceiverTests
    {
        [TestMethod]
        public void RadioReceiverPrintTest()
        {
            var receiver = new RadioReceiver("Sony", "RX-100", "FM", 199.99);
            var expected = "\nРадиоприемник:\nФирма: Sony\nМодель: RX-100\nРежим работы: FM\nЦена: 199,99";
            //Запись в переменную результата, выводимого в консоль
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                receiver.Print();
                var result = sw.ToString();
                //И сравнение с ожидаемым результатом
                Assert.AreEqual(expected.Trim(), result.Trim());
            }
        }
    }

    [TestClass]
    public class TelevisionTests
    {
        [TestMethod]
        public void TelevisionPrintTest()
        {
            var television = new Television("LG", "1920x1080", 55.5, 499.99);
            var expected = "Телевизор:\nФирма: LG\nРазрешение экрана: 1920x1080\nРазмер телевизора: 55,5\nЦена: 499,99";
            //Запись в переменную результата, выводимого в консоль
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                television.Print();
                var result = sw.ToString();
                //И сравнение с ожидаемым результатом
                Assert.AreEqual(expected.Trim(), result.Trim());
            }
        }
    }

    [TestClass]
    public class MenuClassTests
    {
        //Проверка добавления объекта класса Телевизор в список
        [TestMethod]
        public void AddTelevisionTest()
        {
            var deviceList = new List<AVDevice>(); // deviceList.Count = 0
            var expected = deviceList.Count + 1; // = 1
            using (var sw = new StringWriter())
            {
                //Имитация ввода пользователя
                Console.SetIn(new StringReader("Samsung\n1920x1080\n55\n499,99\n"));
                Console.SetOut(sw);
                MenuClass.addTelevision(deviceList); // deviceList.Count = 1
                //Проверка на добавление элемента в список
                Assert.AreEqual(expected, deviceList.Count);
                //Проверка на правильность класса нового объекта в списке
                Assert.IsInstanceOfType<Television>(deviceList[0]);
            }
        }
        //Проверка добавления объекта класса RadioReceiver в список
        [TestMethod]
        public void AddRadioTest()
        {
            var deviceList = new List<AVDevice>();
            var expected = deviceList.Count + 1;

            using (var sw = new StringWriter())
            {
                //Имитация ввода пользователя
                Console.SetIn(new StringReader("Sony\nRX-100\nFM\n199,99\n"));
                Console.SetOut(sw);
                MenuClass.addRadio(deviceList);
                //Проверка на добавление элемента в список
                Assert.AreEqual(expected, deviceList.Count);
                //Проверка на правильность класса нового объекта в списке
                Assert.IsInstanceOfType<RadioReceiver>(deviceList[0]);
            }
        }
        //Проверка вывода списка
        [TestMethod]
        public void PrintListTest()
        {
            var deviceList = new List<AVDevice>
            {
                new Television("LG", "1920x1080", 55f, 499.99),
                new RadioReceiver("Sony", "RX-100", "FM", 199.99)
            };

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                MenuClass.printList(deviceList);
                var result = sw.ToString().Trim();
                //Проверка на вывод соответствующих элементов в списке
                Assert.IsTrue(result.Contains("Телевизор:"));
                Assert.IsTrue(result.Contains("Радиоприемник:"));
            }
        }
    }
}
