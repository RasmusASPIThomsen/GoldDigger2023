﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Repository;
using IO;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ClassRegEX regex = new ClassRegEX();

        // TestContext er VIGTIG! Og skal skrives med stort T, ellers kan DataSource ikke finde dataen
        private TestContext _testContext;
        public TestContext TestContext
        {
            get { return _testContext; }
            set { _testContext = value; }
        }
        //[TestMethod]
        //[DataSource("System.Data.SqlClient", @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=DDUT2022; Integrated Security=True", "RandomCalc", DataAccessMethod.Sequential)]
        //public void TestMethod1()
        //{
        //    // Arrange
        //    decimal tal1 = 10M;
        //    // Vælger data fra kolonnen tal2 som string
        //    decimal tal2 = 10M;
        //    decimal res;
        //    decimal expected = 20M;

        //    // Act
        //    res = tal1 + tal2;

        //    // Assert
        //    Assert.AreEqual(expected, res, 0.0001M);
        //}
        // Udregning af valutakurser
        [TestMethod]
        public void ValutaKurserUdregningDKK()
        {
            // Arrange
            decimal DKK = 67.8m;
            decimal USD = 10m;
            decimal rate = 6.784619000000m;

            //Act
            decimal res = USD * rate;
            //Assert
            Assert.AreEqual(res, DKK, 0.000001m);
        }
        [TestMethod]
        public void ValutaKurserUdregningEUR()
        {
            // Arrange
            decimal DKK = 67.8m;
            decimal USD = 10m;
            decimal rate = 0.910301000000m;

            //Act
            decimal res = USD * rate;
            //Assert
            Assert.AreEqual(res, DKK, 0.000001m);
        }
        // Udregning af samlet pris
        //[TestMethod]
        //public void SamletPrisFaktura()
        //{
        //    // Arrange
        //    //Act
        //    //Assert
        //}
        // Mail validering
        //[TestMethod]
        //[DataSource("System.Data.SqlClient", @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=DDUT2022; Integrated Security=True", "EmailMixValidAndInvalid", DataAccessMethod.Sequential)]
        //public void ValideringAfMailadresse()
        //{
        //    //Arrange
        //    string Email = TestContext.DataRow["Email"].ToString();
        //    bool exp = Convert.ToBoolean(TestContext.DataRow["Valid"]);

        //    //Act
        //    bool res = regex.IsMailAddress(Email);
        //    //Assert
        //    Assert.AreEqual(exp, res);
        //}
    }
}