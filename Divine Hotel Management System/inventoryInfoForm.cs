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
    public partial class inventoryInfoForm : Form
    {
        public inventoryInfoForm()
        {
            InitializeComponent();
        }

        private void addNewInventoryB_Click(object sender, EventArgs e)
        {
            addInventoryForm addInventoryF = new addInventoryForm();
            addInventoryF.ShowDialog();
        }
    }
}
