﻿using FS_Config_Tool.Classes.Listings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Config_Tool.UiComponents
{
    public partial class ShipSelector : Form
    {
        /// <summary>
        /// Stores state of checkboxes for adding new ships. Public get is intended for unit tests only
        /// </summary>
        public CheckBox[] CheckBoxArray { get; private set; }

        public event EventHandler<ShipArgs> GenerateButtonClicked;

        public ShipSelector()
        {
            InitializeComponent();
            AddCheckBoxes();
        }

        private void AddCheckBoxes()
        {
            Point startingPoint = new Point(40, 50);
            Point shiftingPoint = startingPoint;

            CheckBoxArray = new CheckBox[(int)ShipEnum.END_OF_LIST];

            for (int index = 0; index < (int)ShipEnum.END_OF_LIST; index++)
            {
                if (index == (int)ShipEnum.ENDEAVOUR || index == (int)ShipEnum.INTERCEPTOR || index == (int)ShipEnum.RANGER)
                {
                    shiftingPoint.X += 110;
                    shiftingPoint.Y = startingPoint.Y;
                }

                CheckBox checkBox = new CheckBox();
                checkBox.Name = "CheckBox" + ShipList.ShipListing[index].ID;
                checkBox.Text = ShipList.ShipListing[index].Name;

                checkBox.Location = shiftingPoint;

                shiftingPoint.Y += 20;

                Controls.Add(checkBox);
                CheckBoxArray[index] = checkBox;
            }
        }

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            bool markAsChecked = (clickedButton.Name.Equals(ButtonSelectAll.Name));

            for (int index = 0; index < (int)ShipEnum.END_OF_LIST; index++)
            {
                CheckBoxArray[index].Checked = markAsChecked;
            }
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            if (GenerateButtonClicked != null)
            {
                ShipArgs args = new ShipArgs(CheckBoxArray);

                GenerateButtonClicked(this, args);
            }

            Close();
        }
    }
}
