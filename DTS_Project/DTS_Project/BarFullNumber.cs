using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: Class representing an
    /// entire barred number. 
    /// </summary>
    [Serializable]
    class BarFullNumber : Bar
    {
        /// <summary>
        /// A number stored by this barred number.
        /// </summary>
        private Number _number;

        /// <summary>
        /// Non-default constructor.
        /// </summary>
        /// <param name="number">A full number.</param>
        public BarFullNumber(Number number)
        {
            _number = number;
        }

        /// <summary>
        /// ToString override.
        /// </summary>
        /// <returns>A string representation of this barred number.</returns>
        public override string ToString()
        {
            return _number.ToString();
        }

        /// <summary>
        /// Checks whether the full number has been barred or not.
        /// </summary>
        /// <param name="number">An entire number.</param>
        /// <returns>True if barred, false if otherwise.</returns>
        public override bool CheckBar(Number number)
        {
            //I couldn't find a more elegant way to check the number.
            //This is probably really inefficient -- I'll take any advice!
            return (_number.AreaCode == number.AreaCode &&
                     _number.Exchange == number.Exchange &&
                     _number.Subscriber == number.Subscriber);
        }
    }
}
