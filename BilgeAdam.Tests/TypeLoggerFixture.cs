using BilgeAdam.GenericPractice2.Helpers;
using BilgeAdam.Tests.Dummy;
using NUnit.Framework;

namespace BilgeAdam.Tests
{
    [TestFixture]
    public class TypeLoggerFixture
    {
        [Test]
        public void Can_Log_Any_Type()
        {
            RunTypeLoggerTest<Product>("BilgeAdam.Tests.Dummy.Product,Product,Class,");
            RunTypeLoggerTest<Category>("BilgeAdam.Tests.Dummy.Category,Category,Class,Abstract,ITestInterface,");
            RunTypeLoggerTest<ITestInterface>("BilgeAdam.Tests.Dummy.ITestInterface,ITestInterface,Interface,Abstract,");

        }

        private static void RunTypeLoggerTest<T>(string expection)
        {
            var helper = new TypeLogger();
            var result = helper.GetTypeProperties<T>();
            Assert.AreEqual(expection, result);
        }
    }
}