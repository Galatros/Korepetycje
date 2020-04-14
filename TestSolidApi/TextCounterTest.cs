using NUnit.Framework;
using SolidApi.Infrastructure;
using System.Collections;
using System.Threading.Tasks;

namespace TestSolidApi
{
    public class Tests
    {
        TextCounter textCounter;
        [SetUp]
        public void Setup()
        {
        textCounter = new TextCounter();
        }

        [TestCase("kotek, œwinka. pingwin! pingwin?")]
        [TestCase("kotek pingwin pingwin œwinka")]
        [Test]
        public void CountExampleWordsInExampleString(string text)
        {         
            Hashtable resultHashtable = textCounter.CountWordsInString(text);
            Assert.AreEqual(2, resultHashtable["pingwin"]);
        }

        [TestCase("https://wolnelektury.pl/media/book/txt/calineczka.txt")]
        [Test]
        public async Task DowlandPageContent(string path) //Tego nie mo¿na traktowaæ jako test jednostkowy
        {
            var result = await textCounter.GetDataFromWebPage(path);
            Assert.IsNotNull(result);

        }
    }
}


