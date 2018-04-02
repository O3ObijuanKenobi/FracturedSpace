﻿using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Crew_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement.CrewParser_cs
{
    [TestClass]
    public class ParseCrewMembersFromLine
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        private void VerifyCrewsMatch(TeamConfig expected, TeamConfig actual)
        {
            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                Assert.AreEqual(expected.CrewMembers[crewIndex].CrewID, actual.CrewMembers[crewIndex].CrewID);

                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    Assert.AreEqual(expected.CrewMembers[crewIndex].ImplantIDs[implantIndex], actual.CrewMembers[crewIndex].ImplantIDs[implantIndex]);
                }
            }
        }

        [TestMethod]
        public void ParseRosterWithClaraOnlyNoImplants()
        {
            TeamConfig expected = ParsedData.ClaraOnlyNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.CLARA_ONLY_NO_IMPLANTS);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersNoImplants()
        {
            TeamConfig expected = ParsedData.BasicFiveMembersNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersAllImplants()
        {
            TeamConfig expected = ParsedData.FiveMembersFullImplantsOrdered();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_FULL_IMPLANTS_SCATTERED_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }
    }
}