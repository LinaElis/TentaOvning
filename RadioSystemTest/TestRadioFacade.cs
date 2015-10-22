using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadioSystemTest
{
    [TestClass]
    public class TestRadioFacade
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            RadioFacade facade = new RadioFacade();

            Assert.IsNotNull(facade);
        }

        //För att testet ska gå igenom nu, byt ut NotImplementedException -> NullReferenceException

        //[TestMethod]
        //[ExpectedException(typeof(NotImplementedException))]
        //public void Test_That_MixMegapol_Generates_Exception()
        //{
        //    RadioFacade facade = new RadioFacade();

        //    facade.PlayMusic("MixMegapol");
        //}

        [TestMethod]
        public void Test_That_RixFM_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();

            facade.PlayMusic("RixFM");

            Assert.IsTrue(facade.IsPlaying);
        }

        [TestMethod]
        public void Test_That_P3_Can_Be_Played()
        {
            RadioFacade facade = new RadioFacade();

            facade.PlayMusic("P3");

            Assert.IsTrue(facade.IsPlaying);
        }
    }
}
