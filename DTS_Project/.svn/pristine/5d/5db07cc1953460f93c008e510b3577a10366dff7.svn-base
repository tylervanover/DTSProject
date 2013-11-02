using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: The telephone is used by the 
    /// tenant. Each tenant must enter their access code before
    /// given use of the telephone. After it has been determined
    /// they are a valid user, the system will prompt them
    /// for a telephone number, make sure the number isn't barred, and
    /// then proceed to log the call.
    /// </summary>
    public class Telephone
    {
        /// <summary>
        /// Tenant that is currently using the telephone.
        /// </summary>
        private Tenant _workingTenant;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Telephone()
        {
        }

        /// <summary>
        /// Activate the telephone. Use the parameter to access the user.
        /// </summary>
        /// <param name="_terminal">The DTS terminal.</param>
        public void Activate(ref Terminal _terminal)
        {
            AccessCodeDialog accessDiag = new AccessCodeDialog();
            if (accessDiag.ShowDialog() == DialogResult.OK)
            {   //If the user hits Enter
                if (_terminal.RetrieveRegisteredUser(accessDiag.AccessCode, out _workingTenant))
                {   //If the access code is registered on the system
                    TelephoneDialog telly = new TelephoneDialog();
                    if (telly.ShowDialog() == DialogResult.OK)
                    {
                        if (_workingTenant.IsNotBarred(new Number(telly.TelephoneNumber)))
                        {   //If the number dialed is not barred to the user
                            ConnectedDialog connected = new ConnectedDialog();
                            DateTime placed = DateTime.Now;
                            if (connected.ShowDialog() == DialogResult.OK)
                            {   //After they hang up, log the call.
                                DateTime ended = DateTime.Now;
                                _workingTenant.UpdateCallLog(new Call(new Number(telly.TelephoneNumber), placed, ended));
                            }
                        }
                    }
                }
            }
        }

    }
}
