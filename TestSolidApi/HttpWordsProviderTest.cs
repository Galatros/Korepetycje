using AutoFixture;
using AutoFixture.AutoMoq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using SolidApi.Infrastructure;
using Moq;
using System.Threading.Tasks;
using FluentAssertions;

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

        [TestCase("kaczka; pingwin? dziobak, dziobak!")]
        public async Task GetWordsAsync_WhenSomeTextProvided_ThenItShouldReturnTabOfWords(string text)
        {
            var textProvider = new Mock<ITextProvider>();
            textProvider.Setup(tp => tp.GetTextAsync(It.IsNotNull<string>())).ReturnsAsync(text);
            fixture.Inject(textProvider);

         

            var sut = CreateSut();

            var result = await sut.GetWordsAsync("nic").ConfigureAwait(false);

            result.Length.Should().Be(4);

        }
    }
}
