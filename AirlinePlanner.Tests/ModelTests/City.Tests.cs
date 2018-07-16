using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using AirlinePlanner.Models;

namespace AirlinePlanner.Tests
{
    [TestClass]
    public class CityTest : IDisposable
    {
        public void Dispose()
        {
            //City.DeleteAll();
        }

        public CityTest()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=airline_planner_test;";
        }

        [TestMethod]
        public void SetGetProperties_SetsGetsProperties_True()
        {
            City city = new City("PDX");
            city.AirportCode = "SEA";
            city.Id = 2;
            Assert.AreEqual("SEA", city.AirportCode);
            Assert.AreEqual(2, city.Id);
        }
    }
}