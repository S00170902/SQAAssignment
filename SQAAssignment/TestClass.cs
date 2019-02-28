using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQAAssignment
{
    [TestFixture]
    public class TestClass
    {
        static float expectedResult;
        static InsuranceService insuranceService;

        [SetUp]
        public static void init()
        {
            insuranceService = new InsuranceService();
        }

        [Test]
        public static void female_25_5()
        {
            expectedResult = 5f;
            float actualResult = insuranceService.CalcPremium(25, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}