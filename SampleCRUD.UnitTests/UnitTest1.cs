using SampleCRUD.Interfaces;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;

namespace SampleCRUD.UnitTests
{
    [TestFixture]
    public class Tests
    {
        private IDocumentProcessor _processor;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDocumentProcessor, DocumnetProcessor>();

            var provider = services.BuildServiceProvider();
            _processor = provider.GetService<IDocumentProcessor>();
        }

        [Test]
        public void Test1()
        {
            _processor.Analyze("A string is very useful reference type. so we can used in our application widely.");
            Assert.Pass();
            }
        [Test]
        public void Test2()
        {
            CodingQuestions codingQuestions = new CodingQuestions();
            string actual=codingQuestions.ReverseString("Hello World");
            Assert.That(actual, Is.EqualTo("dlroW olleH"));
     
        }
        [Test]
         public void Test3()
        {
            CodingQuestions codingQuestions = new CodingQuestions();
            int actual = codingQuestions.SecondAray();
            Assert.That(actual, Is.EqualTo(35));
        }

        }
}
