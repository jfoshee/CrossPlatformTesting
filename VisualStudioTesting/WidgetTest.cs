using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StandardClassLibrary;

namespace VisualStudioTesting
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
