﻿using NUnit.Framework;
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
        [Test]
        public static void female_35_2_5()
        {
            expectedResult = 2.50f;
            float actualResult = insuranceService.CalcPremium(35, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void female_17_0()
        {
            expectedResult = 0f;
            float actualResult = insuranceService.CalcPremium(17, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void male_30_6()
        {
            expectedResult = 6.0f;
            float actualResult = insuranceService.CalcPremium(30, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void male_40_5()
        {
            expectedResult = 5.0f;
            float actualResult = insuranceService.CalcPremium(40, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public static void male_17_0()
        {
            expectedResult = 0f;
            float actualResult = insuranceService.CalcPremium(17, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        //Female over 50
        public static void female_55_0()
        {
            expectedResult = 0.375f;
            float actualResult = insuranceService.CalcPremium(55, "female");

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        //Male over 50
        public static void male_55_0()
        {
            expectedResult = 0.75f;
            float actualResult = insuranceService.CalcPremium(55, "male");

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}