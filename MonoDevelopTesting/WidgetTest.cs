using NUnit.Framework;
using StandardClassLibrary;
using FluentAssertions;

namespace MonoDevelopTesting
{
    [TestFixture]
    public class WidgetTest
    {
        [Test]
        public void DefaultConstruction()
        {
            var subject = new Widget();
        }

        [Test]
        public void FluentTest()
        {
            var subject = new Widget();
            subject.Should().NotBeNull();
        }
    }
}

