using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialBrinnaGorena.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGet()
        {
            //Arrange
            CountriesController countriesController = new CountriesController();


            //Act
            var listaP = countriesController.GetCountries();

            //Assert
            Assert.IsNotNull(listaP);
        }
    }
}
