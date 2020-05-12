using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using SolidApi.Logic.TextAdministrator;
using SolidApi.Logic.TextAdministrator.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace TestSolidApi
{
    class HttpWordsProviderTest
    {
        IFixture fixture;

        [SetUp]
        public void SetUp()
        {
            fixture = new Fixture().Customize(new AutoMoqCustomization());
        }

        private HttpWordsProvider CreateSut()
        {
            return fixture.Create<HttpWordsProvider>();
        }

        [Test]
        public async Task GetWordsAsync_WhenSomeTextProvided_ThenItShouldReturnTabOfWords()
        {
            var textProvider = new Mock<ITextProvider>();
            textProvider.Setup(tp => tp.GetTextAsync(It.IsNotNull<string>())).ReturnsAsync("cos");
            fixture.Inject(textProvider);

            var spliter = fixture.Freeze<Mock<IWordsSplitter>>();
            spliter.Setup(s => s.SplitWordsInString(It.IsNotNull<string>())).Returns(new[] { "woda", "ogien" });

            spliter.Verify(s => s.SplitWordsInString(It.IsNotNull<string>()), Times.Once);

            var sut = CreateSut();

            var result = await sut.GetWordsAsync("nic").ConfigureAwait(false);
            var count = result.Count();
            result.Any();
            count.Should().Be(2);

        }
    }
}
