using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: Class representing a single
    /// call made by a Tenant.
    /// </summary>
    [Serializable]
    public class Call
    {
        /// <summary>
        /// The number dialed.
        /// </summary>
        private Number _dialed;
        /// <summary>
        /// The time placed.
        /// </summary>
        private DateTime _placed;
        /// <summary>
        /// The time ended.
        /// </summary>
        private DateTime _ended;
        /// <summary>
        /// A string builder used to generate the string representation
        /// of a call.
        /// </summary>
        private StringBuilder sb;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="dialed">The number dialed.</param>
        /// <param name="placed">The (full) time the call was placed.</param>
        /// <param name="ended">The (full) time the call ended.</param>
        public Call(Number dialed, DateTime placed, DateTime ended)
        {
            this._dialed = dialed;
            this._placed = placed;
            this._ended = ended;
            sb = new StringBuilder();
        }

        /// <summary>
        /// ToString override.
        /// </summary>
        /// <returns>A string representing a single call placed by a tenant.</returns>
        public override string ToString()
        {
            //Reset the builder
            sb.Clear();

            sb.Append(_dialed.ToString());
            sb.Append(" : "); sb.Append(_placed.ToString());
            sb.Append(" -- "); sb.Append(_ended.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Returning the number dialed from a call.
        /// </summary>
        public Number Dialed
        {
            get
            {
                return _dialed;
            }
        }
    }
}
