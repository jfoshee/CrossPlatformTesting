using System;
using NUnit.Framework;
using StandardClassLibrary;

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
    }
}

