using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using StandardClassLibrary;

namespace VisualStudioTesting
{
    [TestClass]
    public class WidgetTest
    {
        [TestMethod]
        public void DefaultConstruction()
        {
            var subject = new Widget();
        }

        [TestMethod]
        public void FluentTest()
        {
            var subject = new Widget();
            subject.Should().NotBeNull();
        }
    }
}
