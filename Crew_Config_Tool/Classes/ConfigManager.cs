﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FS_Crew_Config_Tool
{
    public class ConfigManager
    {
        private const string FS_PATH = "..\\Local\\spacegame\\Saved\\Config\\WindowsNoEditor\\GameUserSettings.ini";
        private string completePath = string.Empty;

        private const string CREW_TEAMS_FLAG = "CrewTeams=";

        /// <summary>
        /// Stores first chunk of config e.g. core game settings, ship skin and loadout setups
        /// </summary>
        private List<string> SegmentStart = new List<string>();

        /// <summary>
        /// Stores third chunk of config - ReadItems list and other miscellaneous config items
        /// </summary>
        private List<string> SegmentEnd = new List<string>();

        /// <summary>
        /// Stores raw line data and crew names
        /// </summary>
        public List<RawLinePlusCrewName> CrewData = new List<RawLinePlusCrewName>();

        public struct RawLinePlusCrewName
        {
            public string RawLine;
            public string CrewName;

            public void GetCrewName()
            {
                Match nameTag = Regex.Match(RawLine, "Name=\"");
                Match endOfName = Regex.Match(RawLine, "\",Icon");

                int nameStartIndex = nameTag.Index + nameTag.Length;
                int nameEndIndex = endOfName.Index;

                int length = nameEndIndex - nameStartIndex;

                CrewName = RawLine.Substring(nameStartIndex, length);
            }
        }

        public void LoadConfig()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            completePath = Path.Combine(appDataDir, FS_PATH);

            string[] fullConfig = File.ReadAllLines(completePath);

            ParseIntoSegments(fullConfig);
        }

        private void ParseIntoSegments(string[] config)
        {
            int lineNumber = 0;

            bool keepParsing = true;

            // Step 1 - parse each line into SegmentOne until we reach a line containing "CrewTeams"
            while (keepParsing)
            {
                if (config[lineNumber].Contains(CREW_TEAMS_FLAG))
                {
                    // We've hit the crew member section, exit loop
                    keepParsing = false;
                }
                else
                {
                    // Add line to the first segment
                    SegmentStart.Add(config[lineNumber]);
                    lineNumber++;
                }
            }

            // Step 2 - parse each line into SegmentTwo until we add all "CrewTeams" lines
            keepParsing = true;
            while (keepParsing)
            {
                if (config[lineNumber].Contains(CREW_TEAMS_FLAG))
                {
                    RawLinePlusCrewName line = new RawLinePlusCrewName();
                    line.RawLine = config[lineNumber];
                    line.GetCrewName();

                    CrewData.Add(line);

                    lineNumber++;
                }
                else
                {
                    // We've hit the end crew member section, exit loop
                    keepParsing = false;
                }
            }

            // Step 3 - parse remaining lines into SegmentThree
            int lineCount = config.Length - 1;
            // Starting value is blank, as we want to use lineNumbers current value
            for (; lineNumber <= lineCount; lineNumber++)
            {
                SegmentEnd.Add(config[lineNumber]);
            }
        }

        public void SortAlphabetically()
        {
            for (int iteration = 0; iteration < CrewData.Count - 1; iteration++)
            {
                for (int index = 0; index < CrewData.Count - 1; index++)
                {
                    /* Return values of String.Compare
                     *
                     * 1  - parameter 1 is alphabetically behind 2
                     * 0  - parameter 1 = 2
                     * -1 - parameter 1 is alphabetically ahead of 2
                    */

                    if (1 == String.Compare(CrewData[index].CrewName, CrewData[index + 1].CrewName))
                    {
                        RawLinePlusCrewName temp = CrewData[index];
                        CrewData[index] = CrewData[index + 1];
                        CrewData[index + 1] = temp;
                    }
                }
            }
        }
    }
}
