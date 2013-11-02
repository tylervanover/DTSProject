using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: Class representing a barred
    /// area code. 
    /// </summary>
    [Serializable]
    class BarArea : Bar
    {
        /// <summary>
        /// The area code this barred number will store. For simplicity
        /// we will accept the full number.
        /// </summary>
        private Number _number;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="number">A number.</param>
        public BarArea(Number number)
        {
            this._number = number;
        }

        /// <summary>
        /// ToString override. 
        /// </summary>
        /// <returns>The string representation of a barred area code</returns>
        public override string ToString()
        {
            return _number.ToString();
        }

        /// <summary>
        /// Checks whether the area code is barred or not.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <returns>True if barred, false otherwise.</returns>
        public override bool CheckBar(Number number)
        {
            return _number.AreaCode == number.AreaCode;
        }
    }
}
