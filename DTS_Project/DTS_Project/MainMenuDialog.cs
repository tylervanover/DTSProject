﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: The main menu for the administrator.
    /// Can perform various functions to update the system
    /// password, maintain tenants, etc.
    /// </summary>
    public partial class MainMenuDialog : Form
    {
        /// <summary>
        /// The terminal used by the DTS.
        /// </summary>
        private Terminal _terminal;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public MainMenuDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor. Calls the base.
        /// </summary>
        /// <param name="terminal">The DTS terminal.</param>
        public MainMenuDialog(Terminal terminal)
            : this()
        {
            //Needs a reference to the terminal in order to access methods.
            _terminal = terminal;
        }

        /// <summary>
        /// Add a tenant to the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTenant_Click(object sender, EventArgs e)
        {
            _terminal.Add();
        }

        /// <summary>
        /// Delete a tenant from the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteTenant_Click(object sender, EventArgs e)
        {
            _terminal.Delete();
        }

        /// <summary>
        /// List all the tenants on the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListTenants_Click(object sender, EventArgs e)
        {
            _terminal.List();
        }

        /// <summary>
        /// Do work on a tenant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWorkOn_Click(object sender, EventArgs e)
        {
            _terminal.WorkOn();
        }

        /// <summary>
        /// Change the system password.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            _terminal.ChangePassword();
        }

        /// <summary>
        /// Serialize the tenant list for storage.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            _terminal.Save();
        }

        /// <summary>
        /// Deserialize the tenant list for restoration.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            _terminal.Restore();
        }
    }
}
