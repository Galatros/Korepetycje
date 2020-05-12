using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using NUnit.Framework;
using SolidApi.Logic.TextAdministrator;
using System.Linq;

namespace TestSolidApi
{
    class WordsSplitterTest
    {
        IFixture fixture;

        [SetUp]
        public void SetUp()
        {
            fixture = new Fixture().Customize(new AutoMoqCustomization());
        }

        private WordsSplitter CreateSut()
        {
            return fixture.Create<WordsSplitter>();
        }

        [TestCase("kotek, świnka. pingwin! pingwin?")]
        [TestCase("kotek pingwin pingwin świnka")]
        public void SplitWordsInString_WhenTextInStringProvided_ThenItShouldSplitWordsInString(string text)
        {
            var sut = CreateSut();
            var result = sut.SplitWordsInString(text);
            result.Count().Should().Be(4);
        }

    }
}
