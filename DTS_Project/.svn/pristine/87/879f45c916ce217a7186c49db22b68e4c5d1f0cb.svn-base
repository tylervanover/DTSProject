using System;
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
    /// of PasswordDialog. Accepts entry of a password
    /// from the system administrator. Also used to update
    /// the system's password.
    /// </summary>
    public partial class PasswordDialog : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public PasswordDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the password entered into the form.
        /// </summary>
        public string Password
        {
            get
            {
                return tbPass.Text.Trim();
            }
        }

        /// <summary>
        /// Small method to help clean up during the terminal
        /// log-on process. 
        /// </summary>
        public void Clean()
        {
            tbPass.Text = "";
        }
    }
}
