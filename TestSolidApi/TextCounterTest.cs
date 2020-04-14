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

        [TestCase("kotek, �winka. pingwin! pingwin?")]
        [TestCase("kotek pingwin pingwin �winka")]
        [Test]
        public void CountExampleWordsInExampleString(string text)
        {         
            Hashtable resultHashtable = textCounter.CountWordsInString(text);
            Assert.AreEqual(2, resultHashtable["pingwin"]);
        }

        [TestCase("https://wolnelektury.pl/media/book/txt/calineczka.txt")]
        [Test]
        public async Task DowlandPageContent(string path) //Tego nie mo�na traktowa� jako test jednostkowy
        {
            var result = await textCounter.GetDataFromWebPage(path);
            Assert.IsNotNull(result);

        }
    }
}


