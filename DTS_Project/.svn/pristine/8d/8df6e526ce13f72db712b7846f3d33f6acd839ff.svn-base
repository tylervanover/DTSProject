using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    [Serializable]
    public class Admin
    {
        private string _password;
        private List<Tenant> _tenantList;

        public Admin(string password = "ksu")
        {
            Password = password;
            _tenantList = new List<Tenant>();
        }

        public void Add(Tenant tenant)
        {
            this._tenantList.Add(tenant);
        }

        public void Delete(string firstName, string secondName)
        {
            Tenant t = _tenantList.Find(te => (te.First == firstName 
                                            && te.Last == secondName));
            if (t != null) 
            { 
                _tenantList.RemoveAll(te => (te.First == firstName 
                                            && te.Last == secondName));
            }
        }

        public void ChangePassword(string newpassword)
        {
            Password = newpassword;
        }

        public void Display(ListDialog listBox)
        {
            listBox.AddDisplayItems(_tenantList.ToArray());
        }

        public bool RetrieveRegisteredUser(string accessCode, out Tenant t)
        {
            t = _tenantList.Find(te => (accessCode == te.AccessCode));
            
            if (t != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyPassword(string attempt)
        {
            return attempt == Password;
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
    }
}
