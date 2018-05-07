﻿using System;
using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class UiArguments_Test
    {
        [TestMethod]
        public void ValidArgs()
        {
            int expectedCrew = 2;
            int expectedImplant = 1;

            UiArguments args = new UiArguments(expectedCrew, expectedImplant);

            Assert.AreEqual(expectedCrew, args.CrewIndex,       "Crew index doesn't match");
            Assert.AreEqual(expectedImplant, args.ImplantIndex, "Implant doesn't match");
        }

        [TestMethod]
        public void NegativeCrew()
        {
            int expectedCrew = -1;
            int erroneousCrew = -2;

            UiArguments args = new UiArguments(erroneousCrew, 0);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Negative crew index OOR not correctly handled");
        }

        [TestMethod]
        public void OorCrew()
        {
            int expectedCrew = -1;
            int erroneousCrew = 5;

            UiArguments args = new UiArguments(erroneousCrew, 0);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "OOR crew index not correctly handled");
        }

        [TestMethod]
        public void NegativeImplant()
        {
            int expectedImplant = -1;
            int erroneousImplant = -2;

            UiArguments args = new UiArguments(0, erroneousImplant);

            Assert.AreEqual(expectedImplant, args.ImplantIndex, "Negative implant index not correctly handled");
        }

        [TestMethod]
        public void OorImplant()
        {
            int expectedImplant = -1;
            int erroneousImplant = 3;

            UiArguments args = new UiArguments(0, erroneousImplant);

            Assert.AreEqual(expectedImplant, args.ImplantIndex, "OOR implant index not correctly handled");
        }
    }
}