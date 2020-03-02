using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrowMeClass.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrowMeClass.Objects.Tests
{
    [TestClass()]
    public class PlantTests
    {

        [TestMethod()]
        public void giveWaterTest()
        {
            //ARANGE
            Plant plant = new Plant();
            int Xp = plant.Xp;
            int expected = Xp + 500;
            
            //ACT
            plant.giveWater();

            //ASSERT
            Assert.AreEqual(expected, Xp);
        }
    }
}