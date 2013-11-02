using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: A tenant to the system. 
    /// </summary>
    [Serializable]
    public class Tenant
    {
        /// <summary>
        /// The tenant's access code.
        /// </summary>
        private string _accessCode;
        /// <summary>
        /// The tenant's first name.
        /// </summary>
        private string _first;
        /// <summary>
        /// The tenant's last name.
        /// </summary>
        private string _last;
        /// <summary>
        /// The tenant's call log.
        /// </summary>
        private List<Call> _callLog;
        /// <summary>
        /// The tenant's barred number list.
        /// </summary>
        private List<Bar> _barredList;
        /// <summary>
        /// A string builder used to generate a string
        /// representation of a tenant.
        /// </summary>
        private StringBuilder sb;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="code">The access code.</param>
        /// <param name="first">The first name of the tenant.</param>
        /// <param name="last">The last name of the tenant.</param>
        public Tenant(string code, string first, string last)
        {
            _accessCode = code;
            _first = first;
            _last = last;
            _callLog = new List<Call>();
            _barredList = new List<Bar>();
            sb = new StringBuilder();
        }

        /// <summary>
        /// Display all of the calls made by this tenant.
        /// </summary>
        public void ListCalls()
        {
            ListDialog listDiag = new ListDialog();
            listDiag.AddDisplayItems(_callLog.ToArray());
            listDiag.ShowDialog();
        }

        /// <summary>
        /// Display all of the barred numbers to this tenant.
        /// </summary>
        public void ListBarred()
        {
            ListDialog listDiag = new ListDialog();
            listDiag.AddDisplayItems(_barredList.ToArray());
            listDiag.ShowDialog();
        }

        /// <summary>
        /// Verify that a number is not barred.
        /// </summary>
        /// <param name="number">The number to check.</param>
        /// <returns>True if not barred, false if otherwise.</returns>
        public bool IsNotBarred(Number number)
        {
            Bar bar = null;
            //Check if number is barred
            foreach (Bar b in _barredList)
            {
                if (b.CheckBar(number))
                {
                    bar = b;
                }
            }
            return bar == null;
        }

        /// <summary>
        /// Add a number to the barred list.
        /// </summary>
        /// <param name="barred">The barred number to add.</param>
        public void MakeBarred(Bar barred)
        {
            _barredList.Add(barred);
        }

        /// <summary>
        /// Unbar a certain number. 
        /// </summary>
        /// <param name="number">The number to unbar.</param>
        public void Unbar(Number number)
        {
            Bar b = _barredList.Find(be => (be.CheckBar(number) == true));
            if (b != null)
            {
                _barredList.Remove(b);
            }
        }

        /// <summary>
        /// Remove the calls from the tenant's call log.
        /// </summary>
        public void ClearCallLog()
        {
            _callLog.Clear();
        }

        /// <summary>
        /// Add a call to the call log.
        /// </summary>
        /// <param name="call">The call to add.</param>
        public void UpdateCallLog(Call call)
        {
            //Add call to call log
            _callLog.Add(call);
        }

        /// <summary>
        /// ToString override.
        /// </summary>
        /// <returns>A string representation of a tenant.</returns>
        public override string ToString()
        {
            //Reset the builder
            sb.Clear();

            sb.Append(First); sb.Append(" ");
            sb.Append(Last); sb.Append(" : ");
            sb.Append(AccessCode);

            return sb.ToString();
        }

        /// <summary>
        /// Returns the access code.
        /// </summary>
        public string AccessCode
        {
            get
            {
                return _accessCode;
            }
        }

        /// <summary>
        /// Returns the tenant's first name.
        /// </summary>
        public string First
        {
            get
            {
                return _first;
            }
        }

        /// <summary>
        /// Returns the tenant's last name.
        /// </summary>
        public string Last
        {
            get
            {
                return _last;
            }
        }
    }
}
