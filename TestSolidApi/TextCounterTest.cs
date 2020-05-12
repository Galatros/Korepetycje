using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using SolidApi.Logic.TextAdministrator;
using SolidApi.Logic.TextAdministrator.Interfaces;
using System.Collections;
using System.Threading.Tasks;

namespace TestSolidApi
{
    public class Tests
    {
        IFixture fixture;

        [SetUp]
        public void Setup()
        {
            fixture = new Fixture().Customize(new AutoMoqCustomization());
        }

        //system under tests
        private TextCounter CreateSut()
        {
            return fixture.Create<TextCounter>();
        }

       
        [TestCase(new object[] {"pingwin","pingwin","kaczka"})]
        public async Task CountWordsInTextAsync_WhenTabOfWordsProvided_ThenItShoudCountWords(params string[] text)
        {
            //arange
            var wordsProvider = new Mock<IWordsProvider>();
            wordsProvider.Setup(tp => tp.GetWordsAsync(It.IsNotNull<string>())).ReturnsAsync(text);
            fixture.Inject(wordsProvider);
            var sut = CreateSut();

            var resultHashtable = await sut.CountWordsInTextAsync("nic").ConfigureAwait(false); //CO DAÆ TU JAKO PARAMETR?
            //act
            //Assert.AreEqual(2, resultHashtable["pingwin"]); //dobrze
            resultHashtable["pingwin"].Should().Be(2);//taki sam efekt
            //assert
        }

        //[TestCase("https://wolnelektury.pl/media/book/txt/calineczka.txt")]
        //[Test]
        //public async Task DowlandPageContent(string path) //Tego nie mo¿na traktowaæ jako test jednostkowy
        //{
        //    var result = await textCounter.GetDataFromWebPage(path);
        //    Assert.IsNotNull(result);

        //}
    }
}


