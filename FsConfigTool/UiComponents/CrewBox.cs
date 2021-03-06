﻿using FS_Config_Tool.Classes;
using System;
using System.Windows.Forms;

namespace FS_Config_Tool.UiComponents
{
    public partial class CrewBox : UserControl
    {
        public event EventHandler<CrewArgs> CrewMemberDoubleClicked;
        public event EventHandler<CrewImplantArgs> ImplantDoubleClicked;

        private PictureBox[] pictureBoxImplantArray;
        private int boxIndex = -1;

        public CrewBox()
        {
            InitializeComponent();

            pictureBoxImplantArray = new PictureBox[] { PictureBoxImplant0, PictureBoxImplant1, PictureBoxImplant2 };
        }

        public void SetBoxIndex(int index)
        {
            boxIndex = index;
        }

        private void CrewBox_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; index++)
            {
                pictureBoxImplantArray[index].Parent = PictureBoxCrew;
            }
        }

        public void DisplaySelectedCrew(TeamConfig.EnumeratedCrewMember crew)
        {
            PictureBoxCrew.Image = Utilities.GetCrewImageByIndex((int)crew.CrewID);

            for (int index = 0; index < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; index++)
            {
                pictureBoxImplantArray[index].Image = Utilities.GetImplantImageByIndex((int)crew.ImplantIDs[index]);
            }
        }

        /// <summary>
        /// Unit test method - checks whether the crewbox crew image has been set
        /// </summary>
        /// <returns>True if non-null, false if null</returns>
        public bool CheckDisplayedCrewImage()
        {
            return (PictureBoxCrew.Image != null);
        }

        /// <summary>
        /// Unit test method - checks whether the crewbox implant image has been set
        /// </summary>
        /// <param name="index">Implant index to check</param>
        /// <returns>True if non-null, false if null</returns>
        public bool CheckDisplayedImplantImage(int index)
        {
            return (pictureBoxImplantArray[index].Image != null);
        }

        /// <summary>
        /// Event handler for handling a crew double click - raises CrewMemberDoubleClicked
        /// to remove the crewmember assigned to this box
        /// </summary>
        /// <param name="sender">Object sending this - should be PictureBoxCrew</param>
        /// <param name="e">Mouse arguments (x, y and button)</param>
        private void PictureBoxCrew_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (CrewMemberDoubleClicked != null)
            {
                CrewArgs args = new CrewArgs(boxIndex);

                CrewMemberDoubleClicked(this, args);
            }
        }

        /// <summary>
        /// Event handler for handling a crew double click - raises ImplantDoubleClicked
        /// to remove the implant assigned to this box
        /// </summary>
        /// <param name="sender">Object sending this - should be PictureBoxImplant0</param>
        /// <param name="e">Mouse arguments (x, y and button)</param>
        private void PictureBoxImplant0_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ImplantDoubleClicked != null)
            {
                CrewImplantArgs args = new CrewImplantArgs(boxIndex, 0);

                ImplantDoubleClicked(this, args);
            }
        }

        /// <summary>
        /// Event handler for handling a crew double click - raises ImplantDoubleClicked
        /// to remove the implant assigned to this box
        /// </summary>
        /// <param name="sender">Object sending this - should be PictureBoxImplant1</param>
        /// <param name="e">Mouse arguments (x, y and button)</param>
        private void PictureBoxImplant1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ImplantDoubleClicked != null)
            {
                CrewImplantArgs args = new CrewImplantArgs(boxIndex, 1);

                ImplantDoubleClicked(this, args);
            }
        }

        /// <summary>
        /// Event handler for handling a crew double click - raises ImplantDoubleClicked
        /// to remove the implant assigned to this box
        /// </summary>
        /// <param name="sender">Object sending this - should be PictureBoxImplant2</param>
        /// <param name="e">Mouse arguments (x, y and button)</param>
        private void PictureBoxImplant2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ImplantDoubleClicked != null)
            {
                CrewImplantArgs args = new CrewImplantArgs(boxIndex, 2);

                ImplantDoubleClicked(this, args);
            }
        }
    }
}
