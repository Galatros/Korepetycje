using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using SolidApi.Infrastructure;
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

        [TestCase("kotek, œwinka. pingwin! pingwin?")]
        [TestCase("kotek pingwin pingwin œwinka")]
        public async Task CountWordsInTextAsync_WhenSomeTextProvided_ThenItShoudCountWords(string text)
        {
            //arange
            var textProvider = new Mock<ITextProvider>();
            textProvider.Setup(tp => tp.GetTextAsync(It.IsNotNull<string>())).ReturnsAsync(text);
            fixture.Inject(textProvider);
            var sut = CreateSut();

            var resultHashtable = await sut.CountWordsInTextAsync(text).ConfigureAwait(false);
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


