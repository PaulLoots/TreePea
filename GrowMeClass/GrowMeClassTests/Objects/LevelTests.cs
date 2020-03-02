using Microsoft.VisualStudio.TestTools.UnitTesting;
using GrowMeClass.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrowMeClass.Objects.Tests
{
    [TestClass()]
    public class LevelTests
    {
        [TestMethod()]
        public void GetLevelFromXpTest()
        {
            //ARRANGE
            int xp = 1500;
            int expectedLevel = 1;

            //ACT
            var result = Level.GetLevelFromXp(xp);


            //ASSERT
            Assert.AreEqual(expectedLevel, result);
        }
    }
}