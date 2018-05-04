﻿using FS_Crew_Config_Tool.Classes;
using System;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class CrewSetBox : UserControl
    {
        public event EventHandler<int> CrewMemberDoubleClicked;
        public event EventHandler<UiArguments> ImplantDoubleClicked;

        private CrewBox[] crewBoxArray;

        public CrewSetBox()
        {
            InitializeComponent();

            crewBoxArray = new CrewBox[] { CrewBox0, CrewBox1, CrewBox2, CrewBox3, CrewBox4 };

            for (int index = 0; index < 5; index++)
            {
                crewBoxArray[index].SetBoxIndex(index);
                crewBoxArray[index].CrewMemberDoubleClicked += RemoveClickedCrewMember;
                crewBoxArray[index].ImplantDoubleClicked += RemoveClickedImplant;
            }
        }

        public void RemoveClickedCrewMember(object sender, int selectedIndex)
        {
            if (CrewMemberDoubleClicked != null)
            {
                CrewMemberDoubleClicked(this, selectedIndex);
            }
        }

        public void RemoveClickedImplant(object sender, UiArguments args)
        {
            if (ImplantDoubleClicked != null)
            {
                ImplantDoubleClicked(this, args);
            }
        }

        public void ClearDisplayedTeam(CrewSetBox parent)
        {
            // Using freshly initialised config, as it will be set to zero
            TeamConfig blankConfig = new TeamConfig();

            DisplaySelectedTeam(blankConfig, parent);
        }

        public void DisplaySelectedTeam(TeamConfig team, CrewSetBox parent)
        {
            for (int index = 0; index < 5; index++)
            {
                crewBoxArray[index].Parent = parent;
                crewBoxArray[index].DisplaySelectedCrew(team.CrewMembers[index]);
            }
        }

        /// <summary>
        /// Helper method intended for unit-testing. Checks an indexed crewbox for an image
        /// </summary>
        /// <param name="index">CrewBox array index to check</param>
        /// <param name="expectingImage">Bool flag, affects return val</param>
        /// <returns>If eI is true, returns true if image not null. If eI is false, returns false</returns>
        public bool CheckCrewImageState(int index, bool expectingImage)
        {
             return crewBoxArray[index].CheckDisplayedCrewImage();
        }
    }
}
