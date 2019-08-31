using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Entities
{
    [TestClass]
    public class StudentTest
    {

        [TestMethod]
        public void TestMethod1()
        {
            var subscription = new Subscription(null);
            var student = new Student ("Kainã", "Almeida","12345678912","kainafa@hotmail.com");
            student.AddSubscription(subscription);


        }

    }
}
