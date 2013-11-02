﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTS_Project
{
    /// <summary>
    /// Created: Mar 31, 2013 by Tyler Vanover
    /// 
    /// Description: Class representing a
    /// barred number (generalization). Can be inherited. 
    /// </summary>
    [Serializable]
    public partial class Bar
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Bar()
        {
            //Nothing needed
        }

        /// <summary>
        /// Virtual method to be overridden by children classes.
        /// </summary>
        /// <param name="number">A number.</param>
        /// <returns>True if the number is barred. False otherwise.</returns>
        public virtual bool CheckBar(Number number)
        {
            return true;
        }
    }
}
