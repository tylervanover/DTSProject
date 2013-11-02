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
    /// of LocateTenantDialog. By entering the first
    /// and last names of a tenant, the system will then
    /// retrieve the tenant if they exist within the 
    /// active tenants list. 
    /// </summary>
    public partial class LocateTenantDialog : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public LocateTenantDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the first name entered in the form.
        /// </summary>
        public string FirstName
        {
            get
            {
                return tbFirst.Text.Trim();
            }
        }

        /// <summary>
        /// Returns the last name entered in the form.
        /// </summary>
        public string LastName
        {
            get
            {
                return tbLast.Text.Trim();
            }
        }
    }
}
