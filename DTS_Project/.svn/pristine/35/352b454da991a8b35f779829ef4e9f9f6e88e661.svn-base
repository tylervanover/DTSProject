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
    /// Description: This is the form used to 
    /// represent the telephone. Accepts a dialed
    /// number.
    /// </summary>
    public partial class TelephoneDialog : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public TelephoneDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the number dialed as an array of strings.
        /// </summary>
        public string[] TelephoneNumber
        {
            get
            {
                string[] telephoneNumber = new string[3];
                telephoneNumber[0] = tbAreaCode.Text.Trim();
                telephoneNumber[1] = tbExchange.Text.Trim();
                telephoneNumber[2] = tbSubscriber.Text.Trim();
                return telephoneNumber;
            }
        }
    }
}
