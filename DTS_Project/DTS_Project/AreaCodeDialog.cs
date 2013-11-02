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
    /// Description: Class representing the form
    /// of AreaCodeDialog. For entry of an area
    /// code.
    /// </summary>
    public partial class AreaCodeDialog : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AreaCodeDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the area code entered into the form.
        /// </summary>
        public string AreaCode
        {
            get
            {
                return tbAreaCode.Text.Trim();
            }
        }
    }
}
