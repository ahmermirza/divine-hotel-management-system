﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divine_Hotel_Management_System
{
    public partial class addRoomForm : Form
    {
        public addRoomForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(addRoomNumCB.SelectedIndex == -1 || addRoomTypeCB.SelectedIndex == -1 || addFloorNumCB.SelectedIndex == -1 || addBedsNumCB.SelectedIndex == -1 || addRoomChargesTB.Text == "Enter Room Charges Here")
            {
                MessageBox.Show("Please fill in the missing field(s) to add a new room!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(addRoomNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addRoomTypeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Room Type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addFloorNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Floor Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addBedsNumCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Number of Beds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addRoomChargesTB.Text == "Enter Room Price Here")
            {
                MessageBox.Show("Please enter the room's charges!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRoomNumCB_TextChanged(object sender, EventArgs e)
        {
            addRoomNumCB.ForeColor = Color.Black;
        }

        private void addRoomTypeCB_TextChanged(object sender, EventArgs e)
        {
            addRoomTypeCB.ForeColor = Color.Black;
        }

        private void addFloorNumCB_TextChanged(object sender, EventArgs e)
        {
            addFloorNumCB.ForeColor = Color.Black;
        }

        private void addBedsNumCB_TextChanged(object sender, EventArgs e)
        {
            addBedsNumCB.ForeColor = Color.Black;
        }

        private void addRoomPriceTB_Enter(object sender, EventArgs e)
        {
            if(addRoomChargesTB.Text == "Enter Room Charges Here")
            {
                addRoomChargesTB.Text = "";
                addRoomChargesTB.ForeColor = Color.Black;
            }
        }

        private void addRoomPriceTB_Leave(object sender, EventArgs e)
        {
            if (addRoomChargesTB.Text == "")
            {
                addRoomChargesTB.Text = "Enter Room Charges Here";
                addRoomChargesTB.ForeColor = Color.Gray;
            }
        }

        private void addRoomPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;
            if (!Char.IsNumber(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("This field cannot contain letters or special characters. Please enter room's charges!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resetAddRoomB_Click(object sender, EventArgs e)
        {
            addRoomNumCB.Text = "Select Room Number";
            addRoomNumCB.ForeColor = Color.Gray;
            addRoomTypeCB.Text = "Select Room Type";
            addRoomTypeCB.ForeColor = Color.Gray;
            addFloorNumCB.Text = "Select Floor Number";
            addFloorNumCB.ForeColor = Color.Gray;
            addBedsNumCB.Text = "Select Number of Beds";
            addBedsNumCB.ForeColor = Color.Gray;
            addRoomChargesTB.Text = "Enter Room Charges Here";
            addRoomChargesTB.ForeColor = Color.Gray;
        }
    }
}
