using Tyuiu.FedotkinNE.Sprint1.Task6.V3.Lib;
namespace Tyuiu.FedotkinNE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LastLetterWord_Test1()
        {
            DataService service = new DataService();
            string text = "Это пример текста";
            string expected = "ора";
            string actual = service.LastLetterWord(text);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LastLetterWord_Test2()
        {
            DataService service = new DataService();
            string text = "Ещё один текст";
            string expected = "ёнт";
            string actual = service.LastLetterWord(text);
            Assert.AreEqual(expected, actual);
        }
    }
}