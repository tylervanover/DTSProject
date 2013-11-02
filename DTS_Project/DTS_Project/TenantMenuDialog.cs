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
    /// Description: Tenant level operations for the
    /// administrator. 
    /// </summary>
    public partial class TenantMenuDialog : Form
    {
        /// <summary>
        /// The tenant that will be worked upon.
        /// </summary>
        private Tenant _tenant;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public TenantMenuDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor. 
        /// </summary>
        /// <param name="tenant">A tenant to work upon.</param>
        public TenantMenuDialog(ref Tenant tenant)
            :this()
        {
            _tenant = tenant;
        }

        /// <summary>
        /// Bar a particular area code to the working tenant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarAreaCode_Click(object sender, EventArgs e)
        {
            AreaCodeDialog areaCodeDiag = new AreaCodeDialog();
            string[] number = new string[3];
            if (areaCodeDiag.ShowDialog() == DialogResult.OK)
            {
                number[0] = areaCodeDiag.AreaCode;
                _tenant.MakeBarred(new BarArea(new Number(number)));
            }
        }

        /// <summary>
        /// Bar a particular number to the working tenant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBarNumber_Click(object sender, EventArgs e)
        {
            TelephoneDialog telly = new TelephoneDialog();
            if (telly.ShowDialog() == DialogResult.OK)
            {
                _tenant.MakeBarred(new BarFullNumber(new Number(telly.TelephoneNumber)));
            }
        }

        /// <summary>
        /// Unbar a particular area code to the working tenant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnbarArea_Click(object sender, EventArgs e)
        {
            AreaCodeDialog areaCodeDiag = new AreaCodeDialog();
            string [] number = new string[3];
            if (areaCodeDiag.ShowDialog() == DialogResult.OK)
            {
                number[0] = areaCodeDiag.AreaCode;
                _tenant.Unbar(new Number(number));
            }
        }

        /// <summary>
        /// Unbar a particular number to the working tenant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnbarNumber_Click(object sender, EventArgs e)
        {
            TelephoneDialog telly = new TelephoneDialog();
            if (telly.ShowDialog() == DialogResult.OK)
            {
                _tenant.Unbar(new Number(telly.TelephoneNumber));
            }
        }

        /// <summary>
        /// List all of a tenant's barred numbers.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListBar_Click(object sender, EventArgs e)
        {
            _tenant.ListBarred();
        }

        /// <summary>
        /// List all of a tenant's placed calls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListCalls_Click(object sender, EventArgs e)
        {
            _tenant.ListCalls();
        }

        /// <summary>
        /// Clear a tenant's call log.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearCalls_Click(object sender, EventArgs e)
        {
            _tenant.ClearCallLog();
        }
    }
}
