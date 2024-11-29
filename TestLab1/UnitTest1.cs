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
            var expected = "�����: Sony\n����: 999,99";
            //������ � ���������� ����������, ���������� � �������
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                device.Print();
                var result = sw.ToString();
                //� ��������� � ��������� �����������
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
            var expected = "\n�������������:\n�����: Sony\n������: RX-100\n����� ������: FM\n����: 199,99";
            //������ � ���������� ����������, ���������� � �������
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                receiver.Print();
                var result = sw.ToString();
                //� ��������� � ��������� �����������
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
            var expected = "���������:\n�����: LG\n���������� ������: 1920x1080\n������ ����������: 55,5\n����: 499,99";
            //������ � ���������� ����������, ���������� � �������
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                television.Print();
                var result = sw.ToString();
                //� ��������� � ��������� �����������
                Assert.AreEqual(expected.Trim(), result.Trim());
            }
        }
    }

    [TestClass]
    public class MenuClassTests
    {
        //�������� ���������� ������� ������ ��������� � ������
        [TestMethod]
        public void AddTelevisionTest()
        {
            var deviceList = new List<AVDevice>(); // deviceList.Count = 0
            var expected = deviceList.Count + 1; // = 1
            using (var sw = new StringWriter())
            {
                //�������� ����� ������������
                Console.SetIn(new StringReader("Samsung\n1920x1080\n55\n499,99\n"));
                Console.SetOut(sw);
                MenuClass.addTelevision(deviceList); // deviceList.Count = 1
                //�������� �� ���������� �������� � ������
                Assert.AreEqual(expected, deviceList.Count);
                //�������� �� ������������ ������ ������ ������� � ������
                Assert.IsInstanceOfType<Television>(deviceList[0]);
            }
        }
        //�������� ���������� ������� ������ RadioReceiver � ������
        [TestMethod]
        public void AddRadioTest()
        {
            var deviceList = new List<AVDevice>();
            var expected = deviceList.Count + 1;

            using (var sw = new StringWriter())
            {
                //�������� ����� ������������
                Console.SetIn(new StringReader("Sony\nRX-100\nFM\n199,99\n"));
                Console.SetOut(sw);
                MenuClass.addRadio(deviceList);
                //�������� �� ���������� �������� � ������
                Assert.AreEqual(expected, deviceList.Count);
                //�������� �� ������������ ������ ������ ������� � ������
                Assert.IsInstanceOfType<RadioReceiver>(deviceList[0]);
            }
        }
        //�������� ������ ������
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
                //�������� �� ����� ��������������� ��������� � ������
                Assert.IsTrue(result.Contains("���������:"));
                Assert.IsTrue(result.Contains("�������������:"));
            }
        }
    }
}
