using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrowMeClass.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrowMeClass.Objects.Tests
{
    [TestClass()]
    public class PlantStatesTests
    {
        [TestMethod()]
        public void GetPlantStateTest()
        {
            //ARRANGE
            var plantState = new PlantStates();
            PlantState plant = PlantState.healthy;
            var expectedResult = "healthy";

            //ACT
            PlantState result = plantState.GetPlantState(expectedResult);

            //ASSERT
            Assert.AreEqual(expectedResult, result);
        }
    }
}