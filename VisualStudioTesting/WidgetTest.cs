using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}
