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
    /// Description: The Domestic Telephone System. Creates
    /// a terminal and a telephone for access by the administrator
    /// and tenant(s), respectively.
    /// </summary>
    public partial class DTS : Form
    {
        /// <summary>
        /// The Domestic Telephone System's terminal.
        /// </summary>
        private Terminal _terminal;
        /// <summary>
        /// The Domestic Telephone Sytem's telephone.
        /// </summary>
        private Telephone _telephone;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public DTS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form load initialization.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DTS_Load(object sender, EventArgs e)
        {
            _terminal = new Terminal();
            _telephone = new Telephone();
        }

        /// <summary>
        /// When the user clicks on the terminal button, activate the terminal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminal_Click(object sender, EventArgs e)
        {
            _terminal.Activate();
        }

        /// <summary>
        /// When the user clicks on the telephone button, activate the telephone.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTelephone_Click(object sender, EventArgs e)
        {
            //The telephone needs a reference to the terminal for
            //tenant information (call logs; barred lists)
            _telephone.Activate(ref _terminal);
        }

        /// <summary>
        /// When the user clicks on the quit button, exit.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
