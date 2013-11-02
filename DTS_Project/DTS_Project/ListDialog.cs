﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: A multipurpose list-box.
    /// Used to list calls, barred numbers, tenants, etc.
    /// </summary>
    public partial class ListDialog : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ListDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Populate the list area with string representations of objects.
        /// </summary>
        /// <param name="objects">The objects to add.</param>
        public void AddDisplayItems(object[] objects)
        {
            lbList.Items.AddRange(objects);
        }

        /// <summary>
        /// Remove all objects of the list area.
        /// </summary>
        public void ClearDisplayItems()
        {
            lbList.Items.Clear();
        }
    }
}
