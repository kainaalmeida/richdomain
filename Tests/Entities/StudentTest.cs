using Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Entities
{
    [TestClass]
    public class StudentTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var name = new Name("teste", "teste");
            foreach (var notification in name.Notifications)
            {
                var msg = notification.Message;
            }
        }

    }
}
