using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DTS_Project;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: The terminal is how the administrator
    /// performs various operations on his tenants. 
    /// </summary>
    [Serializable]
    public class Terminal
    {
        /// <summary>
        /// The system password.
        /// </summary>
        private string _password;
        /// <summary>
        /// The list of tenants that will be maintained by the system.
        /// </summary>
        private List<Tenant> _tenantList;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="password">The password (default is "ksu").</param>
        public Terminal(string password = "ksu")
        {
            Password = password;
            _tenantList = new List<Tenant>();
        }

        /// <summary>
        /// When you click on the terminal button, prompt for a password.
        /// Should the password be correct, open the main menu.
        /// </summary>
        public void Activate()
        {
            PasswordDialog _passwordDialog = new PasswordDialog();
            MainMenuDialog _mainMenu = new MainMenuDialog(this);
            if (_passwordDialog.ShowDialog() == DialogResult.OK)
            {
                if (VerifyPassword(_passwordDialog.Password))
                {
                    _mainMenu.ShowDialog();
                }
            }
            _passwordDialog.Clean();
        }

        /// <summary>
        /// Add a tenant.
        /// </summary>
        public void Add()
        {
            InputTenatDialog input = new InputTenatDialog();
            if (input.ShowDialog() == DialogResult.OK)
            {
                this._tenantList.Add(new Tenant(input.AccessCode, input.FirstName, input.LastName));
            }
        }

        /// <summary>
        /// Delete a tenant.
        /// </summary>
        public void Delete()
        {
            LocateTenantDialog locate = new LocateTenantDialog();
            if (locate.ShowDialog() == DialogResult.OK)
            {
                Tenant t = _tenantList.Find(te => (te.First == locate.FirstName
                                           && te.Last == locate.LastName));
                if (t != null)
                {
                    _tenantList.RemoveAll(te => (te.First == locate.FirstName
                                                && te.Last == locate.LastName));
                }
            }
        }

        /// <summary>
        /// List all of the tenants.
        /// </summary>
        public void List()
        {
            ListDialog listDiag = new ListDialog();
            listDiag.AddDisplayItems(_tenantList.ToArray());
            listDiag.ShowDialog();
        }

        /// <summary>
        /// Work on a particular tenant.
        /// </summary>
        public void WorkOn()
        {
            LocateTenantDialog locate = new LocateTenantDialog();
            if (locate.ShowDialog() == DialogResult.OK)
            {
                Tenant t = _tenantList.Find(te => (te.First == locate.FirstName
                                           && te.Last == locate.LastName));
                if (t != null)
                {
                    TenantMenuDialog tenMenu = new TenantMenuDialog(ref t);
                    if (tenMenu.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

        /// <summary>
        /// Change the password to the system.
        /// </summary>
        public void ChangePassword()
        {
            PasswordDialog passDialog = new PasswordDialog();
            if (passDialog.ShowDialog() == DialogResult.OK)
            {
                Password = passDialog.Password;
            }
        }

        /// <summary>
        /// Retrieve a tenant based on their registration code.
        /// </summary>
        /// <param name="code">An access code.</param>
        /// <param name="t">An out parameter for a tenant.</param>
        /// <returns>True if the tenant is found, false otherwise.</returns>
        public bool RetrieveRegisteredUser(string code, out Tenant t)
        {
            t = _tenantList.Find(te => (code == te.AccessCode));

            if (t != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verify the attempted password.
        /// </summary>
        /// <param name="attempt">The attempt.</param>
        /// <returns>True if password is correct, false otherwise.</returns>
        public bool VerifyPassword(string attempt)
        {
            return attempt == Password;
        }

        /// <summary>
        /// Serialize the tenant list for storage.
        /// </summary>
        public void Save()
        {
            FileStream f = new FileStream("data.stn", FileMode.Create, FileAccess.Write);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(f, _tenantList);
            f.Close();
        }

        /// <summary>
        /// Deserialize the tenant list for restoration.
        /// </summary>
        public void Restore()
        {
            FileStream f = new FileStream("data.stn", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bin = new BinaryFormatter();
            _tenantList = (List<Tenant>)bin.Deserialize(f);
            f.Close();
        }

        /// <summary>
        /// Get/Set the password to the system.
        /// </summary>
        protected string Password
        {
            get
            {
                return _password;
            }
            private set
            {
                this._password = value;
            }
        }
    }
}
