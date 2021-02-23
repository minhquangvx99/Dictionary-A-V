using NUnit.Framework;
using Dicionary
using RentalBikeApp.Data.ServiceAgents.BikeServices;
using RentalBikeApp.Entities.SQLEntities;
using System.Collections.Generic;

namespace DictionaryTest
{
    public class Tests
    {
        [TestFixture]
        class SearchTest
        {

            [SetUp]
            public void Setup()
            {
                search = new Search();
            }

            /// <summary>
            /// Test for case get bike with correct QR Code
            /// </summary>
            [Test]
            public void GetBikeByQRCodeTest()
            {
                Bike bike = bikeService.GetBikeByQRCode("000000001");
                Assert.IsTrue(bike is Bike);
            }
        }
}