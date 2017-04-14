using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.Library;

namespace ACM.Library.Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ConvetToTitleCaseTest()
        {
            // Arrage
            var source = "The return of the king";
            var expected = "The Return Of The King";

            //Act
            ///var result = StringExtensions.ConvertToTitleCase(source);
            //usando extention method - a chamada StringExtensions.ConvertToTitleCase(source); nao deixa de funcionar.
            var result = source.ConvertToTitleCase();
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }
    }
}
