using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StandardClassLibrary;

namespace MonoDevelopTesting
{
    [TestClass]
    public class WidgetTest
    {
        [TestMethod]
        public void FluentTest()
        {
            var subject = new Widget();
            subject.Should().NotBeNull();
        }
    }
}

